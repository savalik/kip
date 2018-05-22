using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class ServiceLog
    {
        public DataGridViewRow GetRow()
        {
            var row = new DataGridViewRow();

            row.Cells.Add(new DataGridViewTextBoxCell { Value = Id });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = Equipment.EquipmentType.name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = Equipment.number });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = date.ToString("dd.MM.yy") });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = description });
            if (isRepair)
                row.Cells.Add(new DataGridViewTextBoxCell { Value = "Ремонт" });
            else
                row.Cells.Add(new DataGridViewTextBoxCell { Value = "Проверка" });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = Performer.GetFIO() });

            return row;
        }

        public static void GetColumns(DataGridView view)
        {
            try
            {
                view.Columns.Clear();
                view.Columns.Add("id", "ID");
                view.Columns.Add("equipment_type", "Тип");
                view.Columns.Add("equipment_number", "Номер");
                view.Columns.Add("date", "Дата");
                view.Columns.Add("description", "Описание");
                view.Columns.Add("isRepair", "Проверка/ремонт");
                view.Columns.Add("performer", "Исполнитель");

                view.Columns[0].Visible = false;
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
                var k = context.ServiceLogSet.ToList();

                GetColumns(view);
                view.Rows.Clear();

                foreach (ServiceLog z in k)
                {
                    view.Rows.Add(z.GetRow());
                }

                view.Sort(view.Columns["date"], ListSortDirection.Descending);
            }
        }
    }
}
