namespace kip
{
    partial class EquipmentTypeForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SysTypeBox = new System.Windows.Forms.ComboBox();
            this.ManufactBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(52, 311);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(87, 28);
            this.CloseButton.TabIndex = 17;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(52, 38);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(230, 22);
            this.NameBox.TabIndex = 15;
            // 
            // SysTypeBox
            // 
            this.SysTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SysTypeBox.FormattingEnabled = true;
            this.SysTypeBox.Location = new System.Drawing.Point(52, 128);
            this.SysTypeBox.Name = "SysTypeBox";
            this.SysTypeBox.Size = new System.Drawing.Size(230, 24);
            this.SysTypeBox.TabIndex = 12;
            // 
            // ManufactBox
            // 
            this.ManufactBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManufactBox.DropDownWidth = 230;
            this.ManufactBox.FormattingEnabled = true;
            this.ManufactBox.Location = new System.Drawing.Point(52, 81);
            this.ManufactBox.Name = "ManufactBox";
            this.ManufactBox.Size = new System.Drawing.Size(230, 24);
            this.ManufactBox.TabIndex = 11;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(195, 311);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 28);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(52, 173);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(230, 132);
            this.DescriptionBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Производитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Тип системы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Описание";
            // 
            // EquipmentTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 353);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SysTypeBox);
            this.Controls.Add(this.ManufactBox);
            this.Controls.Add(this.AddButton);
            this.Name = "EquipmentTypeForm";
            this.Text = "EquipmentTypeForm";
            this.Load += new System.EventHandler(this.EquipmentTypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ComboBox SysTypeBox;
        private System.Windows.Forms.ComboBox ManufactBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}