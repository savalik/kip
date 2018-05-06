using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace kip
{
    public static class Juxtaposition
    {
        public static string TableName(object table)
        {
            var str = table.ToString();
            switch (str)
            {
                case "Equipment":
                    return "Оборудование";
                case "EquipmentType":
                    return "Типы оборудования";
                case "Manufacturer":
                    return "Производители";
                case "SystemType":
                    return "Типы систем";
                case "MVPSRole":
                    return "Роли МВПС";
                case "MVPSType":
                    return "Типы МВПС";
                case "MVPS":
                    return "МВПС";
                case "EquipmentRule":
                    return "Правила компелктования";
                default:
                    return "";
            }

        }

        public static void FillTableList(ListBox list)
        {
            using (kipEntities context = new kipEntities())
            {

                var objectContext = ((IObjectContextAdapter)context).ObjectContext;

                var mdw = objectContext.MetadataWorkspace;

                var items = mdw.GetItems<EntityType>(DataSpace.CSpace);
                foreach (var i in items)
                {
                    list.Items.Add(TableName(i.Name));
                }
            }
        }

        public static void FillGrid(ListBox list, DataGridView view)
        {
            var str = list.SelectedItem.ToString();
            switch (str)
            {
                case "Оборудование":
                    Equipment.FillGrid(view);
                    break ;
                case "Типы оборудования":
                    EquipmentType.FillGrid(view);
                    break;
                case "Производители":
                    Manufacturer.FillGrid(view);
                    break;
                case "Типы систем":
                    SystemType.FillGrid(view);
                    break;
                case "Роли МВПС":
                    MVPSRole.FillGrid(view);
                    break;
                case "Типы МВПС":
                    MVPSType.FillGrid(view);
                    break;
                case "МВПС":
                    MVPS.FillGrid(view);
                    break;
                case "Правила компелктования":
                    EquipmentRule.FillGrid(view);
                    break;
                default:
                    break;
            }
        }
    }
}
