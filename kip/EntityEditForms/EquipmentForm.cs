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
    public partial class EquipmentForm : Form
    {
        static Equipment eq = null;

        static List<int> typeIds = new List<int>();

        public EquipmentForm()
        {
            InitializeComponent();
            FillForm();
        }

        public EquipmentForm(DataGridView view)
        {
            InitializeComponent();
            var id = view.CurrentRow.Cells[0].Value;
            FillForm();
            FillEntity((Guid)id);
        }

        private void FillForm()
        {
            using (kipEntities context = new kipEntities())
            {
                var types = context.EquipmentTypeSet.ToList();
                foreach (var type in types)
                {
                    TypeBox.Items.Add(type.name);
                    typeIds.Add(type.id);
                }

                IdBox.Text = Guid.NewGuid().ToString();

                if (eq != null)
                {
                    try
                    {
                        IsWorking.Checked = eq.isWorking;
                        IsFree.Checked = eq.isFree;

                        for (int i = 0; i < TypeBox.Items.Count; i++)
                            if (TypeBox.Items[i].ToString() == eq.EquipmentType.name) TypeBox.SelectedIndex = i;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        eq = null;
                    }
                }
            }
        }

        private void FillEntity(Guid id)
        {
            using (kipEntities context = new kipEntities())
            {
                eq = context.EquipmentSet.Where(b => b.id == id).SingleOrDefault();

                NumberBox.Text = eq.number;
                RepairDate.Text = eq.repairDate.ToString("dd.MM.yy");
                ServiceDate.Text = eq.serviceDate.ToString("dd.MM.yy");

                if (eq.nextVerificationDate.HasValue)
                {
                    var shortString = eq.nextVerificationDate.Value.ToString("dd.MM.yy");
                    VerificationDate.Text = shortString;
                }

                if (eq.termDate.HasValue)
                {
                    var shortString = eq.termDate.Value.ToString("dd.MM.yy");
                    TerminationDate.Text = shortString;
                }


                else TerminationDate.Text = "";
                IsWorking.Checked = eq.isWorking;
                IsFree.Checked = eq.isFree;

                for (int i = 0; i < TypeBox.Items.Count; i++)
                    if (TypeBox.Items[i].ToString() == eq.EquipmentType.name) TypeBox.SelectedIndex = i;

                AddButton.Text = "Сохранить";
                //IdBox.Text = mVPS.Id.ToString();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    CheckFields();
                    int typeId = typeIds[TypeBox.SelectedIndex];
                    var type = context.EquipmentTypeSet.Where(b => b.id == typeId).SingleOrDefault();
                    DateTime dateTimeRepair = DateTime.Parse(RepairDate.Text);
                    DateTime dateTimeService = DateTime.Parse(ServiceDate.Text);
                    //DateTime dateTimeVerification = DateTime.Parse(VerificationDate.Text);

                    DateTime? VerificationDate;
                    DateTime? TerminationDate;

                    bool hasDate = DateTime.TryParse(this.VerificationDate.Text, out DateTime term);
                    if (hasDate) VerificationDate = term;
                    else VerificationDate = null;
                    
                    hasDate = DateTime.TryParse(this.TerminationDate.Text, out term);
                    if (hasDate) TerminationDate = term;
                    else TerminationDate = null;

                    if (eq != null)
                    {
                        Guid id = eq.id;
                        Equipment equipment = context.EquipmentSet.Where(b => b.id == id).SingleOrDefault();

                        if (equipment.EquipmentType.id != typeId) equipment.EquipmentType = type;
                        if (equipment.number != NumberBox.Text) equipment.number = NumberBox.Text;
                        if (equipment.repairDate != dateTimeRepair) equipment.repairDate = dateTimeRepair;
                        if (equipment.serviceDate != dateTimeService) equipment.serviceDate = dateTimeService;
                        if (equipment.nextVerificationDate != VerificationDate) equipment.nextVerificationDate = VerificationDate;
                        if (equipment.termDate != TerminationDate) equipment.termDate = TerminationDate;
                        if (equipment.isWorking != IsWorking.Checked) equipment.isWorking = IsWorking.Checked;
                        if (equipment.isFree != IsFree.Checked) equipment.isFree = IsFree.Checked;

                        context.SaveChanges();
                    }
                    else
                    {
                        eq = new Equipment
                        {
                            id = Guid.Parse(IdBox.Text),
                            EquipmentType = type,
                            number = NumberBox.Text,
                            repairDate = dateTimeRepair,
                            serviceDate = dateTimeService,
                            nextVerificationDate = VerificationDate,
                            termDate = TerminationDate,
                            isWorking = IsWorking.Checked,
                            isFree = IsFree.Checked
                        };
                        context.EquipmentSet.Add(eq);
                        context.SaveChanges();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Close();
                }
            }
        }

        private void CheckFields()
        {
            if (IdBox.Text == "") throw new Exception("Куда то пропал сгенерированный GuID. Вы не брали?");
            if (TypeBox.SelectedIndex == -1) throw new Exception("Необходимо выбрать тип вносимого оборудования");
            if (NumberBox.Text == "") throw new Exception("Введите номер блока");
            if (!DateTime.TryParse(RepairDate.Text, out DateTime time)) throw new Exception("Введена некорректная дата в поле даты ремонта. Введите дату вида - дд.мм.гг");
            if (!DateTime.TryParse(ServiceDate.Text, out time)) throw new Exception("Введена некорректная дата в поле даты обслуживания. Введите дату вида - дд.мм.гг");
            //if (!DateTime.TryParse(VerificationDate.Text, out time)) throw new Exception("Введена некорректная дата в поле даты поверки. Введите дату вида - дд.мм.гг");
        }

        private void EquipmentForm_Load(object sender, EventArgs e)
        {

        }

        private void CancesButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
