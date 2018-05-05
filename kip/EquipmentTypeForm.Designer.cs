namespace kip
{
    partial class EquipmentTypeForm
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
            this.EquipmentTypeGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EquipmentTypeGridView
            // 
            this.EquipmentTypeGridView.AllowUserToAddRows = false;
            this.EquipmentTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipmentTypeGridView.Location = new System.Drawing.Point(12, 12);
            this.EquipmentTypeGridView.Name = "EquipmentTypeGridView";
            this.EquipmentTypeGridView.RowTemplate.Height = 24;
            this.EquipmentTypeGridView.Size = new System.Drawing.Size(1039, 292);
            this.EquipmentTypeGridView.TabIndex = 0;
            this.EquipmentTypeGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EquipmentTypeGridView_CellMouseClick);
            this.EquipmentTypeGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EquipmentTypeGridView_CellMouseEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(859, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(958, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EquipmentTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EquipmentTypeGridView);
            this.Name = "EquipmentTypeForm";
            this.Text = "EquipmentTypeForm";
            this.Load += new System.EventHandler(this.EquipmentTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.DataGridView EquipmentTypeGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}