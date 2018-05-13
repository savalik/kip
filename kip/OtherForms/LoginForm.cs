using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Login(int.Parse(PersonnelNumberBox.Text), PasswordBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Login(int PersonnelNumber, string Password)
        {
            using (kipEntities context = new kipEntities())
            {
                SHA1 sha = new SHA1CryptoServiceProvider();
                var buffer = Encoding.Unicode.GetBytes(Password);
                byte[] result = sha.ComputeHash(buffer);

                Worker worker = context.WorkerSet.Include("Position").Where(b => b.PersonnelNumber == PersonnelNumber).SingleOrDefault();

                string inSystemHash = worker.PinCodeHash;
                string hash = Convert.ToBase64String(result);

                if (inSystemHash != hash) throw new Exception("Не удалось войти в систему. Проверьте правильность ввода логина и пароля, или свяжитесь с разработчиком");
                else
                {
                    var position = worker.Position.Id;
                    GetNextForm(position, worker);
                }

            }
                
        }

        private void GetNextForm(int position, Worker worker)
        {
            switch (position)
            {
                case 6:
                    MainForm main = new MainForm(worker, this);
                    this.Hide();
                    main.Show();
                    break;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Расслыем IP для входящих TCP подключений широковещательной рассылкой.
            IPAnoncer anoncer = new IPAnoncer();
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            PersonnelNumberBox.Text = "";
            PasswordBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ///ToDo: не пускать этот код в продакшн
            using (kipEntities context = new kipEntities())
            {
                Worker worker = context.WorkerSet.Include("Position").Where(b => b.PersonnelNumber == 11179474).SingleOrDefault();
                var position = worker.Position.Id;
                GetNextForm(position, worker);

            }
        }
    }
}
