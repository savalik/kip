namespace kip
{
    partial class EquipmentInstallForm
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
            this.MVPSRoleBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MVPSTypeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mvpsGrid = new System.Windows.Forms.DataGridView();
            this.EquipmentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MVPSNumberBox = new System.Windows.Forms.ComboBox();
            this.MVPSSeriesBox = new System.Windows.Forms.ComboBox();
            this.equipmentGrid = new System.Windows.Forms.DataGridView();
            this.eqId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mvpsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MVPSRoleBox
            // 
            this.MVPSRoleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MVPSRoleBox.FormattingEnabled = true;
            this.MVPSRoleBox.Location = new System.Drawing.Point(11, 169);
            this.MVPSRoleBox.Name = "MVPSRoleBox";
            this.MVPSRoleBox.Size = new System.Drawing.Size(121, 24);
            this.MVPSRoleBox.TabIndex = 18;
            this.MVPSRoleBox.SelectedIndexChanged += new System.EventHandler(this.MVPSRoleBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Роль";
            // 
            // MVPSTypeBox
            // 
            this.MVPSTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MVPSTypeBox.FormattingEnabled = true;
            this.MVPSTypeBox.Location = new System.Drawing.Point(11, 122);
            this.MVPSTypeBox.Name = "MVPSTypeBox";
            this.MVPSTypeBox.Size = new System.Drawing.Size(121, 24);
            this.MVPSTypeBox.TabIndex = 16;
            this.MVPSTypeBox.SelectedIndexChanged += new System.EventHandler(this.MVPSTypeBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Серия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Номер";
            // 
            // mvpsGrid
            // 
            this.mvpsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mvpsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipmentType,
            this.SystemType,
            this.EquipmentNumber,
            this.ServiceDate});
            this.mvpsGrid.Location = new System.Drawing.Point(157, 12);
            this.mvpsGrid.Name = "mvpsGrid";
            this.mvpsGrid.ReadOnly = true;
            this.mvpsGrid.RowTemplate.Height = 24;
            this.mvpsGrid.Size = new System.Drawing.Size(557, 531);
            this.mvpsGrid.TabIndex = 20;
            this.mvpsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mvpsGrid_CellClick);
            this.mvpsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mvpsGrid_CellDoubleClick);
            // 
            // EquipmentType
            // 
            this.EquipmentType.HeaderText = "Тип оборудования";
            this.EquipmentType.Name = "EquipmentType";
            this.EquipmentType.Width = 120;
            // 
            // SystemType
            // 
            this.SystemType.HeaderText = "Тип системы";
            this.SystemType.Name = "SystemType";
            this.SystemType.Width = 150;
            // 
            // EquipmentNumber
            // 
            this.EquipmentNumber.HeaderText = "Номер блока";
            this.EquipmentNumber.Name = "EquipmentNumber";
            this.EquipmentNumber.Width = 120;
            // 
            // ServiceDate
            // 
            this.ServiceDate.HeaderText = "Дата обслуживания";
            this.ServiceDate.Name = "ServiceDate";
            this.ServiceDate.Width = 120;
            // 
            // MVPSNumberBox
            // 
            this.MVPSNumberBox.FormattingEnabled = true;
            this.MVPSNumberBox.Location = new System.Drawing.Point(12, 77);
            this.MVPSNumberBox.Name = "MVPSNumberBox";
            this.MVPSNumberBox.Size = new System.Drawing.Size(121, 24);
            this.MVPSNumberBox.TabIndex = 21;
            this.MVPSNumberBox.SelectedIndexChanged += new System.EventHandler(this.MVPSNumberBox_SelectedIndexChanged);
            // 
            // MVPSSeriesBox
            // 
            this.MVPSSeriesBox.FormattingEnabled = true;
            this.MVPSSeriesBox.Location = new System.Drawing.Point(12, 32);
            this.MVPSSeriesBox.Name = "MVPSSeriesBox";
            this.MVPSSeriesBox.Size = new System.Drawing.Size(121, 24);
            this.MVPSSeriesBox.TabIndex = 22;
            this.MVPSSeriesBox.SelectedIndexChanged += new System.EventHandler(this.MVPSSeriesBox_SelectedIndexChanged);
            // 
            // equipmentGrid
            // 
            this.equipmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eqId,
            this.type,
            this.number,
            this.date});
            this.equipmentGrid.Location = new System.Drawing.Point(720, 12);
            this.equipmentGrid.Name = "equipmentGrid";
            this.equipmentGrid.ReadOnly = true;
            this.equipmentGrid.RowTemplate.Height = 24;
            this.equipmentGrid.Size = new System.Drawing.Size(395, 531);
            this.equipmentGrid.TabIndex = 23;
            this.equipmentGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equipmentGrid_CellDoubleClick);
            // 
            // eqId
            // 
            this.eqId.HeaderText = "id";
            this.eqId.Name = "eqId";
            this.eqId.Visible = false;
            // 
            // type
            // 
            this.type.HeaderText = "Тип блока";
            this.type.Name = "type";
            this.type.Width = 110;
            // 
            // number
            // 
            this.number.HeaderText = "Номер блока";
            this.number.Name = "number";
            this.number.Width = 120;
            // 
            // date
            // 
            this.date.HeaderText = "Дата обслуживания";
            this.date.Name = "date";
            this.date.Width = 120;
            // 
            // EquipmentInstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 555);
            this.Controls.Add(this.equipmentGrid);
            this.Controls.Add(this.MVPSSeriesBox);
            this.Controls.Add(this.MVPSNumberBox);
            this.Controls.Add(this.mvpsGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MVPSRoleBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MVPSTypeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "EquipmentInstallForm";
            this.Text = "EquipmentInstallForm";
            this.Load += new System.EventHandler(this.EquipmentInstallForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mvpsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MVPSRoleBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MVPSTypeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView mvpsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDate;
        private System.Windows.Forms.ComboBox MVPSNumberBox;
        private System.Windows.Forms.ComboBox MVPSSeriesBox;
        private System.Windows.Forms.DataGridView equipmentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn eqId;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}