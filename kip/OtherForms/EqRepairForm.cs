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
                foreach(var system in systemTypes)
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
                InRepair.Items.Add(item);
            }
        }

        private void InRepair_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (InRepair.SelectedItems.Count == 1)
            {
                var item = InRepair.SelectedItems[0];
                InRepair.Items.Remove(item);
                string type = item.Text.Split(' ')[0];
                FillNotWorkedList(type);
            }
        }

        private void FillNotWorkedList(string NodeText)
        {
            NotWorkedList.Items.Clear();
            
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

            foreach(ListViewItem item in InRepair.Items)
            {
                string str = item.Text;
                var toRemoveFromList = NotWorkedList.FindItemWithText(str);
                NotWorkedList.Items.Remove(toRemoveFromList);
            }
        }
    }
}

