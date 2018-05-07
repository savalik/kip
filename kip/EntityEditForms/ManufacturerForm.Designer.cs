namespace kip
{
    partial class ManufacturerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.ManufacturerAddressBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ManufacturerNameBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ManufacturerPhoneBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ManufacturerEmailBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Адрес";
            // 
            // ManufacturerAddressBox
            // 
            this.ManufacturerAddressBox.Location = new System.Drawing.Point(28, 93);
            this.ManufacturerAddressBox.Multiline = true;
            this.ManufacturerAddressBox.Name = "ManufacturerAddressBox";
            this.ManufacturerAddressBox.Size = new System.Drawing.Size(231, 108);
            this.ManufacturerAddressBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Название";
            // 
            // ManufacturerNameBox
            // 
            this.ManufacturerNameBox.Location = new System.Drawing.Point(28, 40);
            this.ManufacturerNameBox.Name = "ManufacturerNameBox";
            this.ManufacturerNameBox.Size = new System.Drawing.Size(231, 22);
            this.ManufacturerNameBox.TabIndex = 26;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(181, 343);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 28);
            this.AddButton.TabIndex = 25;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(10, 343);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(87, 28);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Телефон";
            // 
            // ManufacturerPhoneBox
            // 
            this.ManufacturerPhoneBox.Location = new System.Drawing.Point(28, 227);
            this.ManufacturerPhoneBox.Name = "ManufacturerPhoneBox";
            this.ManufacturerPhoneBox.Size = new System.Drawing.Size(231, 22);
            this.ManufacturerPhoneBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "E-mail";
            // 
            // ManufacturerEmailBox
            // 
            this.ManufacturerEmailBox.Location = new System.Drawing.Point(28, 269);
            this.ManufacturerEmailBox.Name = "ManufacturerEmailBox";
            this.ManufacturerEmailBox.Size = new System.Drawing.Size(231, 22);
            this.ManufacturerEmailBox.TabIndex = 32;
            // 
            // ManufacturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 383);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ManufacturerEmailBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ManufacturerPhoneBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManufacturerAddressBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManufacturerNameBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CloseButton);
            this.Name = "ManufacturerForm";
            this.Text = "ManufacturerForm";
            this.Load += new System.EventHandler(this.ManufacturerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ManufacturerAddressBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ManufacturerNameBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ManufacturerPhoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ManufacturerEmailBox;
    }
}