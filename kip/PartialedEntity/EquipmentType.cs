using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kip
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class EquipmentType
    {
        public DataGridViewRow GetRow()
        {
            var row = new DataGridViewRow();

            row.Cells.Add(new DataGridViewTextBoxCell { Value = Id   });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = description });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = Manufacturer.name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = SystemType.name });

            return row;
        }

        public static void GetColumns(DataGridView view)
        {
            try
            {
                view.Columns.Clear();
                view.Columns.Add("id", "ID");
                view.Columns.Add("name", "Наименование");
                view.Columns.Add("description", "Описание");
                view.Columns.Add("systemType", "Тип системы");
                view.Columns.Add("manufacturer", "Производитель");
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
                var k = context.EquipmentTypeSet.ToList();

                GetColumns(view);
                view.Rows.Clear();

                //ToDo: и тут
                foreach (EquipmentType z in k)
                {
                    view.Rows.Add(z.GetRow());
                }
            }
        }
    }
}