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
    public partial class ManufacturerForm : Form
    {
        static Manufacturer manufacturer = null;

        public ManufacturerForm()
        {
            InitializeComponent();
            FillForm();
        }

        public ManufacturerForm(DataGridView view)
        {
            InitializeComponent();
            var id = view.CurrentRow.Cells[0].Value;
            FillForm();
            FillEntity((int)id);
        }

        private void ManufacturerForm_Load(object sender, EventArgs e)
        {

        }

        private void FillEntity(int id)
        {
            using (kipEntities context = new kipEntities())
            {
                manufacturer = context.ManufacturerSet.Where(b => b.Id == id).SingleOrDefault();
                ManufacturerNameBox.Text = manufacturer.name;
                ManufacturerAddressBox.Text = manufacturer.address;
                ManufacturerPhoneBox.Text = manufacturer.phone;
                ManufacturerEmailBox.Text = manufacturer.email;
            }
            AddButton.Text = "Сохранить";
        }

        private void FillForm()
        {
            ManufacturerNameBox.Text = "Введите название производителя";
            ManufacturerAddressBox.Text = "Введите адрес производителя";
            ManufacturerPhoneBox.Text = "Введите телефон производителя";
            ManufacturerEmailBox.Text = "Введите e-mail производителя";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    CheckFields();
                    if (manufacturer != null)
                    {
                        int key = manufacturer.Id;
                        Manufacturer freshMan = context.ManufacturerSet.Where(b => b.Id == key).SingleOrDefault();
                        string str = ManufacturerNameBox.Text;
                        if ((freshMan.name != str) && (str != "")) freshMan.name = str;
                        if ((ManufacturerAddressBox.Text != "") && (ManufacturerAddressBox.Text != freshMan.address)) freshMan.address = ManufacturerAddressBox.Text;
                        if ((ManufacturerPhoneBox.Text != "") && (ManufacturerPhoneBox.Text != freshMan.phone))freshMan.phone = ManufacturerPhoneBox.Text;
                        if ((ManufacturerEmailBox.Text != "") && (ManufacturerEmailBox.Text != freshMan.email))freshMan.email = ManufacturerEmailBox.Text;
                        context.SaveChanges();
                    }
                    else
                    {
                        CheckFields();
                        string str = ManufacturerNameBox.Text;
                        if (str != "")
                        {
                            Manufacturer freshMan = new Manufacturer
                            {
                                name = str,
                                address = ManufacturerAddressBox.Text,
                                phone = ManufacturerPhoneBox.Text,
                                email = ManufacturerEmailBox.Text,
                        };
                            context.ManufacturerSet.Add(freshMan);
                            context.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
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
            if((ManufacturerNameBox.Text == "") && (ManufacturerNameBox.Text == "Введите название производителя")) throw new Exception("Введите коректное название производителя");
            if ((ManufacturerAddressBox.Text == "") && (ManufacturerAddressBox.Text == "Введите адрес производителя")) throw new Exception("Введите коректный адрес");
            if ((ManufacturerPhoneBox.Text == "") && (ManufacturerPhoneBox.Text == "Введите телефон производителя")) throw new Exception("Введите коректный телефон");
            if ((ManufacturerEmailBox.Text == "") && (ManufacturerEmailBox.Text == "Введите e-mail производителя")) throw new Exception("Введите коректный e-mail");
        }
    }
}
