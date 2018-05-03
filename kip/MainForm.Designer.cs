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
            this.SuspendLayout();
            // 
            // ManufacturerButton
            // 
            this.ManufacturerButton.Location = new System.Drawing.Point(478, 12);
            this.ManufacturerButton.Name = "ManufacturerButton";
            this.ManufacturerButton.Size = new System.Drawing.Size(164, 29);
            this.ManufacturerButton.TabIndex = 0;
            this.ManufacturerButton.Text = "Производители";
            this.ManufacturerButton.UseVisualStyleBackColor = true;
            this.ManufacturerButton.Click += new System.EventHandler(this.ManufacturerButton_Click);
            // 
            // EquipmentTypesButton
            // 
            this.EquipmentTypesButton.Location = new System.Drawing.Point(478, 47);
            this.EquipmentTypesButton.Name = "EquipmentTypesButton";
            this.EquipmentTypesButton.Size = new System.Drawing.Size(164, 29);
            this.EquipmentTypesButton.TabIndex = 1;
            this.EquipmentTypesButton.Text = "Типы оборудования";
            this.EquipmentTypesButton.UseVisualStyleBackColor = true;
            this.EquipmentTypesButton.Click += new System.EventHandler(this.EquipmentTypesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 280);
            this.Controls.Add(this.EquipmentTypesButton);
            this.Controls.Add(this.ManufacturerButton);
            this.Name = "MainForm";
            this.Text = "Информационная система цеха";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManufacturerButton;
        private System.Windows.Forms.Button EquipmentTypesButton;
    }
}

