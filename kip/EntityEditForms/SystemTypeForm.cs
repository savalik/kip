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
    public partial class SystemTypeForm : Form
    {
        static SystemType type = null;

        public SystemTypeForm()
        {
            InitializeComponent();
            FillForm();
        }

        public SystemTypeForm(DataGridView view)
        {
            InitializeComponent();
            var id = view.CurrentRow.Cells[0].Value;
            FillForm();
            FillEntity((int)id);
        }

        private void SystemTypeForm_Load(object sender, EventArgs e)
        {

        }

        private void FillEntity(int id)
        {
            using (kipEntities context = new kipEntities())
            {
                type = context.SystemTypeSet.Where(b => b.Id == id).SingleOrDefault();
                SystemTypeNameBox.Text = type.name;
                SystemTypeDescriptionBox.Text = type.description;
            }
            AddButton.Text = "Сохранить";
        }

        private void FillForm()
        {
            SystemTypeNameBox.Text = "Введите название системы";
            SystemTypeDescriptionBox.Text = "Введите описание системы";
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
                    if (SystemTypeNameBox.Text == "Введите название системы") throw new Exception("Введите коректное название системы");
                    if (SystemTypeDescriptionBox.Text == "Введите описание системы") throw new Exception("Введите коректное описание системы");
                    if (type != null)
                    {
                        int key = type.Id;
                        SystemType freshSysType = context.SystemTypeSet.Where(b => b.Id == key).SingleOrDefault();
                        string str = SystemTypeNameBox.Text;
                        if (str != "")
                        {
                            if (str != freshSysType.name) freshSysType.name = str;
                            if (SystemTypeDescriptionBox.Text != freshSysType.description) freshSysType.description = SystemTypeDescriptionBox.Text;
                            context.SaveChanges();
                        }
                    }
                    else
                    {
                        string str = SystemTypeNameBox.Text;
                        if (str != "")
                        {
                            SystemType freshSysType = new SystemType
                            {
                                name = str,
                                description = SystemTypeDescriptionBox.Text
                            };
                            context.SystemTypeSet.Add(freshSysType);
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
    }
}
