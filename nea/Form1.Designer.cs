namespace hospitalgame
{
    partial class DoctorGame
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
            this.components = new System.ComponentModel.Container();
            this.messages = new System.Windows.Forms.Label();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.heartRateLbl = new System.Windows.Forms.Label();
            this.bloodPressureLbl = new System.Windows.Forms.Label();
            this.satsLbl = new System.Windows.Forms.Label();
            this.tempLbl = new System.Windows.Forms.Label();
            this.respirationRateLabel = new System.Windows.Forms.Label();
            this.bloodSugarLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messages
            // 
            this.messages.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messages.Location = new System.Drawing.Point(13, 13);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(694, 316);
            this.messages.TabIndex = 0;
            // 
            // YesBtn
            // 
            this.YesBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesBtn.Location = new System.Drawing.Point(747, 12);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(41, 40);
            this.YesBtn.TabIndex = 2;
            this.YesBtn.Text = "Y";
            this.YesBtn.UseVisualStyleBackColor = true;
            this.YesBtn.Visible = false;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // NoBtn
            // 
            this.NoBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoBtn.Location = new System.Drawing.Point(747, 58);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(41, 40);
            this.NoBtn.TabIndex = 3;
            this.NoBtn.Text = "N";
            this.NoBtn.UseVisualStyleBackColor = true;
            this.NoBtn.Visible = false;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // OneBtn
            // 
            this.OneBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneBtn.Location = new System.Drawing.Point(747, 104);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(41, 40);
            this.OneBtn.TabIndex = 4;
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = true;
            this.OneBtn.Visible = false;
            this.OneBtn.Click += new System.EventHandler(this.OneBtn_Click);
            // 
            // TwoBtn
            // 
            this.TwoBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoBtn.Location = new System.Drawing.Point(747, 150);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(41, 40);
            this.TwoBtn.TabIndex = 5;
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = true;
            this.TwoBtn.Visible = false;
            this.TwoBtn.Click += new System.EventHandler(this.TwoBtn_Click);
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeBtn.Location = new System.Drawing.Point(747, 196);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(41, 40);
            this.ThreeBtn.TabIndex = 6;
            this.ThreeBtn.Text = "3";
            this.ThreeBtn.UseVisualStyleBackColor = true;
            this.ThreeBtn.Visible = false;
            this.ThreeBtn.Click += new System.EventHandler(this.ThreeBtn_Click);
            // 
            // FourBtn
            // 
            this.FourBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourBtn.Location = new System.Drawing.Point(747, 242);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(41, 40);
            this.FourBtn.TabIndex = 7;
            this.FourBtn.Text = "4";
            this.FourBtn.UseVisualStyleBackColor = true;
            this.FourBtn.Visible = false;
            this.FourBtn.Click += new System.EventHandler(this.FourBtn_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 2000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // heartRateLbl
            // 
            this.heartRateLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartRateLbl.Location = new System.Drawing.Point(18, 333);
            this.heartRateLbl.Name = "heartRateLbl";
            this.heartRateLbl.Size = new System.Drawing.Size(94, 23);
            this.heartRateLbl.TabIndex = 8;
            this.heartRateLbl.Text = "HR: 200";
            this.heartRateLbl.Visible = false;
            // 
            // bloodPressureLbl
            // 
            this.bloodPressureLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodPressureLbl.Location = new System.Drawing.Point(18, 356);
            this.bloodPressureLbl.Name = "bloodPressureLbl";
            this.bloodPressureLbl.Size = new System.Drawing.Size(145, 23);
            this.bloodPressureLbl.TabIndex = 9;
            this.bloodPressureLbl.Text = "BP: 200 / 100";
            this.bloodPressureLbl.Visible = false;
            // 
            // satsLbl
            // 
            this.satsLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satsLbl.Location = new System.Drawing.Point(18, 379);
            this.satsLbl.Name = "satsLbl";
            this.satsLbl.Size = new System.Drawing.Size(133, 23);
            this.satsLbl.TabIndex = 10;
            this.satsLbl.Text = "SpO2: 100%";
            this.satsLbl.Visible = false;
            // 
            // tempLbl
            // 
            this.tempLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLbl.Location = new System.Drawing.Point(162, 333);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(140, 23);
            this.tempLbl.TabIndex = 11;
            this.tempLbl.Text = "Temp: 36.7C";
            this.tempLbl.Visible = false;
            // 
            // respirationRateLabel
            // 
            this.respirationRateLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respirationRateLabel.Location = new System.Drawing.Point(18, 402);
            this.respirationRateLabel.Name = "respirationRateLabel";
            this.respirationRateLabel.Size = new System.Drawing.Size(133, 23);
            this.respirationRateLabel.TabIndex = 12;
            this.respirationRateLabel.Text = "RR: 12";
            this.respirationRateLabel.Visible = false;
            // 
            // bloodSugarLbl
            // 
            this.bloodSugarLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodSugarLbl.Location = new System.Drawing.Point(162, 356);
            this.bloodSugarLbl.Name = "bloodSugarLbl";
            this.bloodSugarLbl.Size = new System.Drawing.Size(140, 23);
            this.bloodSugarLbl.TabIndex = 13;
            this.bloodSugarLbl.Text = "BM: 4.6";
            this.bloodSugarLbl.Visible = false;
            // 
            // DoctorGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bloodSugarLbl);
            this.Controls.Add(this.respirationRateLabel);
            this.Controls.Add(this.tempLbl);
            this.Controls.Add(this.satsLbl);
            this.Controls.Add(this.bloodPressureLbl);
            this.Controls.Add(this.heartRateLbl);
            this.Controls.Add(this.FourBtn);
            this.Controls.Add(this.ThreeBtn);
            this.Controls.Add(this.TwoBtn);
            this.Controls.Add(this.OneBtn);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.messages);
            this.Name = "DoctorGame";
            this.Text = "Doctor Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label messages;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button NoBtn;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button TwoBtn;
        private System.Windows.Forms.Button ThreeBtn;
        private System.Windows.Forms.Button FourBtn;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label heartRateLbl;
        private System.Windows.Forms.Label bloodPressureLbl;
        private System.Windows.Forms.Label satsLbl;
        private System.Windows.Forms.Label tempLbl;
        private System.Windows.Forms.Label respirationRateLabel;
        private System.Windows.Forms.Label bloodSugarLbl;
    }
}

