﻿namespace kip
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
            this.OpenEqRepairFormButton = new System.Windows.Forms.Button();
            this.openReplacingForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Работа с базой данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 149);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Установка оборудования на МВПС";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(503, 238);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(261, 30);
            this.CloseFormButton.TabIndex = 2;
            this.CloseFormButton.Text = "Выйти из программы";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пользователь:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.Location = new System.Drawing.Point(155, 9);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(212, 20);
            this.UserLabel.TabIndex = 4;
            this.UserLabel.Text = "Фамилия Имя Отчество";
            // 
            // PersonnelNumberlLabel
            // 
            this.PersonnelNumberlLabel.AutoSize = true;
            this.PersonnelNumberlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonnelNumberlLabel.Location = new System.Drawing.Point(404, 9);
            this.PersonnelNumberlLabel.Name = "PersonnelNumberlLabel";
            this.PersonnelNumberlLabel.Size = new System.Drawing.Size(101, 20);
            this.PersonnelNumberlLabel.TabIndex = 5;
            this.PersonnelNumberlLabel.Text = "табельный";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionLabel.Location = new System.Drawing.Point(404, 30);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(102, 20);
            this.PositionLabel.TabIndex = 6;
            this.PositionLabel.Text = "должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сегодня в плане работ:";
            // 
            // dayMVPSList
            // 
            this.dayMVPSList.FormattingEnabled = true;
            this.dayMVPSList.ItemHeight = 16;
            this.dayMVPSList.Location = new System.Drawing.Point(16, 98);
            this.dayMVPSList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dayMVPSList.Name = "dayMVPSList";
            this.dayMVPSList.Size = new System.Drawing.Size(161, 164);
            this.dayMVPSList.TabIndex = 8;
            // 
            // OpenMasterForm
            // 
            this.OpenMasterForm.Location = new System.Drawing.Point(503, 98);
            this.OpenMasterForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenMasterForm.Name = "OpenMasterForm";
            this.OpenMasterForm.Size = new System.Drawing.Size(128, 44);
            this.OpenMasterForm.TabIndex = 9;
            this.OpenMasterForm.Text = "Открыть окно мастера";
            this.OpenMasterForm.UseVisualStyleBackColor = true;
            this.OpenMasterForm.Click += new System.EventHandler(this.OpenMasterForm_Click);
            // 
            // OpenEqRepairFormButton
            // 
            this.OpenEqRepairFormButton.Location = new System.Drawing.Point(503, 149);
            this.OpenEqRepairFormButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenEqRepairFormButton.Name = "OpenEqRepairFormButton";
            this.OpenEqRepairFormButton.Size = new System.Drawing.Size(128, 66);
            this.OpenEqRepairFormButton.TabIndex = 10;
            this.OpenEqRepairFormButton.Text = "Открыть окно слесаря по ремонту оборудования";
            this.OpenEqRepairFormButton.UseVisualStyleBackColor = true;
            this.OpenEqRepairFormButton.Click += new System.EventHandler(this.OpenEqRepairFormButton_Click);
            // 
            // openReplacingForm
            // 
            this.openReplacingForm.Location = new System.Drawing.Point(369, 149);
            this.openReplacingForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openReplacingForm.Name = "openReplacingForm";
            this.openReplacingForm.Size = new System.Drawing.Size(128, 66);
            this.openReplacingForm.TabIndex = 11;
            this.openReplacingForm.Text = "Открыть окно слесаря РПС";
            this.openReplacingForm.UseVisualStyleBackColor = true;
            this.openReplacingForm.Click += new System.EventHandler(this.openReplacingForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 278);
            this.Controls.Add(this.openReplacingForm);
            this.Controls.Add(this.OpenEqRepairFormButton);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button OpenEqRepairFormButton;
        private System.Windows.Forms.Button openReplacingForm;
    }
}

