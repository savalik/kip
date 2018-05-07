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
    public partial class EquipmentTypeForm : Form
    {
        static EquipmentType type = null;

        static List<int> sysTypeId = new List<int>();
        static List<int> manufactId = new List<int>();
        

        public EquipmentTypeForm()
        {
            InitializeComponent();
            FillForm();
        }

        public EquipmentTypeForm(DataGridView view)
        {
            InitializeComponent();
            var id = view.CurrentRow.Cells[0].Value;
            FillForm();
            FillEntity((int)id);
        }
        
        private void FillEntity(int id)
        {
            using (kipEntities context = new kipEntities())
            {
                type = context.EquipmentTypeSet.Where(b => b.id == id).SingleOrDefault();

                for (int i = 0; i < SysTypeBox.Items.Count; i++)
                    if (SysTypeBox.Items[i].ToString() == type.SystemType.name) SysTypeBox.SelectedIndex = i;
                
                for (int i = 0; i < ManufactBox.Items.Count; i++)                
                    if (ManufactBox.Items[i].ToString() == type.Manufacturer.name) ManufactBox.SelectedIndex = i;
                
                DescriptionBox.Text = type.description;
                NameBox.Text = type.name;

                AddButton.Text = "Сохранить";
            }
        }

        private void FillForm()
        {
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    DescriptionBox.Text = "Введите описание типа оборудования";
                    NameBox.Text = "Введите наименование типа";

                    var sysTypes = context.SystemTypeSet.ToList();
                    var manufacts = context.ManufacturerSet.ToList();

                    foreach (SystemType type in sysTypes)
                    {
                        SysTypeBox.Items.Add(type.name);
                        sysTypeId.Add(type.Id);
                    }
                    foreach (Manufacturer manufact in manufacts)
                    {
                        ManufactBox.Items.Add(manufact.name);
                        manufactId.Add(manufact.id);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EquipmentTypeForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    CheckFields();

                    int _sysTypeId = sysTypeId[SysTypeBox.SelectedIndex];
                    int _manufactId = manufactId[ManufactBox.SelectedIndex];
                    var sysType = context.SystemTypeSet.Where(b => b.Id == _sysTypeId).SingleOrDefault();
                    var manf = context.ManufacturerSet.Where(b => b.id == _manufactId).SingleOrDefault();
                    
                    if (type == null)
                    {
                        context.EquipmentTypeSet.Add(new EquipmentType
                        {
                            name = NameBox.Text,
                            description = DescriptionBox.Text,
                            SystemType = sysType,
                            Manufacturer = manf
                        });
                    }
                    else
                    {
                        int key = type.id;
                        EquipmentType freshEqType = context.EquipmentTypeSet.Where(b => b.id == key).SingleOrDefault();
                        if (freshEqType.name != NameBox.Text) freshEqType.name = NameBox.Text;
                        if (freshEqType.description != DescriptionBox.Text) freshEqType.description = DescriptionBox.Text;
                        if (freshEqType.SystemType != sysType) freshEqType.SystemType = sysType;
                        if (freshEqType.Manufacturer != manf) freshEqType.Manufacturer = manf; 
                    }

                    context.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            type = null;
            sysTypeId.Clear();
            manufactId.Clear();

            Close();
        }

        private void CheckFields()
        {
            if ((DescriptionBox.Text == "") || (DescriptionBox.Text == "Введите описание типа оборудования"))
                throw new Exception("Введите коректное описание типа оборудования");
            if ((NameBox.Text == "") || (NameBox.Text == "Введите наименование типа"))
                throw new Exception("Введите коректное наименование типа");
            if ((SysTypeBox.SelectedIndex == -1) || (ManufactBox.SelectedIndex == -1))
                throw new Exception("Выберите производителя и тип системы");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
