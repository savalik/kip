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
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EquipmentTypeGridView
            // 
            this.EquipmentTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipmentTypeGridView.Location = new System.Drawing.Point(12, 134);
            this.EquipmentTypeGridView.Name = "EquipmentTypeGridView";
            this.EquipmentTypeGridView.RowTemplate.Height = 24;
            this.EquipmentTypeGridView.Size = new System.Drawing.Size(620, 150);
            this.EquipmentTypeGridView.TabIndex = 0;
            this.EquipmentTypeGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(EquipmentTypeGridView_CellMouseEnter);
            this.EquipmentTypeGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(EquipmentTypeGridView_CellMouseClick);
            // 
            // EquipmentTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 361);
            this.Controls.Add(this.EquipmentTypeGridView);
            this.Name = "EquipmentTypeForm";
            this.Text = "EquipmentTypeForm";
            this.Load += new System.EventHandler(this.EquipmentTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.DataGridView EquipmentTypeGridView;
    }
}