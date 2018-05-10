using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class Manufacturer
    {
        public DataGridViewRow GetRow()
        {
            var row = new DataGridViewRow();

            row.Cells.Add(new DataGridViewTextBoxCell { Value = Id });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = address });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = phone });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = email });

            return row;
        }

        public static void GetColumns(DataGridView view)
        {
            try
            {
                view.Columns.Clear();
                view.Columns.Add("id", "ID");
                view.Columns.Add("name", "Название");
                view.Columns.Add("address", "Адрес");
                view.Columns.Add("phone", "Телефон");
                view.Columns.Add("email", "E-mail");
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
                var k = context.ManufacturerSet.ToList();

                GetColumns(view);
                view.Rows.Clear();

                //ToDo: и тут
                foreach (Manufacturer z in k)
                {
                    view.Rows.Add(z.GetRow());
                }
            }
        }
    }
}
