using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class MVPSType
    {
        public DataGridViewRow GetRow()
        {
            var row = new DataGridViewRow();

            row.Cells.Add(new DataGridViewTextBoxCell { Value = Id });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = name });

            return row;
        }

        public static void GetColumns(DataGridView view)
        {
            try
            {
                view.Columns.Clear();
                view.Columns.Add("id", "ID");
                view.Columns.Add("name", "Название");
                view.Columns[0].Visible = false;

                view.Sort(view.Columns["name"], ListSortDirection.Ascending);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void FillGrid(DataGridView view)
        {
            using (kipEntities context = new kipEntities())
            {
                var k = context.MVPSTypeSet.ToList();

                GetColumns(view);
                view.Rows.Clear();

                foreach (MVPSType z in k)
                {
                    view.Rows.Add(z.GetRow());
                }
            }
        }
    }
}
