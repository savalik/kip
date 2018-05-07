namespace kip
{
    partial class SystemTypeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SystemTypeNameBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SystemTypeDescriptionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Наименование";
            // 
            // SystemTypeNameBox
            // 
            this.SystemTypeNameBox.Location = new System.Drawing.Point(28, 48);
            this.SystemTypeNameBox.Name = "SystemTypeNameBox";
            this.SystemTypeNameBox.Size = new System.Drawing.Size(231, 22);
            this.SystemTypeNameBox.TabIndex = 20;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(183, 215);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 28);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(12, 215);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(87, 28);
            this.CloseButton.TabIndex = 18;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // SystemTypeDescriptionBox
            // 
            this.SystemTypeDescriptionBox.Location = new System.Drawing.Point(28, 101);
            this.SystemTypeDescriptionBox.Multiline = true;
            this.SystemTypeDescriptionBox.Name = "SystemTypeDescriptionBox";
            this.SystemTypeDescriptionBox.Size = new System.Drawing.Size(231, 108);
            this.SystemTypeDescriptionBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Описание";
            // 
            // SystemTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SystemTypeDescriptionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SystemTypeNameBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CloseButton);
            this.Name = "SystemTypeForm";
            this.Text = "SystemTypeForm";
            this.Load += new System.EventHandler(this.SystemTypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SystemTypeNameBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox SystemTypeDescriptionBox;
        private System.Windows.Forms.Label label2;
    }
}