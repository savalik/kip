namespace kip
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PersonnelNumberlLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dayMVPSList = new System.Windows.Forms.ListBox();
            this.OpenMasterForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Работа с базой данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 121);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Установка оборудования на МВПС";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(377, 193);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(196, 24);
            this.CloseFormButton.TabIndex = 2;
            this.CloseFormButton.Text = "Выйти из программы";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пользователь:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.Location = new System.Drawing.Point(116, 7);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(168, 17);
            this.UserLabel.TabIndex = 4;
            this.UserLabel.Text = "Фамилия Имя Отчество";
            // 
            // PersonnelNumberlLabel
            // 
            this.PersonnelNumberlLabel.AutoSize = true;
            this.PersonnelNumberlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonnelNumberlLabel.Location = new System.Drawing.Point(303, 7);
            this.PersonnelNumberlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PersonnelNumberlLabel.Name = "PersonnelNumberlLabel";
            this.PersonnelNumberlLabel.Size = new System.Drawing.Size(80, 17);
            this.PersonnelNumberlLabel.TabIndex = 5;
            this.PersonnelNumberlLabel.Text = "табельный";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionLabel.Location = new System.Drawing.Point(303, 24);
            this.PositionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(78, 17);
            this.PositionLabel.TabIndex = 6;
            this.PositionLabel.Text = "должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сегодня в плане работ:";
            // 
            // dayMVPSList
            // 
            this.dayMVPSList.FormattingEnabled = true;
            this.dayMVPSList.Location = new System.Drawing.Point(12, 80);
            this.dayMVPSList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dayMVPSList.Name = "dayMVPSList";
            this.dayMVPSList.Size = new System.Drawing.Size(122, 134);
            this.dayMVPSList.TabIndex = 8;
            // 
            // OpenMasterForm
            // 
            this.OpenMasterForm.Location = new System.Drawing.Point(377, 80);
            this.OpenMasterForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenMasterForm.Name = "OpenMasterForm";
            this.OpenMasterForm.Size = new System.Drawing.Size(96, 36);
            this.OpenMasterForm.TabIndex = 9;
            this.OpenMasterForm.Text = "Открыть окно мастера";
            this.OpenMasterForm.UseVisualStyleBackColor = true;
            this.OpenMasterForm.Click += new System.EventHandler(this.OpenMasterForm_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 121);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 54);
            this.button3.TabIndex = 10;
            this.button3.Text = "Открыть окно слесаря по ремонту оборудования";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 226);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.OpenMasterForm);
            this.Controls.Add(this.dayMVPSList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.PersonnelNumberlLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Информационная система цеха";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PersonnelNumberlLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox dayMVPSList;
        private System.Windows.Forms.Button OpenMasterForm;
        private System.Windows.Forms.Button button3;
    }
}

