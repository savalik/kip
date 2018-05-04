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
                            data = new DataForTable<EquipmentType>(context);
                            break;
                        case TablesEnum.Manufacturers:
                            data = new DataForTable<Manufacturer>(context);
                            break;
                        default:
                            data = null;
                            break;
                    }

                    if (data != null)
                    {
                        TableDataView.DataSource = data.Source;

                        String[] columns = data.Column.Split(',');
                        
                        foreach (DataGridViewColumn k in TableDataView.Columns)
                        {
                            foreach (string column in columns)
                                if (k.DataPropertyName == column)k.Visible = false;
                        }
                        
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
