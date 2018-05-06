using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class MVPS
    {
        public DataGridViewRow GetRow()
        {
            var row = new DataGridViewRow();

            row.Cells.Add(new DataGridViewTextBoxCell { Value = Id });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = MVPSType.name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = series });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = number });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = MVPSRole.name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = EquipmentRule.Id });

            return row;
        }

        public static void GetColumns(DataGridView view)
        {
            try
            {
                view.Columns.Clear();
                view.Columns.Add("id", "ID");
                view.Columns.Add("MVPSTypeName", "Тип");
                view.Columns.Add("series", "Серия");
                view.Columns.Add("number", "Номер");
                view.Columns.Add("MVPSRoleName", "Назначение");
                view.Columns.Add("EquipmentRuleId", "Правило компелктации");

                view.Columns[0].Visible = false;
                view.Columns[5].Visible = false;
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
                var k = context.MVPSSet.ToList();

                GetColumns(view);
                view.Rows.Clear();

                //ToDo: и тут
                foreach (MVPS z in k)
                {
                    view.Rows.Add(z.GetRow());
                }
            }
        }
    }
}
