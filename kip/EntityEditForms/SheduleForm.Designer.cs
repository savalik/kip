namespace kip
{
    partial class SheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MVPSSeriesBox = new System.Windows.Forms.ComboBox();
            this.MVPSTypeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddToRepairButton = new System.Windows.Forms.Button();
            this.AddToMaintenanceButton = new System.Windows.Forms.Button();
            this.DayMVPSList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.maintenance,
            this.repair});
            this.dataGridView1.Location = new System.Drawing.Point(464, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.Width = 80;
            // 
            // maintenance
            // 
            this.maintenance.HeaderText = "МВПС на ТО3";
            this.maintenance.Name = "maintenance";
            this.maintenance.Width = 460;
            // 
            // repair
            // 
            this.repair.HeaderText = "МВПС на ТР1";
            this.repair.Name = "repair";
            // 
            // MVPSSeriesBox
            // 
            this.MVPSSeriesBox.FormattingEnabled = true;
            this.MVPSSeriesBox.Location = new System.Drawing.Point(12, 67);
            this.MVPSSeriesBox.Name = "MVPSSeriesBox";
            this.MVPSSeriesBox.Size = new System.Drawing.Size(121, 24);
            this.MVPSSeriesBox.TabIndex = 26;
            this.MVPSSeriesBox.SelectedIndexChanged += new System.EventHandler(this.MVPSSeriesBox_SelectedIndexChanged);
            // 
            // MVPSTypeBox
            // 
            this.MVPSTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MVPSTypeBox.FormattingEnabled = true;
            this.MVPSTypeBox.Location = new System.Drawing.Point(12, 114);
            this.MVPSTypeBox.Name = "MVPSTypeBox";
            this.MVPSTypeBox.Size = new System.Drawing.Size(121, 24);
            this.MVPSTypeBox.TabIndex = 25;
            this.MVPSTypeBox.SelectedIndexChanged += new System.EventHandler(this.MVPSTypeBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Серия МВПС";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AddToRepairButton
            // 
            this.AddToRepairButton.Location = new System.Drawing.Point(12, 203);
            this.AddToRepairButton.Name = "AddToRepairButton";
            this.AddToRepairButton.Size = new System.Drawing.Size(197, 28);
            this.AddToRepairButton.TabIndex = 28;
            this.AddToRepairButton.Text = "Добавить в план ТР1";
            this.AddToRepairButton.UseVisualStyleBackColor = true;
            this.AddToRepairButton.Click += new System.EventHandler(this.AddToRepairButton_Click);
            // 
            // AddToMaintenanceButton
            // 
            this.AddToMaintenanceButton.Location = new System.Drawing.Point(12, 169);
            this.AddToMaintenanceButton.Name = "AddToMaintenanceButton";
            this.AddToMaintenanceButton.Size = new System.Drawing.Size(197, 28);
            this.AddToMaintenanceButton.TabIndex = 29;
            this.AddToMaintenanceButton.Text = "Добавить в план ТO3";
            this.AddToMaintenanceButton.UseVisualStyleBackColor = true;
            this.AddToMaintenanceButton.Click += new System.EventHandler(this.AddToMaintenanceButton_Click);
            // 
            // DayMVPSList
            // 
            this.DayMVPSList.FormattingEnabled = true;
            this.DayMVPSList.ItemHeight = 16;
            this.DayMVPSList.Location = new System.Drawing.Point(232, 12);
            this.DayMVPSList.Name = "DayMVPSList";
            this.DayMVPSList.Size = new System.Drawing.Size(213, 212);
            this.DayMVPSList.TabIndex = 30;
            this.DayMVPSList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(DayMVPSList_MouseDoubleClick);
            // 
            // SheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 449);
            this.Controls.Add(this.DayMVPSList);
            this.Controls.Add(this.AddToMaintenanceButton);
            this.Controls.Add(this.AddToRepairButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MVPSSeriesBox);
            this.Controls.Add(this.MVPSTypeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SheduleForm";
            this.Text = "SheduleForm";
            this.Load += new System.EventHandler(this.SheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn repair;
        private System.Windows.Forms.ComboBox MVPSSeriesBox;
        private System.Windows.Forms.ComboBox MVPSTypeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AddToRepairButton;
        private System.Windows.Forms.Button AddToMaintenanceButton;
        private System.Windows.Forms.ListBox DayMVPSList;
    }
}