namespace kip
{
    partial class ReplacingForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.dayMVPSList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionLabel.Location = new System.Drawing.Point(303, 24);
            this.PositionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(78, 17);
            this.PositionLabel.TabIndex = 10;
            this.PositionLabel.Text = "должность";
            // 
            // PersonnelNumberlLabel
            // 
            this.PersonnelNumberlLabel.AutoSize = true;
            this.PersonnelNumberlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonnelNumberlLabel.Location = new System.Drawing.Point(303, 7);
            this.PersonnelNumberlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PersonnelNumberlLabel.Name = "PersonnelNumberlLabel";
            this.PersonnelNumberlLabel.Size = new System.Drawing.Size(80, 17);
            this.PersonnelNumberlLabel.TabIndex = 9;
            this.PersonnelNumberlLabel.Text = "табельный";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.Location = new System.Drawing.Point(116, 7);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(168, 17);
            this.UserLabel.TabIndex = 8;
            this.UserLabel.Text = "Фамилия Имя Отчество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пользователь:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 82);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 54);
            this.button2.TabIndex = 11;
            this.button2.Text = "Замена оборудования на МВПС";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Location = new System.Drawing.Point(443, 191);
            this.CloseFormButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(130, 24);
            this.CloseFormButton.TabIndex = 12;
            this.CloseFormButton.Text = "Выйти из программы";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            // 
            // dayMVPSList
            // 
            this.dayMVPSList.FormattingEnabled = true;
            this.dayMVPSList.Items.AddRange(new object[] {
            "ТО3 ЭТ2М 143",
            "ТО3 ЭТ2М 141",
            "ТО3 ЭТ2М 137",
            "ТО3 ЭТ2М 139",
            "ТР1 ЭД4М 0496"});
            this.dayMVPSList.Location = new System.Drawing.Point(11, 86);
            this.dayMVPSList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dayMVPSList.Name = "dayMVPSList";
            this.dayMVPSList.Size = new System.Drawing.Size(122, 134);
            this.dayMVPSList.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Сегодня в плане работ:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Открыть график замен на месяц";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ReplacingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 226);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dayMVPSList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.PersonnelNumberlLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReplacingForm";
            this.Text = "Информационная система цеха";
            this.Load += new System.EventHandler(this.ReplacingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label PersonnelNumberlLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.ListBox dayMVPSList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}