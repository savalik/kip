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
    public partial class MVPSTypeForm : Form
    {
        static MVPSType type = null;

        public MVPSTypeForm()
        {
            InitializeComponent();
            FillForm();
        }

        public MVPSTypeForm(DataGridView view)
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
                type = context.MVPSTypeSet.Where(b => b.Id == id).SingleOrDefault();
                MVPSTypeBox.Text = type.name;
            }
            AddButton.Text = "Сохранить";
        }

        private void FillForm()
        {
            MVPSTypeBox.Text = "Введите название типа МВПС";
        }

        private void MVPSRoleForm_Load(object sender, EventArgs e)
        {

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
                    if (MVPSTypeBox.Text == "Введите название типа МВПС") throw new Exception("Введите коректное название типа МВПС");
                    if (type != null)
                    {
                        int key = type.Id;
                        MVPSType freshType = context.MVPSTypeSet.Where(b => b.Id == key).SingleOrDefault();
                        string str = MVPSTypeBox.Text;
                        if ((freshType.name != str) && (str != ""))
                        {
                            freshType.name = str;
                            context.SaveChanges();
                        }
                    }
                    else
                    {
                        string str = MVPSTypeBox.Text;
                        if (str != "")
                        {
                            MVPSType freshType = new MVPSType
                            {
                                name = str
                            };
                            context.MVPSTypeSet.Add(freshType);
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
