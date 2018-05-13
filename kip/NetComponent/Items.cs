using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kip.Kek
{
    [Serializable]
    public class Items
    {
        public static List<Items> GetItems = new List<Items>();

        readonly string type;
        readonly string number;
        readonly string id;

        public bool RepairOrCheck { get; set; }

        private Items(string type, string number, string id)
        {
            this.type = type;
            this.number = number;
            this.id = id;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="number"></param>
        /// <param name="id"></param>
        /// <param name="RepairOrCheck">0 if repair - 1 if check</param>
        public static void CreateItem(string type, string number, string id, bool RepairOrCheck)
        {
            Items item = new Items(type, number, id);
            GetItems.Add(item);
        }

        public static string[] GetList()
        {
            List<string> items = new List<string>();
            foreach (var item in GetItems)
            {
                items.Add(item.type + " №" + item.number);
            }
            return items.ToArray();
        }

        public string GetText()
        {
            return type + " №" + number;
        }
    }
}
