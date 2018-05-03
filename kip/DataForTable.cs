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
        private string column;
        private BindingSource source;

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
                case "kip.Manufacturers":
                    return _context.Manufacturers.ToList();
                case "kip.EquipmentTypes":
                    return _context.EquipmentTypes.ToList();
                case "kip.Equipment":
                    return _context.Equipment.ToList();
                default:
                    return null;
            }
        }

        private string HidesColumn(string table)
        {
            switch (table)
            {
                case "kip.Manufacturers":
                    return "Equipments";
                case "kip.EquipmentTypes":
                    return "Equipments";
            }
            return null;
        }
    }
}
