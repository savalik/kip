namespace kip
{
    partial class MVPSForm
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
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SeriesBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CancesButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RoleBox = new System.Windows.Forms.ComboBox();
            this.RuleList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RuleBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IdBox
            // 
            this.IdBox.Enabled = false;
            this.IdBox.Location = new System.Drawing.Point(30, 50);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(265, 22);
            this.IdBox.TabIndex = 0;
            this.IdBox.Text = "7d75757c-f6ef-445c-b042-6d4e54df4bad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(30, 95);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(98, 22);
            this.NumberBox.TabIndex = 2;
            //this.NumberBox.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            this.NumberBox.LostFocus += new System.EventHandler(this.NumberBox_LostFocus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Серия";
            // 
            // SeriesBox
            // 
            this.SeriesBox.Location = new System.Drawing.Point(30, 140);
            this.SeriesBox.Name = "SeriesBox";
            this.SeriesBox.Size = new System.Drawing.Size(98, 22);
            this.SeriesBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тип";
            // 
            // TypeBox
            // 
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(30, 185);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 24);
            this.TypeBox.TabIndex = 7;
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Роль";
            // 
            // CancesButton
            // 
            this.CancesButton.Location = new System.Drawing.Point(30, 334);
            this.CancesButton.Name = "CancesButton";
            this.CancesButton.Size = new System.Drawing.Size(80, 33);
            this.CancesButton.TabIndex = 9;
            this.CancesButton.Text = "Отмена";
            this.CancesButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(487, 334);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 33);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RoleBox
            // 
            this.RoleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleBox.FormattingEnabled = true;
            this.RoleBox.Location = new System.Drawing.Point(30, 232);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(121, 24);
            this.RoleBox.TabIndex = 11;
            this.RoleBox.SelectedIndexChanged += new System.EventHandler(this.RoleBox_SelectedIndexChanged);
            // 
            // RuleList
            // 
            this.RuleList.FormattingEnabled = true;
            this.RuleList.ItemHeight = 16;
            this.RuleList.Location = new System.Drawing.Point(313, 50);
            this.RuleList.Name = "RuleList";
            this.RuleList.Size = new System.Drawing.Size(254, 260);
            this.RuleList.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Список комплетуемого оборудования";
            // 
            // RuleBox
            // 
            this.RuleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RuleBox.FormattingEnabled = true;
            this.RuleBox.Location = new System.Drawing.Point(30, 279);
            this.RuleBox.Name = "RuleBox";
            this.RuleBox.Size = new System.Drawing.Size(121, 24);
            this.RuleBox.TabIndex = 14;
            this.RuleBox.SelectedIndexChanged += new System.EventHandler(this.RuleBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Правило комлектации";
            // 
            // MVPSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 379);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RuleBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RuleList);
            this.Controls.Add(this.RoleBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancesButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SeriesBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdBox);
            this.Name = "MVPSForm";
            this.Text = "MVPSForm";
            this.Load += new System.EventHandler(this.MVPSForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SeriesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CancesButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox RoleBox;
        private System.Windows.Forms.ListBox RuleList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RuleBox;
        private System.Windows.Forms.Label label7;
    }
}