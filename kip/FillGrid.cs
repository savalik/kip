using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public class FillGrid
    {
        public enum TablesEnum {Manufacturers, Equipment, EquipmentTypes };

        public static void Fill(DataGridView TableDataView, TablesEnum @enum)
        {
            if (TableDataView == null)
            {
                throw new ArgumentNullException(nameof(TableDataView));
            }

            try
            {
                using (kipEntities context = new kipEntities())
                {
                    DataForTable data;
                    switch (@enum)
                    {
                        case TablesEnum.Equipment:
                            data = new DataForTable<Equipment>(context);
                            break;
                        case TablesEnum.EquipmentTypes:
                            data = new DataForTable<EquipmentTypes>(context);
                            break;
                        case TablesEnum.Manufacturers:
                            data = new DataForTable<Manufacturers>(context);
                            break;
                        default:
                            data = null;
                            break;
                    }

                    if (data != null)
                    {
                        TableDataView.DataSource = data.Source;
                        TableDataView.Columns[data.Column].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
