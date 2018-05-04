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
    public partial class EquipmentTypeForm : Form
    {
        static List<SystemType> systemTypes;
        static List<Manufacturer> manufacturers;
        static int selectedType;
        static int selectedManufacturer;
        private DataGridViewCellEventArgs mouseLocation;

        public EquipmentTypeForm()
        {
            InitializeComponent();
        }

        private void EquipmentTypeForm_Load(object sender, EventArgs e)
        {
            DataGridView grid = EquipmentTypeGridView;
            using (kipEntities context = new kipEntities())
            {
                try
                {
                    
                    grid.Columns.Add("name", "Наименование");
                    grid.Columns.Add("description", "Описание");
                    grid.Columns.Add("systemType", "Тип системы");
                    grid.Columns.Add("manufacturer", "Производитель");

                    systemTypes = context.SystemTypeSet.ToList();
                    manufacturers = context.ManufacturerSet.ToList();

                    grid.ContextMenuStrip = GetMenu();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private ContextMenuStrip GetMenu()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.ItemClicked += new ToolStripItemClickedEventHandler(Menu_Click);
            menu.Opening += new CancelEventHandler(Menu_Opening);
            return menu;
        }

        private void Menu_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            EquipmentTypeGridView.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex].Value = e.ClickedItem.Text;
        }

        private void Menu_Opening(object sender, EventArgs e)
        {
            EquipmentTypeGridView.ContextMenuStrip.Items.Clear();
            if (mouseLocation.ColumnIndex == 2)
            {
                foreach (SystemType item in systemTypes)
                {
                    EquipmentTypeGridView.ContextMenuStrip.Items.Add(item.name);
                }
            }
            else if (mouseLocation.ColumnIndex == 3)
            {
                foreach (Manufacturer item in manufacturers)
                {
                    EquipmentTypeGridView.ContextMenuStrip.Items.Add(item.name);
                }
            }
        }

        private void EquipmentTypeGridView_CellMouseEnter(object sender,DataGridViewCellEventArgs location)
        {
            mouseLocation = location;
        }

        private void EquipmentTypeGridView_CellMouseClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
            //EquipmentTypeGridView.ContextMenuStrip = GetMenu();
        }
    }
}
