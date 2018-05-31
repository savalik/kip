using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class MastersForm : Form
    {
        static List<MVPS> ms = new List<MVPS>();

        public static Worker worker;
        static Form LoginForm;

        public MastersForm(Worker loggedWorker, Form Form)
        {
            InitializeComponent();
            worker = loggedWorker;
            LoginForm = Form;
            FillForm();
            FillList();
        }

        private void MastersForm_Load(object sender, EventArgs e)
        {
            
        }

        private void FillList()
        {
            using (kipEntities context = new kipEntities())
            {
                DateTime date = dateTimePicker1.Value.Date;

                var shed = context.SheduleSet.Where(b => b.date == date).SingleOrDefault();
                DayMVPSList.Items.Clear();
                ms.Clear();

                if (shed != null)
                {
                    foreach (var to3 in shed.MVPS_Maintenance)
                    {
                        AddToDayMVPSList(to3,true);

                        if (checkUnStaffed(to3, context))
                            DayMVPSList.Items[DayMVPSList.Items.Count - 1].ForeColor = Color.ForestGreen;
                        else
                            DayMVPSList.Items[DayMVPSList.Items.Count - 1].ForeColor = Color.PaleVioletRed;
                    }
                    foreach (var tr1 in shed.MVPS_Repair)
                    {
                        AddToDayMVPSList(tr1, false);
                        if (checkUnStaffed(tr1, context))
                            DayMVPSList.Items[DayMVPSList.Items.Count - 1].ForeColor = Color.ForestGreen;
                        else
                            DayMVPSList.Items[DayMVPSList.Items.Count - 1].ForeColor = Color.PaleVioletRed;
                    }
                }
                else DayMVPSList.Items.Add("Рассписания пока нет");
            }
        }

        private bool checkUnStaffed(MVPS mvp, kipEntities context)
        {
            var mvps = context.MVPSSet.Where(b => b.series == mvp.series);
            foreach (var m in mvps)
                if (!m.IsStaffed()) return false;
            return true;
        }

        private void AddToDayMVPSList(MVPS mvps, bool isTO3)
        {
            if (isTO3)
            {
                ms.Add(mvps);
                DayMVPSList.Items.Add("ТО3 " + mvps.GetSeries());
            }
            else
            {
                ms.Add(mvps);
                DayMVPSList.Items.Add("ТР1 " + mvps.GetSeries());
            }
        }

        private void FillForm()
        {
            UserLabel.Text = worker.Family + " " + worker.Name + " " + worker.Patronymic;
            PersonnelNumberlLabel.Text = worker.PersonnelNumber.ToString();
            PositionLabel.Text = worker.Position.name;
            PersonnelNumberlLabel.Location = new Point(UserLabel.Location.X + UserLabel.Width + 20, PersonnelNumberlLabel.Location.Y);
            PositionLabel.Location = new Point(UserLabel.Location.X + UserLabel.Width + 20, PositionLabel.Location.Y);

            using (kipEntities context = new kipEntities())
            {
                ServiceableEquipmentCount.Text = context.EquipmentSet.Where(b => b.isFree && b.isWorking).Count().ToString();
                InstalledEquipmentCount.Text = context.EquipmentSet.Where(b => !b.isFree && b.isWorking).Count().ToString();
                FaultyEquipment.Text = context.EquipmentSet.Where(b => !b.isWorking).Count().ToString();
            }
        }

        private void ShowSheduleButton_Click(object sender, EventArgs e)
        {
            List<EquipmentType> types = new List<EquipmentType>();
            List<EquipmentRule> rules = new List<EquipmentRule>();
            List<MVPS> mVPS = new List<MVPS>();
            List<String> sheds = new List<String>();

            var strings = SheduleListBox.SelectedItem.ToString().Split(' ');

            using (kipEntities context = new kipEntities())
            {
                foreach (var str in strings)
                {
                    var type = context.EquipmentTypeSet.Where(b => b.name == str).SingleOrDefault();
                    if (type != null)
                        types.Add(type);
                }
                foreach(var type in types)
                {
                    var rule = type.EquipmentRule;
                    foreach (var r in rule)
                        if (!rules.Contains(r)) rules.Add(r);
                }
                foreach(var rule in rules)
                {
                    var mvps_ = context.MVPSSet.Where(b => b.EquipmentRule.Id == rule.Id).ToList();
                    mVPS.AddRange(mvps_);
                }
                foreach(var mvp in mVPS)
                    foreach(var eq in mvp.Equipment)
                    {
                        if (types.Contains(eq.EquipmentType))
                        {
                            DateTime date = eq.serviceDate.Date.AddDays((double)eq.EquipmentType.servicePeriod);
                            DateTime end_date;
                            if (dateTimePicker1.Value.Month != 12)
                                end_date = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month + 1, 10);
                            else
                                end_date = new DateTime(dateTimePicker1.Value.Year + 1, 1, 10);

                            if (date < end_date)
                            {
                                var ser = mvp.series;
                                DateTime fromDate = end_date.AddDays(-40);
                                var shedules = context.SheduleSet.Where(b => b.date < end_date && b.date > fromDate ).OrderByDescending(b => b.date);
                                foreach (var shedule in shedules)
                                    if (shedule.ContainSeries(ser))
                                    {
                                        sheds.Add(mvp.MVPSType.name + "," + mvp.series + "," + mvp.number +
                                       "," + eq.EquipmentType.name + "," + eq.number + "," + shedule.date.ToString("dd.MM.yy") + "," + eq.serviceDate.ToString("dd.MM.yy"));
                                        Console.WriteLine(ser + " at " + shedule.date.ToString("dd.MM.yy"), eq.serviceDate.ToString("dd.MM.yy"));
                                        break;
                                    }
                            }
                        }
                    }
                
            }

            foreach (string s in sheds)
               Console.WriteLine(s);
        }

        private void DayMVPSList_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            using (kipEntities context = new kipEntities())
            {
                if (DayMVPSList.SelectedItems.Count > 0)
                {
                    var mvp = ms[DayMVPSList.SelectedItems[0].Index];

                    var mvps = context.MVPSSet.Where(b => b.series == mvp.series);
                    foreach (var m in mvps)
                        foreach (var unstaffed in m.UnStaffed())
                            listView1.Items.Add(m.MVPSType.name + " " + m.series + " " + m.number + " " + unstaffed.name);
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
