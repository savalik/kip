using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class Equipment
    {
        public DataGridViewRow GetRow()
        {
            var row = new DataGridViewRow();
            string shortString = null;
            if (termDate.HasValue) shortString = termDate.Value.ToShortDateString();

            row.Cells.Add(new DataGridViewTextBoxCell { Value = id });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = EquipmentType.name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = number });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = repairDate.ToShortDateString() });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = serviceDate.ToShortDateString() });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = nextVerificationDate.ToShortDateString() });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = shortString});
            row.Cells.Add(new DataGridViewTextBoxCell { Value = isWorking});
            row.Cells.Add(new DataGridViewTextBoxCell { Value = isFree });

            return row;
        }

        public static void GetColumns(DataGridView view)
        {
            try
            {
                view.Columns.Clear();
                view.Columns.Add("id", "ID");
                view.Columns.Add("type", "Тип");
                view.Columns.Add("number", "Номер");
                view.Columns.Add("repairDate", "Дата ремонта");
                view.Columns.Add("serviceDate", "Дата обслуживания");
                view.Columns.Add("nextVerificationDate", "Дата след. поверки");
                view.Columns.Add("termDate", "Эксплуатировать до");
                view.Columns.Add("isWorking", "Исправен");
                view.Columns.Add("isFree", "Свободнен");

                view.Columns[0].Visible = false;
                view.Columns[6].Visible = false;
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
                var k = context.EquipmentSet.ToList();

                GetColumns(view);
                view.Rows.Clear();

                foreach (Equipment z in k)
                {
                    view.Rows.Add(z.GetRow());
                }
            }
        }
    }
}
