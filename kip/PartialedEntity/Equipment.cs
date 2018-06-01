using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
            string shortStringTerm = null;
            string shortStringVerf = null;
            if (termDate.HasValue) shortStringTerm = termDate.Value.ToShortDateString();
            if (nextVerificationDate.HasValue) shortStringVerf = nextVerificationDate.Value.ToShortDateString();

            row.Cells.Add(new DataGridViewTextBoxCell { Value = Id });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = EquipmentType.name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = number });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = repairDate.ToShortDateString() });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = serviceDate.ToShortDateString() });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = shortStringVerf});
            row.Cells.Add(new DataGridViewTextBoxCell { Value = shortStringTerm});
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

                view.Sort(view.Columns["type"], ListSortDirection.Ascending);
            }
        }

        public float GetRemainingLife()
        {
            float x = (this.serviceDate - DateTime.Today).Days;
            float y = this.EquipmentType.servicePeriod;
            float j = x / y;
            float rem = x/y + 1;
            return rem;
        }

        public Color GetColor()
        {
            float rm = GetRemainingLife();
            int red, green, blue;
            if (rm > 0.95) {        red = 0;    green = 128;    blue = 128; }
            else if (rm > 0.8) {    red = 0;    green = 128;    blue = 0;   }
            else if (rm > 0.6) {    red = 128;  green = 128;    blue = 0;   }
            else if (rm > 0.4) {    red = 134;  green = 64;     blue = 0;   }
            else if (rm > 0.2) {    red = 140;  green = 32;     blue = 0;   }
            else {                  red = 139;  green = 0;      blue = 0;   }
            return Color.FromArgb(red, green, blue);
        }
    }
}
