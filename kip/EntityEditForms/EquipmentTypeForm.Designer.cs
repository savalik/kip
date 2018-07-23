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
            this.PlusMonthServ = new System.Windows.Forms.Button();
            this.PlusYearServ = new System.Windows.Forms.Button();
            this.ServicePeriodBox = new System.Windows.Forms.TextBox();
            this.VerificationPeriodBox = new System.Windows.Forms.TextBox();
            this.MinusMonthServ = new System.Windows.Forms.Button();
            this.MinusYearServ = new System.Windows.Forms.Button();
            this.PlusYearVerf = new System.Windows.Forms.Button();
            this.PlusMonthVerf = new System.Windows.Forms.Button();
            this.MinusYearVerf = new System.Windows.Forms.Button();
            this.MinusMonthVerf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(39, 500);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(87, 28);
            this.CloseButton.TabIndex = 17;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(39, 33);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(230, 22);
            this.NameBox.TabIndex = 1;
            // 
            // SysTypeBox
            // 
            this.SysTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SysTypeBox.FormattingEnabled = true;
            this.SysTypeBox.Location = new System.Drawing.Point(39, 123);
            this.SysTypeBox.Name = "SysTypeBox";
            this.SysTypeBox.Size = new System.Drawing.Size(230, 24);
            this.SysTypeBox.TabIndex = 3;
            // 
            // ManufactBox
            // 
            this.ManufactBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManufactBox.DropDownWidth = 230;
            this.ManufactBox.FormattingEnabled = true;
            this.ManufactBox.Location = new System.Drawing.Point(39, 76);
            this.ManufactBox.Name = "ManufactBox";
            this.ManufactBox.Size = new System.Drawing.Size(230, 24);
            this.ManufactBox.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(182, 500);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 28);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(39, 362);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(230, 132);
            this.DescriptionBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Производитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Тип системы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Описание";
            // 
            // PlusMonthServ
            // 
            this.PlusMonthServ.Location = new System.Drawing.Point(223, 190);
            this.PlusMonthServ.Name = "PlusMonthServ";
            this.PlusMonthServ.Size = new System.Drawing.Size(75, 31);
            this.PlusMonthServ.TabIndex = 24;
            this.PlusMonthServ.Text = "+ месяц";
            this.PlusMonthServ.UseVisualStyleBackColor = true;
            this.PlusMonthServ.Click += new System.EventHandler(this.PlusMonthServ_Click);
            // 
            // PlusYearServ
            // 
            this.PlusYearServ.Location = new System.Drawing.Point(223, 227);
            this.PlusYearServ.Name = "PlusYearServ";
            this.PlusYearServ.Size = new System.Drawing.Size(75, 31);
            this.PlusYearServ.TabIndex = 25;
            this.PlusYearServ.Text = "+ год";
            this.PlusYearServ.UseVisualStyleBackColor = true;
            this.PlusYearServ.Click += new System.EventHandler(this.PlusYearServ_Click);
            // 
            // ServicePeriodBox
            // 
            this.ServicePeriodBox.Location = new System.Drawing.Point(96, 214);
            this.ServicePeriodBox.Name = "ServicePeriodBox";
            this.ServicePeriodBox.Size = new System.Drawing.Size(121, 22);
            this.ServicePeriodBox.TabIndex = 4;
            // 
            // VerificationPeriodBox
            // 
            this.VerificationPeriodBox.Location = new System.Drawing.Point(96, 308);
            this.VerificationPeriodBox.Name = "VerificationPeriodBox";
            this.VerificationPeriodBox.Size = new System.Drawing.Size(121, 22);
            this.VerificationPeriodBox.TabIndex = 5;
            // 
            // MinusMonthServ
            // 
            this.MinusMonthServ.Location = new System.Drawing.Point(12, 190);
            this.MinusMonthServ.Name = "MinusMonthServ";
            this.MinusMonthServ.Size = new System.Drawing.Size(75, 31);
            this.MinusMonthServ.TabIndex = 28;
            this.MinusMonthServ.Text = "- месяц";
            this.MinusMonthServ.UseVisualStyleBackColor = true;
            this.MinusMonthServ.Click += new System.EventHandler(this.MinusMonthServ_Click);
            // 
            // MinusYearServ
            // 
            this.MinusYearServ.Location = new System.Drawing.Point(12, 227);
            this.MinusYearServ.Name = "MinusYearServ";
            this.MinusYearServ.Size = new System.Drawing.Size(75, 31);
            this.MinusYearServ.TabIndex = 29;
            this.MinusYearServ.Text = "- год";
            this.MinusYearServ.UseVisualStyleBackColor = true;
            this.MinusYearServ.Click += new System.EventHandler(this.MinusYearServ_Click);
            // 
            // PlusYearVerf
            // 
            this.PlusYearVerf.Location = new System.Drawing.Point(223, 325);
            this.PlusYearVerf.Name = "PlusYearVerf";
            this.PlusYearVerf.Size = new System.Drawing.Size(75, 31);
            this.PlusYearVerf.TabIndex = 31;
            this.PlusYearVerf.Text = "+ год";
            this.PlusYearVerf.UseVisualStyleBackColor = true;
            this.PlusYearVerf.Click += new System.EventHandler(this.PlusYearVerf_Click);
            // 
            // PlusMonthVerf
            // 
            this.PlusMonthVerf.Location = new System.Drawing.Point(223, 288);
            this.PlusMonthVerf.Name = "PlusMonthVerf";
            this.PlusMonthVerf.Size = new System.Drawing.Size(75, 31);
            this.PlusMonthVerf.TabIndex = 30;
            this.PlusMonthVerf.Text = "+ месяц";
            this.PlusMonthVerf.UseVisualStyleBackColor = true;
            this.PlusMonthVerf.Click += new System.EventHandler(this.PlusMonthVerf_Click);
            // 
            // MinusYearVerf
            // 
            this.MinusYearVerf.Location = new System.Drawing.Point(12, 325);
            this.MinusYearVerf.Name = "MinusYearVerf";
            this.MinusYearVerf.Size = new System.Drawing.Size(75, 31);
            this.MinusYearVerf.TabIndex = 33;
            this.MinusYearVerf.Text = "- год";
            this.MinusYearVerf.UseVisualStyleBackColor = true;
            this.MinusYearVerf.Click += new System.EventHandler(this.MinusYearVerf_Click);
            // 
            // MinusMonthVerf
            // 
            this.MinusMonthVerf.Location = new System.Drawing.Point(12, 288);
            this.MinusMonthVerf.Name = "MinusMonthVerf";
            this.MinusMonthVerf.Size = new System.Drawing.Size(75, 31);
            this.MinusMonthVerf.TabIndex = 32;
            this.MinusMonthVerf.Text = "- месяц";
            this.MinusMonthVerf.UseVisualStyleBackColor = true;
            this.MinusMonthVerf.Click += new System.EventHandler(this.MinusMonthVerf_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Период проверки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Период поверки";
            // 
            // EquipmentTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 536);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MinusYearVerf);
            this.Controls.Add(this.MinusMonthVerf);
            this.Controls.Add(this.PlusYearVerf);
            this.Controls.Add(this.PlusMonthVerf);
            this.Controls.Add(this.MinusYearServ);
            this.Controls.Add(this.MinusMonthServ);
            this.Controls.Add(this.VerificationPeriodBox);
            this.Controls.Add(this.ServicePeriodBox);
            this.Controls.Add(this.PlusYearServ);
            this.Controls.Add(this.PlusMonthServ);
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
            this.Text = "Тип оборудования";
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
        private System.Windows.Forms.Button PlusMonthServ;
        private System.Windows.Forms.Button PlusYearServ;
        private System.Windows.Forms.TextBox ServicePeriodBox;
        private System.Windows.Forms.TextBox VerificationPeriodBox;
        private System.Windows.Forms.Button MinusMonthServ;
        private System.Windows.Forms.Button MinusYearServ;
        private System.Windows.Forms.Button PlusYearVerf;
        private System.Windows.Forms.Button PlusMonthVerf;
        private System.Windows.Forms.Button MinusYearVerf;
        private System.Windows.Forms.Button MinusMonthVerf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}