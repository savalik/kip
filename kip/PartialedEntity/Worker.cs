using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class Worker
    {
        public DataGridViewRow GetRow()
        {
            var row = new DataGridViewRow();

            row.Cells.Add(new DataGridViewTextBoxCell { Value = Id });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = Family });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = Name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = Patronymic });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = PersonnelNumber });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = Position.name });

            return row;
        }

        public static void GetColumns(DataGridView view)
        {
            try
            {
                view.Columns.Clear();
                view.Columns.Add("id", "ID");
                view.Columns.Add("Family", "Фамилия");
                view.Columns.Add("Name", "Имя");
                view.Columns.Add("Patronymic", "Отчество");
                view.Columns.Add("PersonnelNumber", "Табельный номер");
                view.Columns.Add("Position", "Должность");
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
                var k = context.WorkerSet.ToList();

                GetColumns(view);
                view.Rows.Clear();
                
                foreach (Worker z in k)
                {
                    view.Rows.Add(z.GetRow());
                }
            }
        }

        public string GetFIO()
        {
            return Family + " " + Name.Substring(0, 1) + " " + Patronymic.Substring(0, 1);
        }
    }
}
