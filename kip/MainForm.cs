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
        static LoginForm LoginForm;

        public MainForm(Worker loggedWorker, LoginForm Form)
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
    }
}
