﻿using System;
using System.Windows.Forms;

namespace kip
{
    partial class MastersForm
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
            LoginForm.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Выберите состав в левом столбце");
            this.PositionLabel = new System.Windows.Forms.Label();
            this.PersonnelNumberlLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.SheduleListBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowSheduleButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DayMVPSList = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FaultyEquipment = new System.Windows.Forms.Label();
            this.InstalledEquipmentCount = new System.Windows.Forms.Label();
            this.ServiceableEquipmentCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionLabel.Location = new System.Drawing.Point(432, 30);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(102, 20);
            this.PositionLabel.TabIndex = 10;
            this.PositionLabel.Text = "должность";
            // 
            // PersonnelNumberlLabel
            // 
            this.PersonnelNumberlLabel.AutoSize = true;
            this.PersonnelNumberlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonnelNumberlLabel.Location = new System.Drawing.Point(432, 9);
            this.PersonnelNumberlLabel.Name = "PersonnelNumberlLabel";
            this.PersonnelNumberlLabel.Size = new System.Drawing.Size(101, 20);
            this.PersonnelNumberlLabel.TabIndex = 9;
            this.PersonnelNumberlLabel.Text = "табельный";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.Location = new System.Drawing.Point(155, 9);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(212, 20);
            this.UserLabel.TabIndex = 8;
            this.UserLabel.Text = "Фамилия Имя Отчество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пользователь:";
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(681, 409);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(169, 30);
            this.CloseFormButton.TabIndex = 11;
            this.CloseFormButton.Text = "Выйти из программы";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // SheduleListBox
            // 
            this.SheduleListBox.FormattingEnabled = true;
            this.SheduleListBox.Items.AddRange(new object[] {
            "Замены ЭПК-150 КОН",
            "Замены БЭЛ-У БКР-У БИЛ-УТ БИЛ-В БИЛ-В-ПОМ БИЛ-ПОМ",
            "Замены ДПС-У ДДИ",
            "Замены ТСКБМ",
            "Замены Радиостанции",
            "Замены "});
            this.SheduleListBox.Location = new System.Drawing.Point(5, 102);
            this.SheduleListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SheduleListBox.Name = "SheduleListBox";
            this.SheduleListBox.Size = new System.Drawing.Size(311, 24);
            this.SheduleListBox.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "\"MMMM.yyyy\"";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 57);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Выберите месяц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Выберите график";
            // 
            // ShowSheduleButton
            // 
            this.ShowSheduleButton.Location = new System.Drawing.Point(161, 161);
            this.ShowSheduleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowSheduleButton.Name = "ShowSheduleButton";
            this.ShowSheduleButton.Size = new System.Drawing.Size(155, 38);
            this.ShowSheduleButton.TabIndex = 16;
            this.ShowSheduleButton.Text = "Вывести на экран";
            this.ShowSheduleButton.UseVisualStyleBackColor = true;
            this.ShowSheduleButton.Click += new System.EventHandler(this.ShowSheduleButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ShowSheduleButton);
            this.groupBox1.Controls.Add(this.SheduleListBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(16, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(344, 206);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Печать месячных графиков";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.DayMVPSList);
            this.groupBox2.Location = new System.Drawing.Point(365, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(487, 206);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Укомплектованность МВПС проходящих обслуживание сегодня";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Неукомплектованные позиции";
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(205, 57);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(275, 142);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // DayMVPSList
            // 
            this.DayMVPSList.Location = new System.Drawing.Point(5, 37);
            this.DayMVPSList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DayMVPSList.MultiSelect = false;
            this.DayMVPSList.Name = "DayMVPSList";
            this.DayMVPSList.Size = new System.Drawing.Size(193, 162);
            this.DayMVPSList.TabIndex = 0;
            this.DayMVPSList.UseCompatibleStateImageBehavior = false;
            this.DayMVPSList.View = System.Windows.Forms.View.List;
            this.DayMVPSList.SelectedIndexChanged += new System.EventHandler(this.DayMVPSList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FaultyEquipment);
            this.groupBox3.Controls.Add(this.InstalledEquipmentCount);
            this.groupBox3.Controls.Add(this.ServiceableEquipmentCount);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(16, 289);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(344, 123);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Состояние оборудования";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // FaultyEquipment
            // 
            this.FaultyEquipment.AutoSize = true;
            this.FaultyEquipment.Location = new System.Drawing.Point(300, 87);
            this.FaultyEquipment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FaultyEquipment.Name = "FaultyEquipment";
            this.FaultyEquipment.Size = new System.Drawing.Size(17, 17);
            this.FaultyEquipment.TabIndex = 5;
            this.FaultyEquipment.Text = "A";
            // 
            // InstalledEquipmentCount
            // 
            this.InstalledEquipmentCount.AutoSize = true;
            this.InstalledEquipmentCount.Location = new System.Drawing.Point(300, 58);
            this.InstalledEquipmentCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstalledEquipmentCount.Name = "InstalledEquipmentCount";
            this.InstalledEquipmentCount.Size = new System.Drawing.Size(17, 17);
            this.InstalledEquipmentCount.TabIndex = 4;
            this.InstalledEquipmentCount.Text = "A";
            // 
            // ServiceableEquipmentCount
            // 
            this.ServiceableEquipmentCount.AutoSize = true;
            this.ServiceableEquipmentCount.Location = new System.Drawing.Point(300, 25);
            this.ServiceableEquipmentCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceableEquipmentCount.Name = "ServiceableEquipmentCount";
            this.ServiceableEquipmentCount.Size = new System.Drawing.Size(17, 17);
            this.ServiceableEquipmentCount.TabIndex = 3;
            this.ServiceableEquipmentCount.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Неисправное оборудование";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Установленное на МВПС оборудование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ипсравное свободное оборудование";
            // 
            // MastersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.PersonnelNumberlLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MastersForm";
            this.Text = "Информационная система цеха";
            this.Load += new System.EventHandler(this.MastersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label PersonnelNumberlLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.ComboBox SheduleListBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowSheduleButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView DayMVPSList;
        private ListView listView1;
        private Label label4;
        private GroupBox groupBox3;
        private Label ServiceableEquipmentCount;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label FaultyEquipment;
        private Label InstalledEquipmentCount;
    }
}