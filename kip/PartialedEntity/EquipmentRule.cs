using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class EquipmentRule
    {
        public DataGridViewRow GetRow()
        {
            var row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell { Value = Id });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = MVPSRole.name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = MVPSType.name });

            //набираем связанные с правилом типы блоков в строку для таблицы
            string str = null;
            foreach(EquipmentType s in EquipmentType)
            {
                str += s.name + ",";
            }
            str= str.Remove(str.Length - 1);

            row.Cells.Add(new DataGridViewTextBoxCell { Value = str });

            return row;
        }

        public static void GetColumns(DataGridView view)
        {
            try
            {
                view.Columns.Clear();
                view.Columns.Add("id", "ID");
                view.Columns.Add("MVPSRole", "Роль вагона");
                view.Columns.Add("MVPSType", "Тип вагона");
                view.Columns.Add("EquipmentTypeSet", "Набор оборудования");
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
                var k = context.EquipmentRuleSet.ToList();

                GetColumns(view);
                view.Rows.Clear();
                view.RowTemplate.Height = 40;
                //ToDo: и тут
                foreach (EquipmentRule z in k)
                {
                    view.Rows.Add(z.GetRow());
                }
            }
            
        }
    }
}
