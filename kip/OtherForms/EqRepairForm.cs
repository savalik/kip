using KipLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class EqRepairForm : Form
    {
        public static Worker worker;
        static Form LoginForm;
        List<String> Comments = new List<string>();
        static string LastSystemType;
        static int LastSelectedInRepairIndex;

        public EqRepairForm(Worker loggedWorker, Form Form)
        {
            InitializeComponent();
            worker = loggedWorker;
            LoginForm = Form;
            FillForm();
        }

        private void EqRepairForm_Load(object sender, EventArgs e)
        {

        }

        private void FillForm()
        {
            UserLabel.Text = worker.Family + " " + worker.Name + " " + worker.Patronymic;
            PersonnelNumberlLabel.Text = worker.PersonnelNumber.ToString();
            PositionLabel.Text = worker.Position.name;

            using (kipEntities context = new kipEntities())
            {

                var systemTypes = context.SystemTypeSet;
                foreach (var system in systemTypes)
                {
                    EquipmentTypes.Nodes.Add(system.name);
                    int x = EquipmentTypes.Nodes.Count - 1;
                    foreach (var type in system.EquipmentType)
                        EquipmentTypes.Nodes[x].Nodes.Add(type.name);
                };
            }
        }

        private void EquipmentTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                string type = e.Node.Text;
                FillNotWorkedList(type);
            }
        }

        private void NotWorkedList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (NotWorkedList.SelectedItems.Count == 1)
            {
                var item = NotWorkedList.SelectedItems[0];
                NotWorkedList.Items.Remove(item);
                Comments.Add("Введите комментарий к проверке\\ремонту блока " + item.Text);
                InRepair.Items.Add(item);
            }
        }

        private void InRepair_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (InRepair.SelectedItems.Count == 1)
            {
                var item = InRepair.SelectedItems[0];
                int index = item.Index;
                InRepair.Items.Remove(item);
                Comments.RemoveAt(index);
                string type = item.Text.Split(' ')[0];
                FillNotWorkedList(type);
            }
        }

        private void InRepair_MouseClick(object sender, MouseEventArgs e) => ShowContextMenu(e, true);
        private void NotWorkedList_MouseClick(object sender, MouseEventArgs e) => ShowContextMenu(e, false);

        private void ShowContextMenu(MouseEventArgs e, bool isInRepairList)
        {
            string text="";
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                if (isInRepairList)
                {
                    if (InRepair.FocusedItem.Bounds.Contains(e.Location) == true)
                    {
                        text =  InRepair.SelectedItems[0].Text;
                        contextMenuStrip.Items.Add("Показать историю");
                    }
                        
                }
                else
                {
                    if (NotWorkedList.FocusedItem.Bounds.Contains(e.Location) == true)
                    {
                        text = NotWorkedList.SelectedItems[0].Text;
                        contextMenuStrip.Items.Add("Показать историю");
                    }
                }

                contextMenuStrip.Click += (sender, x) => GetEventLog(text);
                contextMenuStrip.Show(Cursor.Position);
            }
        }

        private void GetEventLog(string text)
        {
            string[] vs = text.Split(' ');
            try
            {
                using (kipEntities context = new kipEntities())
                {
                    var type = vs[0];
                    var number = vs[1];
                    Equipment eq = context.EquipmentSet.Where(b => b.EquipmentType.name == type  && b.number == number).Single();
                    Form form = new ServiceLogForm(eq.ServiceLog.First().Id);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillNotWorkedList(string NodeText)
        {
            NotWorkedList.Items.Clear();
            LastSystemType = NodeText;

            using (kipEntities context = new kipEntities())
            {
                var equipments = from eqType in context.EquipmentSet
                                 where eqType.EquipmentType.name == NodeText
                                 select eqType;
                var nonWorked = from eq in equipments
                                where eq.isFree
                                select eq;
                foreach (var block in nonWorked)
                {
                    string str = String.Format(" {0:P2}", block.GetRemainingLife());
                    var color = block.GetColor();
                    if (!block.isWorking)
                    {
                        color = Color.DarkRed;
                        str = " неиспр.";
                    }
                    NotWorkedList.Items.Add(block.EquipmentType.name + " " + block.number + str).ForeColor = color;
                }

            }

            foreach (ListViewItem item in InRepair.Items)
            {
                string str = item.Text;
                var toRemoveFromList = NotWorkedList.FindItemWithText(str);
                NotWorkedList.Items.Remove(toRemoveFromList);
            }
        }

        private void InRepair_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InRepair.SelectedItems.Count == 1)
            {
                var item = InRepair.SelectedItems[0];
                int index = item.Index;
                CommentaryBox.Text = Comments[index];
                LastSelectedInRepairIndex = index;
            }
        }

        private void DoRepairButton_Click(object sender, EventArgs e)
        {
            if (CheckAllInRepair(true))
            {
                var result = MessageBox.Show("Открыть дефектные ведомости?", "Ремонт оборудования", MessageBoxButtons.YesNo);
                foreach (ListViewItem item in InRepair.Items)
                {
                    string[] vs = item.Text.Split(' ');
                    using (kipEntities context = new kipEntities())
                    {
                        string type = vs[0], number = vs[1];
                        var eq = context.EquipmentSet.Where(b => b.EquipmentType.name == type && b.number == number).SingleOrDefault();
                        if (eq == null) throw new Exception("Что-то пошло не так, не найден блок с типом " + vs[0] + " и номером" + vs[1]);
                        else Items.CreateItem(vs[0], vs[1], eq.Id.ToString(), true);
                    }
                }
                if (result == DialogResult.Yes)
                {
                    Docs.OpenDocs(Items.GetItems);
                }
                Repair.DoRepairOrCheck(worker, Comments, true);
                Comments.Clear();
                InRepair.Clear();
                FillNotWorkedList(LastSystemType);
            }
        }

        private void DoServiceButton_Click(object sender, EventArgs e)
        {
            if (CheckAllInRepair(false))
            {
                var result = MessageBox.Show("Открыть дефектные ведомости?", "Ремонт оборудования", MessageBoxButtons.YesNo);
                foreach (ListViewItem item in InRepair.Items)
                {
                    string[] vs = item.Text.Split(' ');
                    using (kipEntities context = new kipEntities())
                    {
                        string type = vs[0], number = vs[1];
                        var eq = context.EquipmentSet.Where(b => b.EquipmentType.name == type && b.number == number).SingleOrDefault();
                        if (eq == null) throw new Exception("Что-то пошло не так, не найден блок с типом " + vs[0] + " и номером" + vs[1]);
                        else Items.CreateItem(vs[0], vs[1], eq.Id.ToString(), false);
                    }
                }
                if (result == DialogResult.Yes)
                {
                    Docs.OpenDocs(Items.GetItems);
                }
                Repair.DoRepairOrCheck(worker, Comments, false);
                Comments.Clear();
                InRepair.Clear();
                FillNotWorkedList(LastSystemType);
            }
        }

        private bool CheckAllInRepair(bool isRepair)
        {
            Items.GetItems.Clear();
            try
            {
                if (isRepair)
                {
                    foreach (ListViewItem item in InRepair.Items)
                        if (!item.Text.Contains("неиспр.")) throw new Exception("В списке для ремонта есть оборудование для проверки. Проверьте список.");
                }
                else
                {
                    foreach (ListViewItem item in InRepair.Items)
                        if (item.Text.Contains("неиспр.")) throw new Exception("В списке для проверки есть оборудование для ремонта. Проверьте список.");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void SaveComment_Click(object sender, EventArgs e)
        {
            Comments[LastSelectedInRepairIndex] = CommentaryBox.Text;
        }
    }
}

