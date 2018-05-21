using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class SystemType
    {
        public DataGridViewRow GetRow()
        {
            var row = new DataGridViewRow();

            row.Cells.Add(new DataGridViewTextBoxCell { Value = Id });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = description });

            return row;
        }

        public static void GetColumns(DataGridView view)
        {
            try
            {
                view.Columns.Clear();
                view.Columns.Add("id", "ID");
                view.Columns.Add("name", "Название");
                view.Columns.Add("description", "Описание");

                view.Columns[0].Visible = false;

                view.Sort(view.Columns["name"], ListSortDirection.Descending);

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
                //ToDo: не забыть изменить тип при копировании тут
                var k = context.SystemTypeSet.ToList();

                GetColumns(view);
                view.Rows.Clear();

                //ToDo: и тут
                foreach (SystemType z in k)
                {
                    view.Rows.Add(z.GetRow());
                }
            }
        }
    }
}
