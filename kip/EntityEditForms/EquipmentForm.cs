using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

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
                    typeIds.Add(type.Id);
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
                        DateTime date;
                        if (eq.nextVerificationDate.HasValue)
                        {
                            date = eq.nextVerificationDate.Value;
                            VerificationDate.Text = date.ToString("dd.MM.yy");
                        }
                        if (eq.termDate.HasValue)
                        {
                            date = eq.termDate.Value;
                            TerminationDate.Text = date.ToString("dd.MM.yy");
                        }
                        RepairDate.Text = eq.repairDate.ToString("dd.MM.yy");
                        ServiceDate.Text = eq.serviceDate.ToString("dd.MM.yy");

                    }
                    catch (Exception ex)
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
                eq = context.EquipmentSet.Where(b => b.Id == id).SingleOrDefault();

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
                    var type = context.EquipmentTypeSet.Where(b => b.Id == typeId).SingleOrDefault();
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

                    if (this.VerificationDate.Enabled)
                        if (!DateTime.TryParse(this.VerificationDate.Text, out DateTime time)) throw new Exception("Введена некорректная дата в поле даты поверки. Введите дату вида - дд.мм.гг");

                    if (eq != null)
                    {
                        Guid id = eq.Id;
                        Equipment equipment = context.EquipmentSet.Where(b => b.Id == id).SingleOrDefault();

                        if (equipment.EquipmentType.Id != typeId) equipment.EquipmentType = type;
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
                            Id = Guid.Parse(IdBox.Text),
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
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        }

        private void EquipmentForm_Load(object sender, EventArgs e)
        {

        }

        private void CancesButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetQRCode_Click(object sender, EventArgs e)
        {
            if (eq != null)
            {
                ZXing.QrCode.QrCodeEncodingOptions opt = new ZXing.QrCode.QrCodeEncodingOptions
                {
                    CharacterSet = "utf-8",
                    Height = 200,
                    Width = 200
                };

                var writer = new BarcodeWriter
                {
                    Format = BarcodeFormat.QR_CODE,
                    Options = opt
                };

                string str = eq.Id.ToString() + "," + eq.EquipmentType.name + "," + eq.number;

                Dictionary<EncodeHintType, object> hints = new Dictionary<EncodeHintType, object>();
                hints.Add(EncodeHintType.CHARACTER_SET, "utf-8");

                SaveFileDialog savefile = new SaveFileDialog();
                // set a default file name
                savefile.FileName = eq.EquipmentType.name + "_" + eq.number + ".png";
                // set filters - this can be done in properties as well
                savefile.Filter = "PNG files (*.png)|*.png";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    writer.Write(str).Save(savefile.FileName, ImageFormat.Png);
                }
            }
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (kipEntities context = new kipEntities())
            {
                int typeId = typeIds[TypeBox.SelectedIndex];
                var type = context.EquipmentTypeSet.Where(b => b.Id == typeId).SingleOrDefault();
                if ((!type.verfPeriod.HasValue) || (type.verfPeriod.Value == 0)) VerificationDate.Enabled = false;
                else VerificationDate.Enabled = true;
            }
        }
    }
}
