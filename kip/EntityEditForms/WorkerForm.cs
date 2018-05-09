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
    public partial class WorkerForm : Form
    {
        static Worker worker = null;

        public WorkerForm()
        {
            InitializeComponent();
            FillForm();
        }

        private void FillForm()
        {
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    var positions = context.PositionSet.ToList();

                    PositionBox.Items.Clear();

                    foreach (Position pos in positions)
                        PositionBox.Items.Add(pos.name);

                    if (worker != null)
                    {
                        NameBox.Text = worker.Name;
                        FamilyBox.Text = worker.Family;
                        PatronymicBox.Text = worker.Patronymic;
                        PersonnelNumberBox.Text = worker.PersonnelNumber.ToString();
                        worker = null;
                    }
                    
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        public WorkerForm(DataGridView view)
        {
            InitializeComponent();
            var id = view.CurrentRow.Cells[0].Value;
            FillForm();
            FillEntity((int)id);
        }

        private void FillEntity(int id)
        {
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    worker = context.WorkerSet.Where(b => b.Id == id).SingleOrDefault();
                    if (worker != null)
                    {
                        NameBox.Text = worker.Name;
                        FamilyBox.Text = worker.Family;
                        PatronymicBox.Text = worker.Patronymic;
                        PersonnelNumberBox.Text = worker.PersonnelNumber.ToString();
                    }

                    var positions = context.PositionSet.ToList();

                    PositionBox.Items.Clear();

                    foreach (Position pos in positions)
                    {
                        PositionBox.Items.Add(pos.name);
                        if(worker != null)
                            if (worker.Position.name == pos.name)
                                PositionBox.SelectedIndex = PositionBox.Items.Count - 1;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    if (!ChechFields()) throw new Exception("Все поля обязательны к заполнению. Заполните их.");
                    string pos = PositionBox.Items[PositionBox.SelectedIndex].ToString();

                    if (worker != null)
                    {
                        
                        Worker freshWorker = context.WorkerSet.Where(b => b.Id == worker.Id).SingleOrDefault();
                        if (freshWorker.Name != NameBox.Text) freshWorker.Name = NameBox.Text;
                        if (freshWorker.Family != FamilyBox.Text) freshWorker.Family = FamilyBox.Text;
                        if (freshWorker.Patronymic != PatronymicBox.Text) freshWorker.Patronymic = PatronymicBox.Text;
                        if (freshWorker.PersonnelNumber != int.Parse(PersonnelNumberBox.Text)) freshWorker.PersonnelNumber = int.Parse(PersonnelNumberBox.Text);
                        if (freshWorker.Position.name != pos)
                        {
                            Position position = context.PositionSet.Where(b => Name == pos).SingleOrDefault();
                            freshWorker.Position = position;
                        }
                        context.SaveChanges();
                    }
                    else
                    {
                        Position position = context.PositionSet.Where(b => b.name == pos).SingleOrDefault();

                        SHA1 sha = new SHA1CryptoServiceProvider();
                        var buffer = Encoding.Unicode.GetBytes("0000");
                        byte[] result = sha.ComputeHash(buffer);
                        string hash = Convert.ToBase64String(result);

                        worker = new Worker
                        {
                            Name = NameBox.Text,
                            Family = FamilyBox.Text,
                            Patronymic = PatronymicBox.Text,
                            PersonnelNumber = int.Parse(PersonnelNumberBox.Text),
                            Position = position,
                            PinCodeHash = hash
                        };

                        context.WorkerSet.Add(worker);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Close();
                }
            }
        }

        private bool ChechFields()
        {
            if (FamilyBox.Text != null)
                if (NameBox.Text != null)
                    if (PatronymicBox.Text != null)
                        if (PersonnelNumberBox.Text != null)
                            if (PositionBox.SelectedIndex != -1)
                                return true;
            return false;
        }

    }
}
