namespace kip
{
    partial class EquipmentRuleForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.MVPSRoleBox_ = new System.Windows.Forms.ComboBox();
            this.MVPSTypeBox_ = new System.Windows.Forms.ComboBox();
            this.SystemTypeBox = new System.Windows.Forms.ComboBox();
            this.EquipmentTypeBox_ = new System.Windows.Forms.ListBox();
            this.MVPSTypeBox = new System.Windows.Forms.TextBox();
            this.MVPSRoleBox = new System.Windows.Forms.TextBox();
            this.EquipmentTypeBox = new System.Windows.Forms.ListBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(444, 353);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 28);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MVPSRoleBox_
            // 
            this.MVPSRoleBox_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MVPSRoleBox_.FormattingEnabled = true;
            this.MVPSRoleBox_.Location = new System.Drawing.Point(300, 29);
            this.MVPSRoleBox_.Name = "MVPSRoleBox_";
            this.MVPSRoleBox_.Size = new System.Drawing.Size(231, 24);
            this.MVPSRoleBox_.TabIndex = 1;
            this.MVPSRoleBox_.SelectedIndexChanged += new System.EventHandler(this.MVPSRoleBox__SelectedIndexChanged);
            // 
            // MVPSTypeBox_
            // 
            this.MVPSTypeBox_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MVPSTypeBox_.FormattingEnabled = true;
            this.MVPSTypeBox_.Location = new System.Drawing.Point(300, 74);
            this.MVPSTypeBox_.Name = "MVPSTypeBox_";
            this.MVPSTypeBox_.Size = new System.Drawing.Size(231, 24);
            this.MVPSTypeBox_.TabIndex = 2;
            this.MVPSTypeBox_.SelectedIndexChanged += new System.EventHandler(this.MVPSTypeBox__SelectedIndexChanged);
            // 
            // SystemTypeBox
            // 
            this.SystemTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SystemTypeBox.FormattingEnabled = true;
            this.SystemTypeBox.Location = new System.Drawing.Point(301, 117);
            this.SystemTypeBox.Name = "SystemTypeBox";
            this.SystemTypeBox.Size = new System.Drawing.Size(230, 24);
            this.SystemTypeBox.TabIndex = 3;
            this.SystemTypeBox.SelectedIndexChanged += new System.EventHandler(this.SystemTypeBox_SelectedIndexChanged);
            // 
            // EquipmentTypeBox_
            // 
            this.EquipmentTypeBox_.FormattingEnabled = true;
            this.EquipmentTypeBox_.ItemHeight = 16;
            this.EquipmentTypeBox_.Location = new System.Drawing.Point(301, 151);
            this.EquipmentTypeBox_.Name = "EquipmentTypeBox_";
            this.EquipmentTypeBox_.Size = new System.Drawing.Size(230, 196);
            this.EquipmentTypeBox_.TabIndex = 4;
            this.EquipmentTypeBox_.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EquipmentTypeBox__MouseDoubleClick);
            // 
            // MVPSTypeBox
            // 
            this.MVPSTypeBox.Enabled = false;
            this.MVPSTypeBox.Location = new System.Drawing.Point(8, 74);
            this.MVPSTypeBox.Name = "MVPSTypeBox";
            this.MVPSTypeBox.Size = new System.Drawing.Size(264, 22);
            this.MVPSTypeBox.TabIndex = 5;
            // 
            // MVPSRoleBox
            // 
            this.MVPSRoleBox.Enabled = false;
            this.MVPSRoleBox.Location = new System.Drawing.Point(8, 29);
            this.MVPSRoleBox.Name = "MVPSRoleBox";
            this.MVPSRoleBox.Size = new System.Drawing.Size(264, 22);
            this.MVPSRoleBox.TabIndex = 6;
            // 
            // EquipmentTypeBox
            // 
            this.EquipmentTypeBox.FormattingEnabled = true;
            this.EquipmentTypeBox.HorizontalScrollbar = true;
            this.EquipmentTypeBox.ItemHeight = 16;
            this.EquipmentTypeBox.Location = new System.Drawing.Point(8, 119);
            this.EquipmentTypeBox.Name = "EquipmentTypeBox";
            this.EquipmentTypeBox.Size = new System.Drawing.Size(264, 228);
            this.EquipmentTypeBox.TabIndex = 7;
            this.EquipmentTypeBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EquipmentTypeBox_MouseDoubleClick);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(8, 353);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(87, 28);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Роль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Список необходимого оборудования";
            // 
            // EquipmentRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EquipmentTypeBox);
            this.Controls.Add(this.MVPSRoleBox);
            this.Controls.Add(this.MVPSTypeBox);
            this.Controls.Add(this.EquipmentTypeBox_);
            this.Controls.Add(this.SystemTypeBox);
            this.Controls.Add(this.MVPSTypeBox_);
            this.Controls.Add(this.MVPSRoleBox_);
            this.Controls.Add(this.AddButton);
            this.Name = "EquipmentRuleForm";
            this.Text = "Правило комплектации";
            this.Load += new System.EventHandler(this.EquipmentRuleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox MVPSRoleBox_;
        private System.Windows.Forms.ComboBox MVPSTypeBox_;
        private System.Windows.Forms.ComboBox SystemTypeBox;
        private System.Windows.Forms.ListBox EquipmentTypeBox_;
        private System.Windows.Forms.TextBox MVPSTypeBox;
        private System.Windows.Forms.TextBox MVPSRoleBox;
        private System.Windows.Forms.ListBox EquipmentTypeBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}