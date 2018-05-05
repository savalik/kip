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
            this.ManufacturerButton = new System.Windows.Forms.Button();
            this.EquipmentTypesButton = new System.Windows.Forms.Button();
            this.Equipment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManufacturerButton
            // 
            this.ManufacturerButton.Location = new System.Drawing.Point(442, 12);
            this.ManufacturerButton.Name = "ManufacturerButton";
            this.ManufacturerButton.Size = new System.Drawing.Size(200, 29);
            this.ManufacturerButton.TabIndex = 0;
            this.ManufacturerButton.Text = "Производители";
            this.ManufacturerButton.UseVisualStyleBackColor = true;
            this.ManufacturerButton.Click += new System.EventHandler(this.ManufacturerButton_Click);
            // 
            // EquipmentTypesButton
            // 
            this.EquipmentTypesButton.Location = new System.Drawing.Point(236, 47);
            this.EquipmentTypesButton.Name = "EquipmentTypesButton";
            this.EquipmentTypesButton.Size = new System.Drawing.Size(200, 29);
            this.EquipmentTypesButton.TabIndex = 1;
            this.EquipmentTypesButton.Text = "Типы оборудования";
            this.EquipmentTypesButton.UseVisualStyleBackColor = true;
            this.EquipmentTypesButton.Click += new System.EventHandler(this.EquipmentTypesButton_Click);
            // 
            // Equipment
            // 
            this.Equipment.Location = new System.Drawing.Point(236, 12);
            this.Equipment.Name = "Equipment";
            this.Equipment.Size = new System.Drawing.Size(200, 29);
            this.Equipment.TabIndex = 2;
            this.Equipment.Text = "Оборудование";
            this.Equipment.UseVisualStyleBackColor = true;
            this.Equipment.Click += new System.EventHandler(this.Equipment_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Типы оборудования (ред.)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Equipment);
            this.Controls.Add(this.EquipmentTypesButton);
            this.Controls.Add(this.ManufacturerButton);
            this.Name = "MainForm";
            this.Text = "Информационная система цеха";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManufacturerButton;
        private System.Windows.Forms.Button EquipmentTypesButton;
        private System.Windows.Forms.Button Equipment;
        private System.Windows.Forms.Button button1;
    }
}

