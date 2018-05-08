namespace kip
{
    partial class EquipmentForm
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
            this.IsFree = new System.Windows.Forms.CheckBox();
            this.IsWorking = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CancesButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RepairDate = new System.Windows.Forms.MaskedTextBox();
            this.ServiceDate = new System.Windows.Forms.MaskedTextBox();
            this.VerificationDate = new System.Windows.Forms.MaskedTextBox();
            this.TerminationDate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // IsFree
            // 
            this.IsFree.AutoSize = true;
            this.IsFree.Location = new System.Drawing.Point(19, 362);
            this.IsFree.Name = "IsFree";
            this.IsFree.Size = new System.Drawing.Size(94, 21);
            this.IsFree.TabIndex = 7;
            this.IsFree.Text = "Свободен";
            this.IsFree.UseVisualStyleBackColor = true;
            // 
            // IsWorking
            // 
            this.IsWorking.AutoSize = true;
            this.IsWorking.Location = new System.Drawing.Point(19, 335);
            this.IsWorking.Name = "IsWorking";
            this.IsWorking.Size = new System.Drawing.Size(94, 21);
            this.IsWorking.TabIndex = 6;
            this.IsWorking.Text = "Исправен";
            this.IsWorking.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // IdBox
            // 
            this.IdBox.Enabled = false;
            this.IdBox.Location = new System.Drawing.Point(12, 35);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(265, 22);
            this.IdBox.TabIndex = 2;
            this.IdBox.Text = "7d75757c-f6ef-445c-b042-6d4e54df4bad";
            // 
            // TypeBox
            // 
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(12, 80);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(265, 24);
            this.TypeBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номер";
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(15, 127);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(100, 22);
            this.NumberBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата последнего ремонта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Дата последнего обслуживания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дата следующей поверки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Дата конца срока службы";
            // 
            // CancesButton
            // 
            this.CancesButton.Location = new System.Drawing.Point(12, 427);
            this.CancesButton.Name = "CancesButton";
            this.CancesButton.Size = new System.Drawing.Size(89, 33);
            this.CancesButton.TabIndex = 10;
            this.CancesButton.Text = "Отмена";
            this.CancesButton.UseVisualStyleBackColor = true;
            this.CancesButton.Click += new System.EventHandler(this.CancesButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(197, 427);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(89, 33);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RepairDate
            // 
            this.RepairDate.Location = new System.Drawing.Point(15, 172);
            this.RepairDate.Mask = "00/00/00";
            this.RepairDate.Name = "RepairDate";
            this.RepairDate.Size = new System.Drawing.Size(100, 22);
            this.RepairDate.TabIndex = 3;
            this.RepairDate.ValidatingType = typeof(System.DateTime);
            // 
            // ServiceDate
            // 
            this.ServiceDate.Location = new System.Drawing.Point(15, 217);
            this.ServiceDate.Mask = "00/00/00";
            this.ServiceDate.Name = "ServiceDate";
            this.ServiceDate.Size = new System.Drawing.Size(100, 22);
            this.ServiceDate.TabIndex = 4;
            // 
            // VerificationDate
            // 
            this.VerificationDate.Location = new System.Drawing.Point(15, 262);
            this.VerificationDate.Mask = "00/00/00";
            this.VerificationDate.Name = "VerificationDate";
            this.VerificationDate.Size = new System.Drawing.Size(100, 22);
            this.VerificationDate.TabIndex = 5;
            // 
            // TerminationDate
            // 
            this.TerminationDate.Location = new System.Drawing.Point(15, 307);
            this.TerminationDate.Mask = "00/00/00";
            this.TerminationDate.Name = "TerminationDate";
            this.TerminationDate.Size = new System.Drawing.Size(100, 22);
            this.TerminationDate.TabIndex = 9;
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 472);
            this.Controls.Add(this.TerminationDate);
            this.Controls.Add(this.VerificationDate);
            this.Controls.Add(this.ServiceDate);
            this.Controls.Add(this.RepairDate);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancesButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.IsWorking);
            this.Controls.Add(this.IsFree);
            this.Name = "EquipmentForm";
            this.Text = "EquipmentForm";
            this.Load += new System.EventHandler(this.EquipmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IsFree;
        private System.Windows.Forms.CheckBox IsWorking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CancesButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.MaskedTextBox RepairDate;
        private System.Windows.Forms.MaskedTextBox ServiceDate;
        private System.Windows.Forms.MaskedTextBox VerificationDate;
        private System.Windows.Forms.MaskedTextBox TerminationDate;
    }
}