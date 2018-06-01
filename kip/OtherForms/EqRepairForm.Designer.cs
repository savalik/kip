namespace kip
{
    partial class EqRepairForm
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
            this.PositionLabel = new System.Windows.Forms.Label();
            this.PersonnelNumberlLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.EquipmentTypes = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.NotWorkedList = new System.Windows.Forms.ListView();
            this.InRepair = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionLabel.Location = new System.Drawing.Point(404, 30);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(102, 20);
            this.PositionLabel.TabIndex = 10;
            this.PositionLabel.Text = "должность";
            // 
            // PersonnelNumberlLabel
            // 
            this.PersonnelNumberlLabel.AutoSize = true;
            this.PersonnelNumberlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonnelNumberlLabel.Location = new System.Drawing.Point(404, 9);
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
            this.CloseFormButton.Location = new System.Drawing.Point(547, 399);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(220, 30);
            this.CloseFormButton.TabIndex = 11;
            this.CloseFormButton.Text = "Выйти из программы";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            // 
            // EquipmentTypes
            // 
            this.EquipmentTypes.Location = new System.Drawing.Point(12, 94);
            this.EquipmentTypes.Name = "EquipmentTypes";
            this.EquipmentTypes.Size = new System.Drawing.Size(268, 207);
            this.EquipmentTypes.TabIndex = 12;
            this.EquipmentTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.EquipmentTypes_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Классификатор:";
            // 
            // NotWorkedList
            // 
            this.NotWorkedList.Location = new System.Drawing.Point(286, 94);
            this.NotWorkedList.Name = "NotWorkedList";
            this.NotWorkedList.Size = new System.Drawing.Size(219, 207);
            this.NotWorkedList.TabIndex = 14;
            this.NotWorkedList.UseCompatibleStateImageBehavior = false;
            this.NotWorkedList.View = System.Windows.Forms.View.List;
            this.NotWorkedList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotWorkedList_MouseDoubleClick);
            // 
            // InRepair
            // 
            this.InRepair.Location = new System.Drawing.Point(547, 94);
            this.InRepair.Name = "InRepair";
            this.InRepair.Size = new System.Drawing.Size(220, 207);
            this.InRepair.TabIndex = 15;
            this.InRepair.UseCompatibleStateImageBehavior = false;
            this.InRepair.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(286, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Оборудование:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(543, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Взятое в ремонт/проверку";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(511, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "=>";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 71);
            this.button1.TabIndex = 19;
            this.button1.Text = "Произвести ремонт";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 324);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 71);
            this.button2.TabIndex = 20;
            this.button2.Text = "Произвести проверку";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Комментарий:";
            // 
            // EqRepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 441);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InRepair);
            this.Controls.Add(this.NotWorkedList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EquipmentTypes);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.PersonnelNumberlLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EqRepairForm";
            this.Text = "Информационная система цеха";
            this.Load += new System.EventHandler(this.EqRepairForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label PersonnelNumberlLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.TreeView EquipmentTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView NotWorkedList;
        private System.Windows.Forms.ListView InRepair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}