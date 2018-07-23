using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KipLib;

namespace kip
{
    public class Repair
    {
        public static void DoRepairOrCheck(Worker worker, List<string> descriptions, bool isRepair_)
        {
            int i = 0;
            foreach (var item in Items.GetItems)
            {
                using (kipEntities context = new kipEntities())
                {
                    Guid guid = Guid.Parse(item.Block.Id);
                    var eq = context.EquipmentSet.Where(b => b.Id == guid).SingleOrDefault();
                    var performer = context.WorkerSet.Where(b => b.Id == worker.Id).SingleOrDefault();
                    if (eq == null) throw new Exception("Не найден блок с идентификатором " + guid.ToString());
                    else
                    {
                        eq.isWorking = true;
                        eq.serviceDate = DateTime.Today.Date;
                        var service = new ServiceLog
                        {
                            date = DateTime.Now,
                            description = descriptions[i++],
                            Equipment = eq,
                            isRepair = isRepair_,
                            Performer = performer
                        };
                        context.ServiceLogSet.Add(service);
                        eq.ServiceLog.Add(service);
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
