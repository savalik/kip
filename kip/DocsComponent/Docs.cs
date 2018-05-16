using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KipLib;

namespace kip
{
    public class Docs
    {
        public static void OpenDocs(List<Items> items)
        {
            List<string> typeList = new List<string>();
            foreach (var item in items)
                typeList.Add(item.Block.Type);
            var uniqTypeList = typeList.Distinct().ToList();

            List<List<string>> numbers = new List<List<string>>();

            foreach(var type in uniqTypeList)
            {
                List<string> vs = new List<string>();
                foreach (var item in items)
                    if (item.Block.Type == type) vs.Add(item.Block.Number);
                numbers.Add(vs);
            }
            int i = 0;
            foreach(var list in numbers)
            {
                Console.WriteLine(uniqTypeList[i++]);
                foreach(var number in list)
                    Console.WriteLine(number);
            }
        }
    }
}
