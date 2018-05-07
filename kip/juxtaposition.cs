using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace kip
{
    public static class Juxtaposition
    {
        static DataGridView gridView = null;
        static ListBox listBox = null;

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

        internal static void ShowForm(ListBox list)
        {
            Form form;
            var str = list.SelectedItem.ToString();
            switch (str)
            {
                case "Оборудование":
                    //Equipment.FillGrid(view);
                    break;
                case "Типы оборудования":
                    //EquipmentType.FillGrid(view);
                    break;
                case "Производители":
                    form = new ManufacturerForm();
                    form.ShowDialog();
                    break;
                case "Типы систем":
                    form = new SystemTypeForm();
                    form.ShowDialog();
                    break;
                case "Роли МВПС":
                    form = new MVPSRoleForm();
                    form.ShowDialog();
                    break;
                case "Типы МВПС":
                    form = new MVPSTypeForm();
                    form.ShowDialog();
                    break;
                case "МВПС":
                    //MVPS.FillGrid(view);
                    break;
                case "Правила компелктования":
                    form = new EquipmentRuleForm();
                    form.ShowDialog();
                    break;
                default:
                    break;
            }
            FillGrid(listBox, gridView);
        }

        internal static void ShowEditForm(ListBox list, DataGridView view)
        {
            try
            {
                Form form;
                var str = list.SelectedItem.ToString();
                switch (str)
                {
                    case "Оборудование":
                        //Equipment.FillGrid(view);
                        break;
                    case "Типы оборудования":
                        //EquipmentType.FillGrid(view);
                        break;
                    case "Производители":
                        form = new ManufacturerForm(view);
                        form.ShowDialog();
                        break;
                    case "Типы систем":
                        form = new SystemTypeForm(view);
                        form.ShowDialog();
                        break;
                    case "Роли МВПС":
                        form = new MVPSRoleForm(view);
                        form.ShowDialog();
                        break;
                    case "Типы МВПС":
                        form = new MVPSTypeForm(view);
                        form.ShowDialog();
                        break;
                    case "МВПС":
                        //MVPS.FillGrid(view);
                        break;
                    case "Правила компелктования":
                        form = new EquipmentRuleForm(view);
                        form.ShowDialog();
                        break;
                    default:
                        break;
                }
                FillGrid(listBox, gridView);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void FillTableList(ListBox list)
        {
            if (list.Items.Count == 0)
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
        }

        public static void FillGrid(ListBox list, DataGridView view)
        {
            var str = list.SelectedItem.ToString();
            gridView = view;
            listBox = list;

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
