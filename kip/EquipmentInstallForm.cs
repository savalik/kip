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
    public partial class EquipmentInstallForm : Form
    {
        static int flag=0;
        static Guid mvpsGuid;

        public EquipmentInstallForm()
        {
            InitializeComponent();
            FillForm();
        }

        private void FillForm()
        {
            using(kipEntities context = new kipEntities())
            {
                try
                {
                    var roles = context.MVPSRoleSet.ToList();
                    var types = context.MVPSTypeSet.ToList();
                    var seriesSet = context.MVPSSet.Select(b => b.series).ToList();
                    List<string> unicalSeries = new List<string>();

                    foreach (MVPSRole role in roles)
                    {
                        MVPSRoleBox.Items.Add(role.name);
                    }
                    foreach (MVPSType type in types)
                    {
                        MVPSTypeBox.Items.Add(type.name);
                    }
                    foreach (string series in seriesSet)
                    {
                        if (unicalSeries.Find(b => b == series) != series) unicalSeries.Add(series);
                    }
                    foreach (string str in unicalSeries)
                        MVPSSeriesBox.Items.Add(str);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EquipmentInstallForm_Load(object sender, EventArgs e)
        {
            
        }

        private bool CheckAllSelected()
        {
            if ((MVPSNumberBox.SelectedIndex != -1) &&
                (MVPSSeriesBox.SelectedIndex != -1) &&
                (MVPSTypeBox.SelectedIndex != -1))
                return true;
            else return false;
        }

        private void MVPSSeriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNumberBox();
        }

        private void FillNumberBox()
        {
            if (MVPSSeriesBox.SelectedIndex != -1)
            {
                using (kipEntities context = new kipEntities())
                {
                    try
                    {
                        if (MVPSTypeBox.SelectedIndex == -1) MVPSTypeBox.SelectedIndex = 0;

                        string series = MVPSSeriesBox.SelectedItem.ToString();
                        string type = MVPSTypeBox.SelectedItem.ToString();
                        string role;
                        IEnumerable<MVPS> numbers;

                        if (MVPSRoleBox.SelectedIndex != -1)
                        {
                            role = MVPSRoleBox.SelectedItem.ToString();
                            numbers = context.MVPSSet.Where(b => (b.series == series) && (b.MVPSType.name == type) && (b.MVPSRole.name == role)).ToList();
                        }
                        else
                        {
                            numbers = context.MVPSSet.Where(b => (b.series == series) && (b.MVPSType.name == type)).ToList();
                        }

                        mvpsGrid.Rows.Clear();
                        MVPSNumberBox.Items.Clear();
                        foreach (var MVPS in numbers)
                            MVPSNumberBox.Items.Add(MVPS.number);


                        if (MVPSNumberBox.Items.Count > 0) 
                        {
                            MVPSNumberBox.SelectedIndex = 0;
                            flag = 0;
                        }
                        else
                        {
                            MVPSNumberBox.SelectedIndex = -1;
                            MVPSNumberBox.Text = "";
                            TryAnotherType();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
        }

        private void FillGrid()
        {
            mvpsGuid = Guid.Empty;

            if (CheckAllSelected())
            {
                using (kipEntities context = new kipEntities())
                {
                    try
                    {
                        var type = MVPSTypeBox.SelectedItem.ToString();
                        var series = MVPSSeriesBox.SelectedItem.ToString();
                        var number = MVPSNumberBox.SelectedItem.ToString();

                        MVPS mvps = context.MVPSSet.Where(b => (b.series == series) &&
                                            (b.MVPSType.name == type) && (b.number == number)).SingleOrDefault();

                        mvpsGuid = mvps.Id;

                        var rules = mvps.EquipmentRule.EquipmentType.ToList();
                        int i = 0;
                        mvpsGrid.Rows.Clear();
                        foreach (var rule in rules)
                        {
                            string cell1=null, cell2 = null,cell3 = null, cell4 = null;
                            var block = mvps.Equipment.Where(b => b.EquipmentType == rule).SingleOrDefault();
                            Guid? cell0 = null;
                            cell1 = rule.name;
                            cell2 = rule.SystemType.name;
                            if (block != null)
                            {
                                 cell0 = block.Id;
                                 cell3 = block.number;
                                 cell4 = block.serviceDate.ToString("dd.MM.yy");
                            }

                            mvpsGrid.Rows.Add(cell0,cell1,cell2,cell3,cell4);
                            i++;
                        }

                        FillEquipmentGrid(mvpsGrid[1, 0].Value.ToString());
                        //var equipments = mvps.Equipment

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void MVPSRoleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNumberBox();
        }

        private void MVPSTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNumberBox();
        }

        private void MVPSNumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void TryAnotherType()
        {
            if (flag < MVPSTypeBox.Items.Count)
                if (MVPSNumberBox.SelectedIndex == -1)
                    //if (MVPSRoleBox.SelectedIndex != -1)
                        if (MVPSNumberBox.Items.Count == 0)
                            if (MVPSTypeBox.SelectedIndex < (MVPSTypeBox.Items.Count -1))
                            {
                                flag++;
                                MVPSTypeBox.SelectedIndex += 1;
                                
                            }
                            else
                            {
                                flag++;
                                MVPSTypeBox.SelectedIndex = 0;
                            }
        }

        private void MvpsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MvpsGrid_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (CheckAllSelected() && !CheckEmpty())
            {
                using (kipEntities context = new kipEntities())
                {
                    Guid id = Guid.Parse(mvpsGrid[0, e.RowIndex].Value.ToString());
                    Equipment equipment = context.EquipmentSet.Where(b => b.Id == id).SingleOrDefault();

                    DialogResult result = MessageBox.Show("Нажмите \"Да\", если блок снимается по неисправности. Если блок снимается по другой причине - нажмите \"Нет\"", "Снимаем " + equipment.EquipmentType.name + " № " + equipment.number, MessageBoxButtons.YesNoCancel);

                    MVPS mvps = context.MVPSSet.Where(b => b.Id == mvpsGuid).SingleOrDefault();

                    equipment.isFree = true;
                    mvps.Equipment.Remove(equipment);
                    context.SaveChanges();

                    switch (result)
                    {
                        case DialogResult.Yes:
                            equipment.isWorking = false;
                            equipment.isFree = true;
                            mvps.Equipment.Remove(equipment);
                            context.SaveChanges();
                            break;
                        case DialogResult.No:
                            equipment.isFree = true;
                            mvps.Equipment.Remove(equipment);
                            context.SaveChanges();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                FillGrid();
            }
        }

        private void MvpsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            FillEquipmentGrid(mvpsGrid[1,e.RowIndex].Value.ToString());
        }

        private void FillEquipmentGrid(string v)
        {
            using (kipEntities context = new kipEntities())
                try
                {
                    var equipments = context.EquipmentSet.Where(b => (b.EquipmentType.name == v) && (b.isFree) && (b.isWorking)).ToList();
                    equipmentGrid.Rows.Clear();
                    foreach (var eq in equipments)
                        equipmentGrid.Rows.Add(eq.Id, eq.EquipmentType.name ,eq.number.ToString(), eq.serviceDate.ToString("dd.MM.yy"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void EquipmentGrid_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (CheckAllSelected() && CheckEmpty())
            {
                if (equipmentGrid[0,e.RowIndex].Value.ToString() != "")
                {
                    using(kipEntities context = new kipEntities())
                    {
                        Guid id = Guid.Parse(equipmentGrid[0, e.RowIndex].Value.ToString());
                        Equipment equipment = context.EquipmentSet.Where(b => b.Id == id).SingleOrDefault();

                        MVPS mvps = context.MVPSSet.Where(b => b.Id == mvpsGuid).SingleOrDefault();

                        equipment.isFree = false;
                        mvps.Equipment.Add(equipment);

                        context.SaveChanges();
                    }
                    FillGrid();
                }
            }
            else
                MessageBox.Show("Что-то пошло не так, возможно вы пытаетесь установить блок на занятую позицию.");
        }

        private bool CheckEmpty()
        {
            try
            {
                string value = "";
                int row = mvpsGrid.CurrentRow.Index;
                if(mvpsGrid[3, row].Value != null)
                value = mvpsGrid[3, row].Value.ToString();
                if (value != "") return false;
                else return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }

        private void MvpsGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
