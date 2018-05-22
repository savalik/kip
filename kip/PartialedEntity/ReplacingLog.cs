using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class ReplacingLog
    {
        public DataGridViewRow GetRow()
        {
            var row = new DataGridViewRow();

            using (kipEntities context = new kipEntities()) {
                string remStr = null;
                string insStr = null;
                string mvpsStr = null;
                string workerStr = null;
                //тут что то не так.
                Equipment rem = context.EquipmentSet.Where(b => b.Id == Removed.Id).SingleOrDefault();
                Equipment ins = context.EquipmentSet.Where(b => b.Id == Installed.Id).SingleOrDefault();
                if (rem != null) remStr = rem.EquipmentType.name + " № " + rem.number;
                if (ins != null) insStr = ins.EquipmentType.name + " № " + ins.number;

                mvpsStr = MVPS.MVPSType.name + " " + MVPS.series + " " + MVPS.number;
                workerStr = Worker.GetFIO();

                row.Cells.Add(new DataGridViewTextBoxCell { Value = Id });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = date.ToString("dd.MM.yy") });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = remStr });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = insStr });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = description });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = mvpsStr });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = workerStr });

            }
            return row;
        }

        public static void GetColumns(DataGridView view)
        {
            try
            {
                view.Columns.Clear();
                view.Columns.Add("id", "ID");
                view.Columns.Add("date", "Дата");
                view.Columns.Add("removed", "Снятый блок");
                view.Columns.Add("installed", "Установленный блок");
                view.Columns.Add("description", "Причина");
                view.Columns.Add("mvps", "Вагон");
                view.Columns.Add("worker", "Работник");

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
                var k = context.ReplacingLogSet.ToList();

                GetColumns(view);
                view.Rows.Clear();

                foreach (ReplacingLog z in k)
                {
                    view.Rows.Add(z.GetRow());
                }

                view.Sort(view.Columns["date"], ListSortDirection.Descending);
            }
        }
    }
}
