using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kip
{
    class Shedules
    {
        public static void OpenDocs(List<String> items)
        {
            //SortedList(items);

        }
/*
        private static void SortedList(List<Items> items)
        {
            List<string> typeList = new List<string>();
            foreach (var item in items)
                typeList.Add(item.Block.Type);
            var uniqTypeList = typeList.Distinct().ToList();

            List<List<string>> numbers = new List<List<string>>();

            foreach (var type in uniqTypeList)
            {
                List<string> vs = new List<string>();
                foreach (var item in items)
                    if (item.Block.Type == type) vs.Add(item.Block.Number);
                numbers.Add(vs);
            }
            int i = 0;
            foreach (var list in numbers)
            {
                FindDoc(uniqTypeList[i], list);
                Console.WriteLine(uniqTypeList[i++]);
                foreach (var number in list)
                    Console.WriteLine(number);
            }
        }

        private static void FindDoc(string v, List<string> vs)
        {
            string sysType = null;
            using (kipEntities context = new kipEntities())
            {
                var type = context.EquipmentTypeSet.Where(x => x.name == v).SingleOrDefault();
                if (type != null)
                    sysType = type.SystemType.name;
                else throw new Exception("В базе не найден тип оборудования, совпадающий с переданным от мобильного устройства");
            };

            string[] dirs = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\defectiveList\", sysType + "*");
            string NameExcel = dirs.Last();
            Application ObjExcel = new Application();
            ObjExcel.Visible = true;
            ObjExcel.WindowState = XlWindowState.xlMaximized;
            //Открываем книгу.                                                                                                                                                        
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(NameExcel, 0, true, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            //Выбираем таблицу(лист).
            Worksheet ObjWorkSheet;

            foreach (Worksheet sheet in ObjWorkBook.Sheets)
                if (sheet.Name == v)
                {
                    ObjWorkSheet = sheet;
                    ObjWorkSheet.Activate();
                    Range range = ObjWorkSheet.get_Range("B7", "D7");

                    string value = null;
                    foreach (var str in vs)
                        value += v + " №" + str + "\n";
                    value = value.TrimEnd('\n');
                    range.RowHeight = 17 * vs.Count;
                    range.Value = value;

                    range = ObjWorkSheet.get_Range("F7", "G7");
                    range.Value = DateTime.Today.ToString("dd.MM.yy");

                    Range currentFind = null;
                    Range Fruits = ObjWorkSheet.get_Range("A1", "G50");
                    // You should specify all these parameters every time you call this method,
                    // since they can be overridden in the user interface. 

                    currentFind = Fruits.Find("Количество", Type.Missing,
                        XlFindLookIn.xlValues, XlLookAt.xlPart,
                        XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false,
                        Type.Missing, Type.Missing);

                    string address = currentFind.Address;
                    address = address.Replace('B', 'C');
                    range = ObjWorkSheet.get_Range(address);
                    range.Value = vs.Count;

                    currentFind = Fruits.Find("Исполнитель", Type.Missing,
                        XlFindLookIn.xlValues, XlLookAt.xlPart,
                        XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false,
                        Type.Missing, Type.Missing);

                    address = currentFind.Address;
                    address = address.Replace('A', 'C');
                    range = ObjWorkSheet.get_Range(address);
                    range.Value = MainForm.worker.Family + " " + MainForm.worker.Name.Substring(0, 1) + "." + MainForm.worker.Patronymic.Substring(0, 1) + ".";
                }
        }*/
    }
}
