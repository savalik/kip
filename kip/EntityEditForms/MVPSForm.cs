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
    public partial class MVPSForm : Form
    {
        static MVPS mVPS = null;

        static List<int> roleIds = new List<int>();
        static List<int> typeIds = new List<int>();
        static List<EquipmentRule> currentRules = new List<EquipmentRule>();

        public MVPSForm()
        {
            InitializeComponent();
            FillForm();
        }

        public MVPSForm(DataGridView view)
        {
            InitializeComponent();
            var id = view.CurrentRow.Cells[0].Value;
            FillForm();
            FillEntity((Guid)id);
        }

        private void FillEntity(Guid id)
        {
            using (kipEntities context = new kipEntities())
            {
                mVPS = context.MVPSSet.Where(b => b.Id == id).SingleOrDefault();
                NumberBox.Text = mVPS.number;
                SeriesBox.Text = mVPS.series;
                
                for (int i= 0; i < RoleBox.Items.Count; i++)
                    if (RoleBox.Items[i].ToString() == mVPS.MVPSRole.name) RoleBox.SelectedIndex = i;

                for (int i = 0; i < TypeBox.Items.Count; i++)
                    if (TypeBox.Items[i].ToString() == mVPS.MVPSType.name) TypeBox.SelectedIndex = i;

                AddButton.Text = "Сохранить";
                IdBox.Text = mVPS.Id.ToString();
            }
        }

        private void FillForm()
        {
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    IdBox.Text = Guid.NewGuid().ToString();
                    //TypeBox & RoleBox
                    var types = context.MVPSTypeSet.ToList();
                    var roles = context.MVPSRoleSet.ToList();
                    var currentRules = context.EquipmentRuleSet.ToList();

                    foreach(MVPSRole role in roles)
                    {
                        RoleBox.Items.Add(role.name);
                        roleIds.Add(role.Id);
                    }

                    foreach (MVPSType type in types)
                    {
                        TypeBox.Items.Add(type.name);
                        typeIds.Add(type.Id);
                    }

                    if (mVPS != null)
                    {
                        for (int i = 0; i < RoleBox.Items.Count; i++)
                            if (RoleBox.Items[i].ToString() == mVPS.MVPSRole.name) RoleBox.SelectedIndex = i;

                        for (int i = 0; i < TypeBox.Items.Count; i++)
                            if (TypeBox.Items[i].ToString() == mVPS.MVPSType.name) TypeBox.SelectedIndex = i;

                        GetRuleList();
                        SeriesBox.Text = mVPS.series;
                    }
                    mVPS = null;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MVPSForm_Load(object sender, EventArgs e)
        {
            
        }

        private void RuleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    if ((TypeBox.SelectedIndex == -1) || (RoleBox.SelectedIndex == -1)) throw new Exception("Необходимо выбрать роль и тип МВПС");

                    int key = currentRules[RuleBox.SelectedIndex].Id;
                    var types = context.EquipmentRuleSet.Where(b => b.Id == key).SingleOrDefault();
                    RuleList.Items.Clear();
                    foreach (EquipmentType type in types.EquipmentType)
                    {
                        RuleList.Items.Add(type.name);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void GetRuleList()
        {
            RuleBox.Items.Clear();
            currentRules.Clear();

            if ((TypeBox.SelectedIndex > -1) && (RoleBox.SelectedIndex > -1))
            {
                using (kipEntities context = new kipEntities())
                {
                    try
                    {
                        int roleId = roleIds[RoleBox.SelectedIndex];
                        int typeId = typeIds[TypeBox.SelectedIndex];

                        var rules = context.EquipmentRuleSet.Where(b => (b.MVPSRole.Id == roleId) && (b.MVPSType.Id == typeId)).ToList();

                        foreach (EquipmentRule rule in rules)
                        {
                            RuleBox.Items.Add(rule.Id);
                            currentRules.Add(rule);
                        }
                        if (RuleBox.Items.Count == 0) throw new Exception("Для данной комбинации Типа МВПС и роли МВПС нет правил компектации.");
                        if (RuleBox.SelectedIndex < 0) RuleBox.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRuleList();
        }

        private void RoleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRuleList();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Guid guid = mVPS == null? Guid.Empty : mVPS.Id;
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    CheckFields();
                    if (mVPS != null)
                    {
                        int typeId = typeIds[TypeBox.SelectedIndex];
                        int roleId = roleIds[RoleBox.SelectedIndex];
                        int ruleId = currentRules[RuleBox.SelectedIndex].Id;
                        MVPSType type = context.MVPSTypeSet.Where(b => b.Id == typeId).SingleOrDefault();
                        MVPSRole role = context.MVPSRoleSet.Where(b => b.Id == roleId).SingleOrDefault();
                        EquipmentRule rule = context.EquipmentRuleSet.Where(b => b.Id == ruleId).SingleOrDefault();
                        MVPS mVPS = context.MVPSSet.Where(b => b.Id == guid).SingleOrDefault();
                        if (mVPS.MVPSRole.Id != role.Id) mVPS.MVPSRole = role;
                        if (mVPS.MVPSType.Id != type.Id) mVPS.MVPSType = type;
                        if (mVPS.number != NumberBox.Text) mVPS.number = NumberBox.Text;
                        if (mVPS.series != SeriesBox.Text) mVPS.series = SeriesBox.Text;
                        if (mVPS.EquipmentRule.Id != rule.Id) mVPS.EquipmentRule = rule;
                        context.SaveChanges();
                    }
                    else
                    {
                        int typeId = typeIds[TypeBox.SelectedIndex];
                        int roleId = roleIds[RoleBox.SelectedIndex];
                        int ruleId = currentRules[RuleBox.SelectedIndex].Id;
                        MVPSType type = context.MVPSTypeSet.Where(b => b.Id == typeId).SingleOrDefault();
                        MVPSRole role = context.MVPSRoleSet.Where(b => b.Id == roleId).SingleOrDefault();
                        EquipmentRule rule = context.EquipmentRuleSet.Where(b => b.Id == ruleId).SingleOrDefault();

                        mVPS = new MVPS
                        {
                            Id = Guid.Parse(IdBox.Text),
                            number = NumberBox.Text,
                            series = SeriesBox.Text,
                            MVPSType = type,
                            MVPSRole = role,
                            EquipmentRule = rule
                        };

                        context.MVPSSet.Add(mVPS);
                        context.SaveChanges();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    roleIds.Clear();
                    typeIds.Clear();
                    currentRules.Clear();
                    Close();
                }
            }
        }

        private void CheckFields()
        {
            if (NumberBox.Text == "") throw new Exception("Введите номер вагона");
            if (SeriesBox.Text == "") throw new Exception("Введите серию вагона");
            if (RuleBox.SelectedIndex == -1) throw new Exception("Выберите правило комплектации вагона");
            if (RoleBox.SelectedIndex == -1) throw new Exception("Выберите роль вагона");
            if (TypeBox.SelectedIndex == -1) throw new Exception("Выберите тип вагона");
        }

        private void NumberBox_LostFocus(object sender, EventArgs e)
        {
            if ((int.Parse(NumberBox.Text) > 16) || ((int.Parse(NumberBox.Text) < 1)))
            {
                MessageBox.Show("Номер вагона должен находиться в пределах от 1 до 16");
                NumberBox.Text = "01";
            }
        }
    }
}
