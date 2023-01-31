namespace WindowsAppLeroy
{
    partial class WeatherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.SearchBtn = new System.Windows.Forms.Button();
            this.EnterCityBox = new System.Windows.Forms.TextBox();
            this.EnterCityLbl = new System.Windows.Forms.Label();
            this.Degrees = new System.Windows.Forms.Label();
            this.Condition = new System.Windows.Forms.Label();
            this.MinTemp = new System.Windows.Forms.Label();
            this.MaxTemp = new System.Windows.Forms.Label();
            this.HumidityLbl = new System.Windows.Forms.Label();
            this.HumidityVal = new System.Windows.Forms.Label();
            this.WindLbl = new System.Windows.Forms.Label();
            this.WindVal = new System.Windows.Forms.Label();
            this.WeatherIcon = new System.Windows.Forms.PictureBox();
            this.MinLbl = new System.Windows.Forms.Label();
            this.MaxLbl = new System.Windows.Forms.Label();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.FiveDay = new System.Windows.Forms.Label();
            this.ThreeHourCast = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchBtn.Location = new System.Drawing.Point(78, 95);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // EnterCityBox
            // 
            this.EnterCityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterCityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCityBox.Location = new System.Drawing.Point(58, 55);
            this.EnterCityBox.Name = "EnterCityBox";
            this.EnterCityBox.Size = new System.Drawing.Size(129, 22);
            this.EnterCityBox.TabIndex = 2;
            this.EnterCityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EnterCityLbl
            // 
            this.EnterCityLbl.AutoSize = true;
            this.EnterCityLbl.BackColor = System.Drawing.Color.Transparent;
            this.EnterCityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCityLbl.ForeColor = System.Drawing.Color.White;
            this.EnterCityLbl.Location = new System.Drawing.Point(55, 9);
            this.EnterCityLbl.Name = "EnterCityLbl";
            this.EnterCityLbl.Size = new System.Drawing.Size(144, 31);
            this.EnterCityLbl.TabIndex = 3;
            this.EnterCityLbl.Text = "Enter City";
            // 
            // Degrees
            // 
            this.Degrees.AutoSize = true;
            this.Degrees.BackColor = System.Drawing.Color.Transparent;
            this.Degrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Degrees.ForeColor = System.Drawing.Color.White;
            this.Degrees.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Degrees.Location = new System.Drawing.Point(49, 269);
            this.Degrees.Name = "Degrees";
            this.Degrees.Size = new System.Drawing.Size(124, 31);
            this.Degrees.TabIndex = 4;
            this.Degrees.Text = "Degrees";
            // 
            // Condition
            // 
            this.Condition.AutoSize = true;
            this.Condition.BackColor = System.Drawing.Color.Transparent;
            this.Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Condition.ForeColor = System.Drawing.Color.White;
            this.Condition.Location = new System.Drawing.Point(50, 314);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(99, 24);
            this.Condition.TabIndex = 5;
            this.Condition.Text = "Condition";
            // 
            // MinTemp
            // 
            this.MinTemp.AutoSize = true;
            this.MinTemp.BackColor = System.Drawing.Color.Transparent;
            this.MinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinTemp.ForeColor = System.Drawing.Color.White;
            this.MinTemp.Location = new System.Drawing.Point(117, 346);
            this.MinTemp.Name = "MinTemp";
            this.MinTemp.Size = new System.Drawing.Size(45, 24);
            this.MinTemp.TabIndex = 6;
            this.MinTemp.Text = "N/A";
            // 
            // MaxTemp
            // 
            this.MaxTemp.AutoSize = true;
            this.MaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.MaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTemp.ForeColor = System.Drawing.Color.White;
            this.MaxTemp.Location = new System.Drawing.Point(117, 370);
            this.MaxTemp.Name = "MaxTemp";
            this.MaxTemp.Size = new System.Drawing.Size(45, 24);
            this.MaxTemp.TabIndex = 7;
            this.MaxTemp.Text = "N/A";
            // 
            // HumidityLbl
            // 
            this.HumidityLbl.AutoSize = true;
            this.HumidityLbl.BackColor = System.Drawing.Color.Transparent;
            this.HumidityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityLbl.ForeColor = System.Drawing.Color.White;
            this.HumidityLbl.Location = new System.Drawing.Point(50, 400);
            this.HumidityLbl.Name = "HumidityLbl";
            this.HumidityLbl.Size = new System.Drawing.Size(97, 24);
            this.HumidityLbl.TabIndex = 8;
            this.HumidityLbl.Text = "Humidity:";
            // 
            // HumidityVal
            // 
            this.HumidityVal.AutoSize = true;
            this.HumidityVal.BackColor = System.Drawing.Color.Transparent;
            this.HumidityVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumidityVal.ForeColor = System.Drawing.Color.White;
            this.HumidityVal.Location = new System.Drawing.Point(141, 400);
            this.HumidityVal.Name = "HumidityVal";
            this.HumidityVal.Size = new System.Drawing.Size(45, 24);
            this.HumidityVal.TabIndex = 9;
            this.HumidityVal.Text = "N/A";
            // 
            // WindLbl
            // 
            this.WindLbl.AutoSize = true;
            this.WindLbl.BackColor = System.Drawing.Color.Transparent;
            this.WindLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindLbl.ForeColor = System.Drawing.Color.White;
            this.WindLbl.Location = new System.Drawing.Point(51, 427);
            this.WindLbl.Name = "WindLbl";
            this.WindLbl.Size = new System.Drawing.Size(64, 24);
            this.WindLbl.TabIndex = 10;
            this.WindLbl.Text = "Wind:";
            // 
            // WindVal
            // 
            this.WindVal.AutoSize = true;
            this.WindVal.BackColor = System.Drawing.Color.Transparent;
            this.WindVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindVal.ForeColor = System.Drawing.Color.White;
            this.WindVal.Location = new System.Drawing.Point(117, 427);
            this.WindVal.Name = "WindVal";
            this.WindVal.Size = new System.Drawing.Size(45, 24);
            this.WindVal.TabIndex = 11;
            this.WindVal.Text = "N/A";
            // 
            // WeatherIcon
            // 
            this.WeatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.WeatherIcon.Location = new System.Drawing.Point(55, 124);
            this.WeatherIcon.Name = "WeatherIcon";
            this.WeatherIcon.Size = new System.Drawing.Size(132, 118);
            this.WeatherIcon.TabIndex = 12;
            this.WeatherIcon.TabStop = false;
            // 
            // MinLbl
            // 
            this.MinLbl.AutoSize = true;
            this.MinLbl.BackColor = System.Drawing.Color.Transparent;
            this.MinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLbl.ForeColor = System.Drawing.Color.White;
            this.MinLbl.Location = new System.Drawing.Point(50, 346);
            this.MinLbl.Name = "MinLbl";
            this.MinLbl.Size = new System.Drawing.Size(50, 24);
            this.MinLbl.TabIndex = 13;
            this.MinLbl.Text = "Min:";
            // 
            // MaxLbl
            // 
            this.MaxLbl.AutoSize = true;
            this.MaxLbl.BackColor = System.Drawing.Color.Transparent;
            this.MaxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLbl.ForeColor = System.Drawing.Color.White;
            this.MaxLbl.Location = new System.Drawing.Point(51, 370);
            this.MaxLbl.Name = "MaxLbl";
            this.MaxLbl.Size = new System.Drawing.Size(55, 24);
            this.MaxLbl.TabIndex = 14;
            this.MaxLbl.Text = "Max:";
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.BackColor = System.Drawing.Color.Transparent;
            this.FLP.Location = new System.Drawing.Point(277, 124);
            this.FLP.Name = "FLP";
            this.FLP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FLP.Size = new System.Drawing.Size(307, 118);
            this.FLP.TabIndex = 15;
            this.FLP.WrapContents = false;
            // 
            // FiveDay
            // 
            this.FiveDay.AutoSize = true;
            this.FiveDay.BackColor = System.Drawing.Color.Transparent;
            this.FiveDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveDay.ForeColor = System.Drawing.Color.White;
            this.FiveDay.Location = new System.Drawing.Point(271, 15);
            this.FiveDay.Name = "FiveDay";
            this.FiveDay.Size = new System.Drawing.Size(105, 31);
            this.FiveDay.TabIndex = 16;
            this.FiveDay.Text = "5 Days";
            // 
            // ThreeHourCast
            // 
            this.ThreeHourCast.AutoSize = true;
            this.ThreeHourCast.BackColor = System.Drawing.Color.Transparent;
            this.ThreeHourCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeHourCast.ForeColor = System.Drawing.Color.White;
            this.ThreeHourCast.Location = new System.Drawing.Point(272, 43);
            this.ThreeHourCast.Name = "ThreeHourCast";
            this.ThreeHourCast.Size = new System.Drawing.Size(239, 31);
            this.ThreeHourCast.TabIndex = 17;
            this.ThreeHourCast.Text = "3 Hour Forecasts";
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(719, 580);
            this.Controls.Add(this.ThreeHourCast);
            this.Controls.Add(this.FiveDay);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.MaxLbl);
            this.Controls.Add(this.MinLbl);
            this.Controls.Add(this.WeatherIcon);
            this.Controls.Add(this.WindVal);
            this.Controls.Add(this.WindLbl);
            this.Controls.Add(this.HumidityVal);
            this.Controls.Add(this.HumidityLbl);
            this.Controls.Add(this.MaxTemp);
            this.Controls.Add(this.MinTemp);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.Degrees);
            this.Controls.Add(this.EnterCityLbl);
            this.Controls.Add(this.EnterCityBox);
            this.Controls.Add(this.SearchBtn);
            this.Name = "WeatherForm";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox EnterCityBox;
        private System.Windows.Forms.Label EnterCityLbl;
        private System.Windows.Forms.Label Degrees;
        private System.Windows.Forms.Label Condition;
        private System.Windows.Forms.Label MinTemp;
        private System.Windows.Forms.Label MaxTemp;
        private System.Windows.Forms.Label HumidityLbl;
        private System.Windows.Forms.Label HumidityVal;
        private System.Windows.Forms.Label WindLbl;
        private System.Windows.Forms.Label WindVal;
        private System.Windows.Forms.PictureBox WeatherIcon;
        private System.Windows.Forms.Label MinLbl;
        private System.Windows.Forms.Label MaxLbl;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private System.Windows.Forms.Label FiveDay;
        private System.Windows.Forms.Label ThreeHourCast;
    }
}

