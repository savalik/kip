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
    public partial class ReplacingForm : Form
    {
        public static Worker worker;
        static Form LoginForm;

        public ReplacingForm(Worker loggedWorker, Form Form)
        {
            InitializeComponent();
            worker = loggedWorker;
            LoginForm = Form;
            FillForm();
        }

        private void FillForm()
        {
            UserLabel.Text = worker.Family + " " + worker.Name + " " + worker.Patronymic;
            PersonnelNumberlLabel.Text = worker.PersonnelNumber.ToString();
            PositionLabel.Text = worker.Position.name;

            using (kipEntities context = new kipEntities())
            {
                DateTime date = DateTime.Today.Date;

                var shed = context.SheduleSet.Where(b => b.date == date).SingleOrDefault();
                dayMVPSList.Items.Clear();

                if (shed != null)
                {
                    foreach (var to3 in shed.MVPS_Maintenance)
                        dayMVPSList.Items.Add("ТО3 " + to3.GetSeries());
                    foreach (var tr1 in shed.MVPS_Repair)
                        dayMVPSList.Items.Add("ТР1 " + tr1.GetSeries());
                }
                else dayMVPSList.Items.Add("Рассписания пока нет");
            }
        }

        private void DoReplaceButton_Click(object sender, EventArgs e)
        {
            EquipmentInstallForm dBform = new EquipmentInstallForm(worker);
            dBform.ShowDialog();
        }

        private void ReplacingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
