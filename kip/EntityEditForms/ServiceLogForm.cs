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

        private void ServiceLogForm_Load(object sender, EventArgs e)
        {

        }

        private void FillForm(int id)
        {
            using (kipEntities context = new kipEntities())
            {
                var serviceLogId = context.ServiceLogSet.Where(b => b.Id == id).SingleOrDefault();
                var eq = serviceLogId.Equipment;
                foreach(var _event in eq.InstallingLog)
                {
                    var row = new DataGridViewRow();

                    row.Cells.Add(new DataGridViewTextBoxCell { Value = _event.date.ToString("dd.MM.yy") });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = "Установка " + _event.MVPS.GetSpec() });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = _event.Worker.GetFIO() });

                    dataGridView1.Rows.Add(row);
                }

                foreach (var _event in eq.RemovingLog)
                {
                    var row = new DataGridViewRow();

                    row.Cells.Add(new DataGridViewTextBoxCell { Value = _event.date.ToString("dd.MM.yy") });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = "Снят " + _event.MVPS.GetSpec() });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = _event.Worker.GetFIO() });

                    dataGridView1.Rows.Add(row);
                }

                foreach (var _event in eq.ServiceLog)
                {
                    var row = new DataGridViewRow();
                    string str;
                    if (_event.isRepair) str = "Ремонт";
                    else str = "Проверка";

                    row.Cells.Add(new DataGridViewTextBoxCell { Value = _event.date.ToString("dd.MM.yy") });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = str});
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = _event.Performer.GetFIO() });

                    dataGridView1.Rows.Add(row);
                }
            }
        }
    }
}
