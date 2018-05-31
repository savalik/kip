using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class MainForm : Form
    {
        public static Worker worker;
        static Form LoginForm;

        public MainForm(Worker loggedWorker, Form Form)
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
            PersonnelNumberlLabel.Location = new Point(UserLabel.Location.X + UserLabel.Width + 20, PersonnelNumberlLabel.Location.Y);
            PositionLabel.Location = new Point(UserLabel.Location.X + UserLabel.Width + 20, PositionLabel.Location.Y);

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

        private void Button1_Click(object sender, EventArgs e)
        {
            DBform dBform = new DBform();
            dBform.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            EquipmentInstallForm dBform = new EquipmentInstallForm();
            dBform.ShowDialog();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Receiver receiver = new Receiver();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Show();
        }

        private void OpenMasterForm_Click(object sender, EventArgs e)
        {
            GetNextForm(4, worker);
        }

        private void GetNextForm(int position, Worker worker)
        {
            Form main = null;
            switch (position)
            {
                case 1:
                    main = new MainForm(worker, this);
                    this.Hide();
                    main.Show();
                    break;
                case 2:
                    main = new EqRepairForm(worker, this);
                    this.Hide();
                    main.Show();
                    break;
                case 3:
                    main = new ReplacingForm(worker, this);
                    this.Hide();
                    main.Show();
                    break;
                case 4:
                    main = new MastersForm(worker, this);
                    this.Hide();
                    main.Show();
                    break;
            }
        }
    }
}
