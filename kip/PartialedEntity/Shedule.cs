using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class Shedule
    {
        public DataGridViewRow GetRow()
        {
            var row = new DataGridViewRow();

            row.Cells.Add(new DataGridViewTextBoxCell { Value = Id });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = date.ToString("dd.MM.yy") });

            string strTO3 = "", strTR1 = "";
            foreach (MVPS mvps in MVPS_Maintenance)
                strTO3 += mvps.GetSeries() + ",";
            foreach (MVPS mvps in MVPS_Repair)
                strTR1 += mvps.GetSeries() + ",";
            strTO3 = strTO3.TrimEnd(',');
            strTR1 = strTR1.TrimEnd(',');

            row.Cells.Add(new DataGridViewTextBoxCell { Value = strTR1 });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = strTO3 });
       
            return row;
        }

        public static void GetColumns(DataGridView view)
        {
            try
            {
                view.Columns.Clear();
                view.Columns.Add("id", "ID");
                view.Columns.Add("date", "Дата");
                view.Columns.Add("repairs", "МПВС на ТР1");
                view.Columns.Add("maintenance", "МВПС на ТО3");

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
                var k = context.SheduleSet.ToList();

                GetColumns(view);
                view.Rows.Clear();

                foreach (Shedule z in k)
                {
                    view.Rows.Add(z.GetRow());
                }

                view.Sort(view.Columns["date"], ListSortDirection.Descending);
            }
        }

        public bool ContainSeries(string series)
        {
            foreach(MVPS m in MVPS_Maintenance)
                if (m.series == series)
                    return true;
            foreach (MVPS m in MVPS_Repair)
                if (m.series == series)
                    return true;
            return false;
        }
    }
}
