using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kip
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Windows.Forms;

    public partial class EquipmentType
    {
        public DataGridViewRow GetRow()
        {
            var row = new DataGridViewRow();
           
            row.Cells.Add(new DataGridViewTextBoxCell { Value = Id   });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = description });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = SystemType.name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = GetMonthOrYear(servicePeriod) });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = GetMonthOrYear(verfPeriod) });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = Manufacturer.name });
            return row;
        }

        public string GetMonthOrYear(int? Period)
        {
            string str= null;
            int y;
            if (Period.HasValue)
            {
                int x = Period.GetValueOrDefault();
                if (x % 365 == 0)
                {
                    y = x / 365;
                    switch (y % 10)
                    {
                        case 1:
                            str = y.ToString() + " год";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            str = y.ToString() + " года";
                            break;
                        default:
                            str = y.ToString() + " лет";
                            break;
                    }
                }
                else
                    if(x % 30 == 0)
                    {
                        y = x / 30;
                        switch (y % 10)
                        {
                            case 1:
                                str = y.ToString() + " месяц";
                                break;
                            case 2:
                            case 3:
                            case 4:
                                str = y.ToString() + " месяца";
                                break;
                            default:
                                str = y.ToString() + " месяцев";
                                break;
                        }
                    }
            }
            return str;
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
                view.Columns.Add("servicePeriod", "Период проверки");
                view.Columns.Add("verificationPeriod", "Период поверки");
                view.Columns.Add("manufacturer", "Производитель");

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
                //ToDo: не забыть изменить тип при копировании тут
                var k = context.EquipmentTypeSet.ToList();

                GetColumns(view);
                view.Rows.Clear();

                //ToDo: и тут
                foreach (EquipmentType z in k)
                {
                    view.Rows.Add(z.GetRow());
                }

                view.Sort(view.Columns["systemType"], ListSortDirection.Ascending);
            }
        }
    }
}