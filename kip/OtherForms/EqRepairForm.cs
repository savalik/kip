﻿using System;
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
    public partial class EqRepairForm : Form
    {
        public static Worker worker;
        static Form LoginForm;

        public EqRepairForm(Worker loggedWorker, Form Form)
        {
            InitializeComponent();
            worker = loggedWorker;
            LoginForm = Form;
            FillForm();
        }

        private void EqRepairForm_Load(object sender, EventArgs e)
        {

        }

        private void FillForm()
        {
            UserLabel.Text = worker.Family + " " + worker.Name + " " + worker.Patronymic;
            PersonnelNumberlLabel.Text = worker.PersonnelNumber.ToString();
            PositionLabel.Text = worker.Position.name;
        }
    }
}
