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
    public partial class TableForm : Form
    {
        FillGrid.TablesEnum @enum;

        public TableForm(FillGrid.TablesEnum @enum)
        {
            this.@enum = @enum;
            InitializeComponent();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {          
            FillGrid.Fill(TableDataView, @enum);
        }
    }
}
