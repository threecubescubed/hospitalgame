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
            this.startBtn = new System.Windows.Forms.Button();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(713, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 40);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // yesBtn
            // 
            this.yesBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesBtn.Location = new System.Drawing.Point(747, 59);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(41, 40);
            this.yesBtn.TabIndex = 2;
            this.yesBtn.Text = "Y";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Visible = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBtn.Location = new System.Drawing.Point(747, 105);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(41, 40);
            this.noBtn.TabIndex = 3;
            this.noBtn.Text = "N";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Visible = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.Location = new System.Drawing.Point(747, 151);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(41, 40);
            this.oneBtn.TabIndex = 4;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Visible = false;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.Location = new System.Drawing.Point(747, 197);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(41, 40);
            this.twoBtn.TabIndex = 5;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Visible = false;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.Location = new System.Drawing.Point(747, 243);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(41, 40);
            this.threeBtn.TabIndex = 6;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Visible = false;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.Location = new System.Drawing.Point(747, 289);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(41, 40);
            this.fourBtn.TabIndex = 7;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Visible = false;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.messages);
            this.Name = "DoctorGame";
            this.Text = "Doctor Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label messages;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label heartRateLbl;
        private System.Windows.Forms.Label bloodPressureLbl;
        private System.Windows.Forms.Label satsLbl;
        private System.Windows.Forms.Label tempLbl;
        private System.Windows.Forms.Label respirationRateLabel;
        private System.Windows.Forms.Label bloodSugarLbl;
    }
}

