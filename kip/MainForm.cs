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
            TableForm tableForm = new TableForm(FillGrid.TablesEnum.Manufacturers);
            tableForm.ShowDialog();
        }

        private void EquipmentTypesButton_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm(FillGrid.TablesEnum.EquipmentTypes);
            tableForm.ShowDialog();
        }

        private void Equipment_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm(FillGrid.TablesEnum.Equipment);
            tableForm.ShowDialog();
        }
    }
}
