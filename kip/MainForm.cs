using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ManufacturerButton_Click(object sender, EventArgs e)
        {
            using (var db = new kipEntities())
            {
                DbSet<Manufacturers> dbSet = db.Manufacturers;
                TableForm tableForm = new TableForm(dbSet);
                tableForm.ShowDialog();
            }
        }
    }
}
