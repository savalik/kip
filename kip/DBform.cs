﻿using System;
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
            //this.WindowState = FormWindowState.Maximized;
        }

        private void TableListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Juxtaposition.FillGrid(TableListBox, dataGridView1);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
