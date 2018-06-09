using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class DBform : Form
    {
        public DBform()
        {
            InitializeComponent();
        }

        private void DBform_Load(object sender, EventArgs e)
        {
            Juxtaposition.FillTableList(TableListBox);
        }

        private void TableListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Juxtaposition.FillGrid(TableListBox, dataGridView1);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Juxtaposition.ShowForm(TableListBox);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Juxtaposition.ShowEditForm(TableListBox,dataGridView1);
            Juxtaposition.FillTableList(TableListBox);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция пока не реализована. Извините.");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void DBform_Resize(object sender, EventArgs e)
        {
            int v = this.Width - 234;
            int x = 18 + v;
            int y = Height - 86;
            dataGridView1.Width = v;
            dataGridView1.Height = Height - 68;

            TableListBox.Location = new Point(x, TableListBox.Location.Y);
            AddButton.Location = new Point(x, y - 111);
            RemoveButton.Location = new Point(x, y -37);
            CloseButton.Location = new Point(x, y);
            EditButton.Location = new Point(x, y-74);
        }

        private void DataGridView1_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            EditButton_Click(sender, e);
        }
    }
}
