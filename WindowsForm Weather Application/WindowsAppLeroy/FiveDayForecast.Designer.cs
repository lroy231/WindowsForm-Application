namespace WindowsAppLeroy
{
    partial class FiveDayForecast
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PicWeatherIcon = new System.Windows.Forms.PictureBox();
            this.DayLbl = new System.Windows.Forms.Label();
            this.ConditionLbl = new System.Windows.Forms.Label();
            this.Degree5DayLbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DateTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PicWeatherIcon
            // 
            this.PicWeatherIcon.Location = new System.Drawing.Point(14, 3);
            this.PicWeatherIcon.Name = "PicWeatherIcon";
            this.PicWeatherIcon.Size = new System.Drawing.Size(118, 80);
            this.PicWeatherIcon.TabIndex = 0;
            this.PicWeatherIcon.TabStop = false;
            // 
            // DayLbl
            // 
            this.DayLbl.AutoSize = true;
            this.DayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLbl.ForeColor = System.Drawing.Color.White;
            this.DayLbl.Location = new System.Drawing.Point(138, 3);
            this.DayLbl.Name = "DayLbl";
            this.DayLbl.Size = new System.Drawing.Size(40, 20);
            this.DayLbl.TabIndex = 1;
            this.DayLbl.Text = "Day";
            // 
            // ConditionLbl
            // 
            this.ConditionLbl.AutoSize = true;
            this.ConditionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLbl.ForeColor = System.Drawing.Color.White;
            this.ConditionLbl.Location = new System.Drawing.Point(138, 43);
            this.ConditionLbl.Name = "ConditionLbl";
            this.ConditionLbl.Size = new System.Drawing.Size(135, 20);
            this.ConditionLbl.TabIndex = 2;
            this.ConditionLbl.Text = "ConditionOfDay";
            // 
            // Degree5DayLbl
            // 
            this.Degree5DayLbl.AutoSize = true;
            this.Degree5DayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Degree5DayLbl.ForeColor = System.Drawing.Color.White;
            this.Degree5DayLbl.Location = new System.Drawing.Point(138, 63);
            this.Degree5DayLbl.Name = "Degree5DayLbl";
            this.Degree5DayLbl.Size = new System.Drawing.Size(109, 20);
            this.Degree5DayLbl.TabIndex = 3;
            this.Degree5DayLbl.Text = "Degree5Day";
            // 
            // DateTime
            // 
            this.DateTime.AutoSize = true;
            this.DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.ForeColor = System.Drawing.Color.White;
            this.DateTime.Location = new System.Drawing.Point(138, 23);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(86, 20);
            this.DateTime.TabIndex = 4;
            this.DateTime.Text = "Date&Time";
            // 
            // FiveDayForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.Degree5DayLbl);
            this.Controls.Add(this.ConditionLbl);
            this.Controls.Add(this.DayLbl);
            this.Controls.Add(this.PicWeatherIcon);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FiveDayForecast";
            this.Size = new System.Drawing.Size(279, 93);
            ((System.ComponentModel.ISupportInitialize)(this.PicWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox PicWeatherIcon;
        public System.Windows.Forms.Label DayLbl;
        public System.Windows.Forms.Label ConditionLbl;
        public System.Windows.Forms.Label Degree5DayLbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Label DateTime;
    }
}
