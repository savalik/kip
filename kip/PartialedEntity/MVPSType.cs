﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kip
{
    public partial class MVPSType
    {
        public DataGridViewRow GetRow()
        {
            var row = new DataGridViewRow();

            var s = new MVPSType();
            
            row.Cells.Add(new DataGridViewTextBoxCell { Value = Id });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = name });

            return row;
        }

        public static void GetColumns(DataGridView view)
        {
            try
            {
                view.Columns.Clear();
                view.Columns.Add("id", "ID");
                view.Columns.Add("name", "Название");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void FillGrid(DataGridView view)
        {
            using (kipEntities context = new kipEntities())
            {
                //ToDo: не забыть изменить тип при копировании тут
                var k = context.MVPSTypeSet.ToList();

                GetColumns(view);
                view.Rows.Clear();

                //ToDo: и тут
                foreach (MVPSType z in k)
                {
                    view.Rows.Add(z.GetRow());
                }
            }
        }
    }
}
