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
        private DbSet dbSet = null;

        public TableForm()
        {
            InitializeComponent();
        }

        public TableForm(DbSet dbSet)
        {
            this.dbSet = dbSet;
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            if (dbSet != null)
            {
                FillGrid();
            }
        }

        private void FillGrid()
        { 
            BindingList<Manufacturers> bindingList;
            BindingSource pSource = new BindingSource();

            
            var _context = new kipEntities();
            var p = _context.Manufacturers.ToList();
            bindingList = new BindingList<Manufacturers>(p); //getting bindinglist
            bindingList.AllowEdit = true;
            bindingList.AllowNew = true;

            pSource.DataSource = bindingList;
            pSource.AllowNew = true;

            TableDataView.DataSource = pSource;
        }
    }
}
