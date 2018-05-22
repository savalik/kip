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
    public partial class SheduleForm : Form
    {
        public SheduleForm()
        {
            InitializeComponent();
            FillForm();
        }

        public SheduleForm(DataGridView view)
        {
            InitializeComponent();
            var id = view.CurrentRow.Cells[0].Value;
            FillForm();
        }

        private void FillForm()
        {
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    var types = context.MVPSTypeSet.ToList();
                    var seriesSet = context.MVPSSet.Select(b => b.series).ToList();
                    List<string> unicalSeries = new List<string>();

                    MVPSTypeBox.Items.Add("Любой");
                    MVPSTypeBox.SelectedIndex = 0;

                    foreach (MVPSType type in types)
                    {
                        MVPSTypeBox.Items.Add(type.name);
                    }

                    foreach (string series in seriesSet)
                    {
                        if (unicalSeries.Find(b => b == series) != series) unicalSeries.Add(series);
                    }

                    MVPSSeriesBox.Items.Clear();
                    foreach (string str in unicalSeries)
                    {
                        var mvps = context.MVPSSet.Where(b => b.series == str).First();
                        MVPSSeriesBox.Items.Add(mvps.MVPSType.name + " " + mvps.series);
                    }

                    FillList();
                    FillTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SheduleForm_Load(object sender, EventArgs e)
        {

        }

        private void MVPSSeriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void MVPSTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MVPSTypeBox.Items.Count > 1)
            {
                if (MVPSTypeBox.SelectedIndex > 0)
                {
                    using (kipEntities context = new kipEntities())
                    {
                        try
                        {
                            var type = MVPSTypeBox.SelectedItem.ToString();
                            var seriesSet = context.MVPSSet.Select(b => b.series).ToList();
                            List<string> unicalSeries = new List<string>();

                            foreach (string series in seriesSet)
                            {
                                if (unicalSeries.Find(b => b == series) != series) unicalSeries.Add(series);
                            }

                            string value = null;
                            if (MVPSSeriesBox.SelectedIndex > -1)
                                value = MVPSSeriesBox.SelectedItem.ToString();

                            int i = 0;
                            MVPSSeriesBox.Items.Clear();
                            foreach (string str in unicalSeries)
                            {
                                var mvps_s = context.MVPSSet.Where(b => b.series == str && b.MVPSType.name == type).ToList();

                                if (mvps_s.Count() > 0)
                                {
                                    var mvps = mvps_s.First();
                                    MVPSSeriesBox.Items.Add(mvps.MVPSType.name + " " + mvps.series);
                                }
                            }

                            foreach (var item in MVPSSeriesBox.Items)
                            {
                                if (value == item.ToString()) MVPSSeriesBox.SelectedIndex = i;
                                i++;
                            }

                            if (MVPSSeriesBox.SelectedIndex == -1 && MVPSSeriesBox.Items.Count > 0) MVPSSeriesBox.SelectedIndex = 0;
                            if (MVPSSeriesBox.SelectedIndex == -1) MVPSSeriesBox.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else if (MVPSTypeBox.SelectedIndex == 0)
                {
                    using (kipEntities context = new kipEntities())
                    {
                        try
                        {
                            var seriesSet = context.MVPSSet.Select(b => b.series).ToList();
                            List<string> unicalSeries = new List<string>();

                            foreach (string series in seriesSet)
                            {
                                if (unicalSeries.Find(b => b == series) != series) unicalSeries.Add(series);
                            }

                            string value = null;
                            if (MVPSSeriesBox.SelectedIndex > -1)
                                value = MVPSSeriesBox.SelectedItem.ToString();

                            int i = 0;
                            MVPSSeriesBox.Items.Clear();
                            foreach (string str in unicalSeries)
                            {
                                var mvps = context.MVPSSet.Where(b => b.series == str).First();
                                MVPSSeriesBox.Items.Add(mvps.MVPSType.name + " " + mvps.series);
                            }

                            foreach (var item in MVPSSeriesBox.Items)
                            {
                                if (value == item.ToString()) MVPSSeriesBox.SelectedIndex = i;
                                i++;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void AddToRepairButton_Click(object sender, EventArgs e)
        {
            AddToShed(true);
        }

        private void AddToShed(bool isRepair)
        {
            CheckFields();
            {
                using (kipEntities context = new kipEntities())
                {
                    var shedule = context.SheduleSet.Where(b => b.date == dateTimePicker1.Value.Date).SingleOrDefault();

                    if (shedule == null)
                    {
                        shedule = new Shedule()
                        {
                            date = dateTimePicker1.Value.Date,
                        };
                        context.SheduleSet.Add(shedule);
                    }

                    var strings = MVPSSeriesBox.SelectedItem.ToString().Split(' ');
                    var type = strings[0];
                    var series = strings[1];
                    var mvps = context.MVPSSet.Where(b => b.series == series && b.MVPSType.name == type).First();
                    if (isRepair)
                        shedule.MVPS_Repair.Add(mvps);
                    else
                        shedule.MVPS_Maintenance.Add(mvps);

                    context.SaveChanges();
                    FillTable();
                    FillList();
                }
            }
        }

        private void FillList()
        {
            using (kipEntities context = new kipEntities())
            {
                DateTime date = dateTimePicker1.Value.Date;
                
                var shed = context.SheduleSet.Where(b => b.date == date ).SingleOrDefault();
                DayMVPSList.Items.Clear();
                
                if (shed != null) {
                    foreach (var to3 in shed.MVPS_Maintenance)
                        DayMVPSList.Items.Add("ТО3 " + to3.GetSeries());
                    foreach (var tr1 in shed.MVPS_Repair)
                        DayMVPSList.Items.Add("ТР1 " + tr1.GetSeries());
                }
                else DayMVPSList.Items.Add("Рассписания пока нет");
            }
        }

        private void FillTable()
        {
            using (kipEntities context = new kipEntities())
            {
                var sheds = context.SheduleSet.Where(b => b.date.Month == DateTime.Today.Month);

                dataGridView1.Rows.Clear();
                foreach(var shed in sheds)
                    dataGridView1.Rows.Add(GetRow(shed));

                dataGridView1.Sort(dataGridView1.Columns["date"], ListSortDirection.Ascending);
            }
                
            //throw new NotImplementedException();
        }

        private DataGridViewRow GetRow(Shedule shed)
        {
            var row = new DataGridViewRow();

            row.Cells.Add(new DataGridViewTextBoxCell { Value = shed.date.ToString("dd.MM.yy") });

            string strTO3 = "", strTR1 = "";
            foreach (MVPS mvps in shed.MVPS_Maintenance)
                strTO3 += mvps.GetSeries() + ",";
            foreach (MVPS mvps in shed.MVPS_Repair)
                strTR1 += mvps.GetSeries() + ",";
            strTO3 = strTO3.TrimEnd(',');
            strTR1 = strTR1.TrimEnd(',');
            
            row.Cells.Add(new DataGridViewTextBoxCell { Value = strTO3 });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = strTR1 });

            return row;
        }

        private void CheckFields()
        {
            //throw new NotImplementedException();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FillList();
        }

        private void AddToMaintenanceButton_Click(object sender, EventArgs e)
        {
            AddToShed(false);
        }

        private void DayMVPSList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = DayMVPSList.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                RemoveFromShed(index);
                DayMVPSList.Items.RemoveAt(index);
            }
        }

        private void RemoveFromShed(int v)
        {
            using (kipEntities context = new kipEntities())
            {
                var shedule = context.SheduleSet.Where(b => b.date == dateTimePicker1.Value.Date).SingleOrDefault();

                if (shedule == null)
                {
                    shedule = new Shedule()
                    {
                        date = dateTimePicker1.Value.Date,
                    };
                    context.SheduleSet.Add(shedule);
                }

                var strings = DayMVPSList.Items[v].ToString().Split(' ');

                var repairOrMaintenance = strings[0];
                var type = strings[1];
                var series = strings[2];

                var mvps = context.MVPSSet.Where(b => b.series == series && b.MVPSType.name == type).First();

                if (repairOrMaintenance == "ТО3")
                    shedule.MVPS_Maintenance.Remove(mvps); 
                else if (repairOrMaintenance == "ТР1")
                    shedule.MVPS_Repair.Remove(mvps);

                context.SaveChanges();
                FillTable();
            }
        }
    }
}
