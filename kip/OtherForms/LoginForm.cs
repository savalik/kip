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
                    MainForm main = new MainForm(worker);
                    this.Hide();
                    main.Show();
                    break;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
