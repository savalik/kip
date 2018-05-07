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
    public partial class MVPSRoleForm : Form
    {
        static MVPSRole role = null;

        public MVPSRoleForm()
        {
            InitializeComponent();
            FillForm();
        }

        public MVPSRoleForm(DataGridView view)
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
                role = context.MVPSRoleSet.Where(b => b.Id == id).SingleOrDefault();
                MVPSRoleBox.Text = role.name;
            }
            AddButton.Text = "Сохранить";
        }

        private void FillForm()
        {
            MVPSRoleBox.Text = "Введите название роли МВПС";
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
                    if (role != null)
                    {
                        int key = role.Id;
                        MVPSRole freshRole = context.MVPSRoleSet.Where(b => b.Id == key).SingleOrDefault();
                        string str = MVPSRoleBox.Text;
                        if ((freshRole.name != str) && (str != ""))
                        {
                            freshRole.name = str;
                            context.SaveChanges();
                        }
                    }
                    else
                    {
                        string str = MVPSRoleBox.Text;
                        if (str != "")
                        {
                            MVPSRole freshRole = new MVPSRole
                            {
                                name = str
                            };
                            context.MVPSRoleSet.Add(freshRole);
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

        

  