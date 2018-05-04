using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    class DataForTable
    {
        public string Column { get; set; }
        public BindingSource Source { get; set; }
    }

    class DataForTable <T> : DataForTable
    {
        public DataForTable(kipEntities _context)
        {

            Source = new BindingSource();
            var p = (List<T>)getCustomContext(_context);

            BindingList<T> bindingList;
            bindingList = new BindingList<T>(p)
            {
                AllowEdit = true,
                AllowNew = true
            };
            Source.DataSource = bindingList;
            Source.AllowNew = true;
                        
            Column = HidesColumn(typeof(T).ToString());
        }

        private object getCustomContext(kipEntities _context)
        {
            switch (typeof(T).ToString())
            {
                case "kip.Manufacturer":
                    return _context.ManufacturerSet.ToList();
                case "kip.EquipmentType":
                    return _context.EquipmentTypeSet.ToList();
                case "kip.Equipment":
                    return _context.EquipmentSet.ToList();
                default:
                    throw new Exception("Неожиданно, вы пытались открыть несуществующую таблицу " + typeof(T).ToString());
            }
        }

        private string HidesColumn(string table)
        {
            switch (table)
            {
                case "kip.Manufacturer":
                    return "id,EquipmentType";
                case "kip.EquipmentType":
                    return "id,Manufacturer,EquipmentRule,Equipment";
                case "kip.Equipment":
                    return "id";
            }
            return null;
        }
    }
}
