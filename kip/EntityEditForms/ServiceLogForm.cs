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
    public partial class ServiceLogForm : Form
    {
        public ServiceLogForm()
        {
            InitializeComponent();
        }

        public ServiceLogForm(DataGridView view)
        {
            InitializeComponent();
            var id = view.CurrentRow.Cells[0].Value;
            FillForm((int)id);
        }

        public ServiceLogForm(int id)
        {
            InitializeComponent();
            FillForm(id);
        }

        private void ServiceLogForm_Load(object sender, EventArgs e)
        {

        }

        private void FillForm(int id)
        {
            using (kipEntities context = new kipEntities())
            {
                var service = context.ServiceLogSet.Where(b => b.Id == id).SingleOrDefault();
                var eq = service.Equipment;
                Text = eq.EquipmentType.name + " №" + eq.number;

                foreach(var _event in eq.InstallingLog)
                {
                    AddRow(_event,"Установка");
                }

                foreach (var _event in eq.RemovingLog)
                {
                    AddRow(_event, "Cнят");
                }

                foreach (var _event in eq.ServiceLog)
                {
                    var row = new DataGridViewRow();
                    string str;
                    if (_event.isRepair) str = "Ремонт";
                    else str = "Проверка";

                    row.Cells.Add(new DataGridViewTextBoxCell { Value = _event.date.ToString("dd.MM.yy H:mm") });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = str});
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = _event.Performer.GetFIO() });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = _event.description });
                    row.DefaultCellStyle.BackColor = Color.ForestGreen;

                    dataGridView1.Rows.Add(row);
                }

                dataGridView1.Sort(dataGridView1.Columns["date"], ListSortDirection.Ascending);
            }
        }

        private void AddRow(ReplacingLog _event, string str)
        {
            var row = new DataGridViewRow();

            row.Cells.Add(new DataGridViewTextBoxCell { Value = _event.date.ToString("dd.MM.yy H:mm") });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = str +  " " + _event.MVPS.GetSpec() });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = _event.Worker.GetFIO() });
            switch (str)
            {
                case "Установка":
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = "" });
                    break;
                default:
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = _event.description });
                    break;
            }
            if (_event.onShedule)
                switch (str)
                {
                    case "Установка":
                        row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                        break;
                    case "Cнят":
                        row.DefaultCellStyle.BackColor = Color.DarkCyan;
                        break;
                    default:
                        break;
                }
            else
            {
                switch (str)
                {
                    case "Установка":
                        row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                        break;
                    case "Cнят":
                        row.DefaultCellStyle.ForeColor = Color.White;
                        row.DefaultCellStyle.BackColor = Color.DarkRed;
                        break;
                    default:
                        break;
                }
            }

            dataGridView1.Rows.Add(row);
        }
    }
}
