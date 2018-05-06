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
    public partial class EquipmentRuleForm : Form
    {
        static EquipmentRule rule = null;

        static List<int> sysTypeId = new List<int>();   // 
        static List<int> roleId = new List<int>();      // roleId[MVPSRoleBox_.SelectedIndex]
        static List<int> typeId = new List<int>();      // typeId[MVPSTypeBox_.SelectedIndex]
        static List<int> eqTypeId = new List<int>();
        static List<int> InRuleEqId = new List<int>();  // InRuleEqId - идет для сбора штук

        public EquipmentRuleForm()
        {
            InitializeComponent();
            FillForm();
        }

        public EquipmentRuleForm(DataGridView view)
        {
            InitializeComponent();
            var id = view.CurrentRow.Cells[0].Value;
            FillForm();
            FillEntity((int)id);
        }

        private void EquipmentRuleForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillForm()
        {
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    var mvpsRole = context.MVPSRoleSet.ToList();
                    var mvpsType = context.MVPSTypeSet.ToList();
                    var systemType = context.SystemTypeSet.ToList();

                    foreach (MVPSRole role in mvpsRole)
                    {
                        MVPSRoleBox_.Items.Add(role.name);
                        roleId.Add(role.Id);
                    }
                    foreach (MVPSType type in mvpsType)
                    {
                        MVPSTypeBox_.Items.Add(type.name);
                        typeId.Add(type.Id);
                    }
                    foreach (SystemType type in systemType)
                    {
                        SystemTypeBox.Items.Add(type.name);
                        sysTypeId.Add(type.Id);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FillEntity(int id)
        {
            using (kipEntities context = new kipEntities())
            {
                rule = context.EquipmentRuleSet.Where(b => b.Id == id).SingleOrDefault();

                for(int i=0; i < MVPSRoleBox_.Items.Count; i++)
                {
                    if (MVPSRoleBox_.Items[i].ToString() == rule.MVPSRole.name)
                    {
                        MVPSRoleBox_.SelectedIndex = i;
                    }
                }

                for (int i = 0; i < MVPSTypeBox_.Items.Count; i++)
                {
                    if (MVPSTypeBox_.Items[i].ToString() == rule.MVPSType.name)
                    {
                        MVPSTypeBox_.SelectedIndex = i;
                    }
                }

                foreach(EquipmentType eq in rule.EquipmentType)
                {
                    EquipmentTypeBox.Items.Add(eq.name);
                    InRuleEqId.Add(eq.id);
                }
            }
        }

        private void SystemTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSystemTypeBox(SystemTypeBox.SelectedIndex);
        }

        private void FillSystemTypeBox(int selectedIndex)
        {
            using (kipEntities context = new kipEntities())
            {
                EquipmentTypeBox_.Items.Clear();
                int key = sysTypeId[selectedIndex];
                var eqType = context.EquipmentTypeSet.Where(b => b.SystemType.Id == key).ToList();

                foreach (EquipmentType eq in eqType)
                {
                    EquipmentTypeBox_.Items.Add(eq.name);
                    eqTypeId.Add(eq.id);
                }
            }
        }

        private void MVPSRoleBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            MVPSRoleBox.Text = MVPSRoleBox_.SelectedItem.ToString();
        }

        private void MVPSTypeBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            MVPSTypeBox.Text = MVPSTypeBox_.SelectedItem.ToString();
        }

        void EquipmentTypeBox__MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = EquipmentTypeBox_.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                EquipmentTypeBox.Items.Add(EquipmentTypeBox_.Items[index]);
                InRuleEqId.Add(eqTypeId[index]);
            }
        }

        private void EquipmentTypeBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = EquipmentTypeBox_.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                EquipmentTypeBox.Items.RemoveAt(index);
                InRuleEqId.RemoveAt(index);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    int _roleId = roleId[MVPSRoleBox_.SelectedIndex];
                    int _typeId = typeId[MVPSTypeBox_.SelectedIndex];
                    var role = context.MVPSRoleSet.Where(b => b.Id == _roleId).SingleOrDefault();
                    var type = context.MVPSTypeSet.Where(b => b.Id == _typeId).SingleOrDefault();
                    List<EquipmentType> eqList = new List<EquipmentType>();

                    foreach (int k in InRuleEqId)
                    {
                        var equipmentTypes = context.EquipmentTypeSet.Where(b => b.id == k).SingleOrDefault();
                        eqList.Add(equipmentTypes);
                    }

                    if (rule == null)
                    {

                        context.EquipmentRuleSet.Add(new EquipmentRule
                        {
                            MVPSRole = role,
                            MVPSType = type,
                            EquipmentType = eqList
                        });
                    }
                    else
                    {
                        
                        int key = rule.Id;
                        EquipmentRule freshRule = context.EquipmentRuleSet.Where(b => b.Id == key).SingleOrDefault();
                        freshRule.MVPSRole = role;
                        freshRule.MVPSType = type;
                        freshRule.EquipmentType = eqList;
                    }
                    context.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            rule = null;
            sysTypeId.Clear();  
            roleId.Clear();        
            typeId.Clear();       
            eqTypeId.Clear();
            InRuleEqId.Clear();

            Close();
        }
    }
}
