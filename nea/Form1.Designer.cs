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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorGame));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.heartRateLbl = new System.Windows.Forms.Label();
            this.bloodPressureLbl = new System.Windows.Forms.Label();
            this.satsLbl = new System.Windows.Forms.Label();
            this.respirationRateLabel = new System.Windows.Forms.Label();
            this.resusGroupBox = new System.Windows.Forms.GroupBox();
            this.OtherBtn = new System.Windows.Forms.Button();
            this.DrugsBtn = new System.Windows.Forms.Button();
            this.CirculationBtn = new System.Windows.Forms.Button();
            this.BreathingBtn = new System.Windows.Forms.Button();
            this.AirwayBtn = new System.Windows.Forms.Button();
            this.AirwayGroupBox = new System.Windows.Forms.GroupBox();
            this.IntubationKitBtn = new System.Windows.Forms.Button();
            this.LMABtn = new System.Windows.Forms.Button();
            this.OPABtn = new System.Windows.Forms.Button();
            this.NPABtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.messagesGroupBox = new System.Windows.Forms.GroupBox();
            this.messages = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.BreathingGroupBox = new System.Windows.Forms.GroupBox();
            this.SuctionBtn = new System.Windows.Forms.Button();
            this.NRMBtn = new System.Windows.Forms.Button();
            this.OxygenBtn = new System.Windows.Forms.Button();
            this.BVMBtn = new System.Windows.Forms.Button();
            this.CirculationGroupBox = new System.Windows.Forms.GroupBox();
            this.WoundDressingsBtn = new System.Windows.Forms.Button();
            this.BloodsBtn = new System.Windows.Forms.Button();
            this.FluidsBtn = new System.Windows.Forms.Button();
            this.DrugsGroupBox = new System.Windows.Forms.GroupBox();
            this.AmiodaroneBtn = new System.Windows.Forms.Button();
            this.AdrenalineBtn = new System.Windows.Forms.Button();
            this.TXABtn = new System.Windows.Forms.Button();
            this.OtherGroupBox = new System.Windows.Forms.GroupBox();
            this.ThoracotomyBtn = new System.Windows.Forms.Button();
            this.ThoracostomyRBtn = new System.Windows.Forms.Button();
            this.ThoracostomyLBtn = new System.Windows.Forms.Button();
            this.resusGroupBox.SuspendLayout();
            this.AirwayGroupBox.SuspendLayout();
            this.messagesGroupBox.SuspendLayout();
            this.BreathingGroupBox.SuspendLayout();
            this.CirculationGroupBox.SuspendLayout();
            this.DrugsGroupBox.SuspendLayout();
            this.OtherGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 2000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // heartRateLbl
            // 
            this.heartRateLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartRateLbl.Location = new System.Drawing.Point(12, 333);
            this.heartRateLbl.Name = "heartRateLbl";
            this.heartRateLbl.Size = new System.Drawing.Size(94, 23);
            this.heartRateLbl.TabIndex = 8;
            this.heartRateLbl.Text = "HR:";
            this.heartRateLbl.Click += new System.EventHandler(this.heartRateLbl_Click);
            // 
            // bloodPressureLbl
            // 
            this.bloodPressureLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodPressureLbl.Location = new System.Drawing.Point(12, 356);
            this.bloodPressureLbl.Name = "bloodPressureLbl";
            this.bloodPressureLbl.Size = new System.Drawing.Size(145, 23);
            this.bloodPressureLbl.TabIndex = 9;
            this.bloodPressureLbl.Text = "BP:";
            this.bloodPressureLbl.Click += new System.EventHandler(this.bloodPressureLbl_Click);
            // 
            // satsLbl
            // 
            this.satsLbl.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satsLbl.Location = new System.Drawing.Point(12, 379);
            this.satsLbl.Name = "satsLbl";
            this.satsLbl.Size = new System.Drawing.Size(133, 23);
            this.satsLbl.TabIndex = 10;
            this.satsLbl.Text = "SpO2:";
            this.satsLbl.Click += new System.EventHandler(this.satsLbl_Click);
            // 
            // respirationRateLabel
            // 
            this.respirationRateLabel.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respirationRateLabel.Location = new System.Drawing.Point(12, 402);
            this.respirationRateLabel.Name = "respirationRateLabel";
            this.respirationRateLabel.Size = new System.Drawing.Size(133, 23);
            this.respirationRateLabel.TabIndex = 12;
            this.respirationRateLabel.Text = "RR:";
            this.respirationRateLabel.Click += new System.EventHandler(this.respirationRateLabel_Click);
            // 
            // resusGroupBox
            // 
            this.resusGroupBox.Controls.Add(this.OtherBtn);
            this.resusGroupBox.Controls.Add(this.DrugsBtn);
            this.resusGroupBox.Controls.Add(this.CirculationBtn);
            this.resusGroupBox.Controls.Add(this.BreathingBtn);
            this.resusGroupBox.Controls.Add(this.AirwayBtn);
            this.resusGroupBox.Location = new System.Drawing.Point(12, 451);
            this.resusGroupBox.Name = "resusGroupBox";
            this.resusGroupBox.Size = new System.Drawing.Size(614, 71);
            this.resusGroupBox.TabIndex = 16;
            this.resusGroupBox.TabStop = false;
            // 
            // OtherBtn
            // 
            this.OtherBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherBtn.Location = new System.Drawing.Point(474, 20);
            this.OtherBtn.Name = "OtherBtn";
            this.OtherBtn.Size = new System.Drawing.Size(82, 35);
            this.OtherBtn.TabIndex = 4;
            this.OtherBtn.Text = "Other";
            this.OtherBtn.UseVisualStyleBackColor = true;
            this.OtherBtn.Click += new System.EventHandler(this.OtherBtn_Click);
            // 
            // DrugsBtn
            // 
            this.DrugsBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugsBtn.Location = new System.Drawing.Point(386, 20);
            this.DrugsBtn.Name = "DrugsBtn";
            this.DrugsBtn.Size = new System.Drawing.Size(82, 35);
            this.DrugsBtn.TabIndex = 3;
            this.DrugsBtn.Text = "Drugs";
            this.DrugsBtn.UseVisualStyleBackColor = true;
            this.DrugsBtn.Click += new System.EventHandler(this.DrugsBtn_Click);
            // 
            // CirculationBtn
            // 
            this.CirculationBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CirculationBtn.Location = new System.Drawing.Point(243, 20);
            this.CirculationBtn.Name = "CirculationBtn";
            this.CirculationBtn.Size = new System.Drawing.Size(137, 35);
            this.CirculationBtn.TabIndex = 2;
            this.CirculationBtn.Text = "Circulation";
            this.CirculationBtn.UseVisualStyleBackColor = true;
            this.CirculationBtn.Click += new System.EventHandler(this.CirculationBtn_Click);
            // 
            // BreathingBtn
            // 
            this.BreathingBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreathingBtn.Location = new System.Drawing.Point(114, 20);
            this.BreathingBtn.Name = "BreathingBtn";
            this.BreathingBtn.Size = new System.Drawing.Size(123, 35);
            this.BreathingBtn.TabIndex = 1;
            this.BreathingBtn.Text = "Breathing";
            this.BreathingBtn.UseVisualStyleBackColor = true;
            this.BreathingBtn.Click += new System.EventHandler(this.BreathingBtn_Click);
            // 
            // AirwayBtn
            // 
            this.AirwayBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirwayBtn.Location = new System.Drawing.Point(11, 20);
            this.AirwayBtn.Name = "AirwayBtn";
            this.AirwayBtn.Size = new System.Drawing.Size(97, 35);
            this.AirwayBtn.TabIndex = 0;
            this.AirwayBtn.Text = "Airway";
            this.AirwayBtn.UseVisualStyleBackColor = true;
            this.AirwayBtn.Click += new System.EventHandler(this.AirwayBtn_Click);
            // 
            // AirwayGroupBox
            // 
            this.AirwayGroupBox.Controls.Add(this.IntubationKitBtn);
            this.AirwayGroupBox.Controls.Add(this.LMABtn);
            this.AirwayGroupBox.Controls.Add(this.OPABtn);
            this.AirwayGroupBox.Controls.Add(this.NPABtn);
            this.AirwayGroupBox.Location = new System.Drawing.Point(13, 528);
            this.AirwayGroupBox.Name = "AirwayGroupBox";
            this.AirwayGroupBox.Size = new System.Drawing.Size(302, 110);
            this.AirwayGroupBox.TabIndex = 19;
            this.AirwayGroupBox.TabStop = false;
            this.AirwayGroupBox.Visible = false;
            // 
            // IntubationKitBtn
            // 
            this.IntubationKitBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntubationKitBtn.Location = new System.Drawing.Point(11, 61);
            this.IntubationKitBtn.Name = "IntubationKitBtn";
            this.IntubationKitBtn.Size = new System.Drawing.Size(225, 35);
            this.IntubationKitBtn.TabIndex = 3;
            this.IntubationKitBtn.Text = "Intubation kit";
            this.IntubationKitBtn.UseVisualStyleBackColor = true;
            this.IntubationKitBtn.Click += new System.EventHandler(this.IntubationKitBtn_Click);
            // 
            // LMABtn
            // 
            this.LMABtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMABtn.Location = new System.Drawing.Point(159, 20);
            this.LMABtn.Name = "LMABtn";
            this.LMABtn.Size = new System.Drawing.Size(77, 35);
            this.LMABtn.TabIndex = 2;
            this.LMABtn.Text = "LMA";
            this.LMABtn.UseVisualStyleBackColor = true;
            this.LMABtn.Click += new System.EventHandler(this.LMABtn_Click);
            // 
            // OPABtn
            // 
            this.OPABtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPABtn.Location = new System.Drawing.Point(86, 19);
            this.OPABtn.Name = "OPABtn";
            this.OPABtn.Size = new System.Drawing.Size(67, 35);
            this.OPABtn.TabIndex = 1;
            this.OPABtn.Text = "OPA";
            this.OPABtn.UseVisualStyleBackColor = true;
            this.OPABtn.Click += new System.EventHandler(this.OPABtn_Click);
            // 
            // NPABtn
            // 
            this.NPABtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPABtn.Location = new System.Drawing.Point(11, 20);
            this.NPABtn.Name = "NPABtn";
            this.NPABtn.Size = new System.Drawing.Size(69, 35);
            this.NPABtn.TabIndex = 0;
            this.NPABtn.Text = "NPA";
            this.NPABtn.UseVisualStyleBackColor = true;
            this.NPABtn.Click += new System.EventHandler(this.NPABtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resuscitation trolley";
            // 
            // messagesGroupBox
            // 
            this.messagesGroupBox.Controls.Add(this.messages);
            this.messagesGroupBox.Location = new System.Drawing.Point(13, 13);
            this.messagesGroupBox.Name = "messagesGroupBox";
            this.messagesGroupBox.Size = new System.Drawing.Size(614, 313);
            this.messagesGroupBox.TabIndex = 17;
            this.messagesGroupBox.TabStop = false;
            // 
            // messages
            // 
            this.messages.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messages.Location = new System.Drawing.Point(6, 16);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(602, 278);
            this.messages.TabIndex = 2;
            this.messages.Text = resources.GetString("messages.Text");
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(541, 333);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(86, 40);
            this.StartBtn.TabIndex = 18;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // BreathingGroupBox
            // 
            this.BreathingGroupBox.Controls.Add(this.SuctionBtn);
            this.BreathingGroupBox.Controls.Add(this.NRMBtn);
            this.BreathingGroupBox.Controls.Add(this.OxygenBtn);
            this.BreathingGroupBox.Controls.Add(this.BVMBtn);
            this.BreathingGroupBox.Location = new System.Drawing.Point(321, 528);
            this.BreathingGroupBox.Name = "BreathingGroupBox";
            this.BreathingGroupBox.Size = new System.Drawing.Size(306, 110);
            this.BreathingGroupBox.TabIndex = 20;
            this.BreathingGroupBox.TabStop = false;
            this.BreathingGroupBox.Visible = false;
            // 
            // SuctionBtn
            // 
            this.SuctionBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuctionBtn.Location = new System.Drawing.Point(82, 20);
            this.SuctionBtn.Name = "SuctionBtn";
            this.SuctionBtn.Size = new System.Drawing.Size(116, 35);
            this.SuctionBtn.TabIndex = 4;
            this.SuctionBtn.Text = "Suction";
            this.SuctionBtn.UseVisualStyleBackColor = true;
            this.SuctionBtn.Click += new System.EventHandler(this.SuctionBtn_Click);
            // 
            // NRMBtn
            // 
            this.NRMBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NRMBtn.Location = new System.Drawing.Point(6, 61);
            this.NRMBtn.Name = "NRMBtn";
            this.NRMBtn.Size = new System.Drawing.Size(294, 35);
            this.NRMBtn.TabIndex = 6;
            this.NRMBtn.Text = "Non-rebreathe mask";
            this.NRMBtn.UseVisualStyleBackColor = true;
            this.NRMBtn.Click += new System.EventHandler(this.NRMBtn_Click);
            // 
            // OxygenBtn
            // 
            this.OxygenBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OxygenBtn.Location = new System.Drawing.Point(204, 19);
            this.OxygenBtn.Name = "OxygenBtn";
            this.OxygenBtn.Size = new System.Drawing.Size(97, 35);
            this.OxygenBtn.TabIndex = 5;
            this.OxygenBtn.Text = "Oxygen";
            this.OxygenBtn.UseVisualStyleBackColor = true;
            this.OxygenBtn.Click += new System.EventHandler(this.OxygenBtn_Click);
            // 
            // BVMBtn
            // 
            this.BVMBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVMBtn.Location = new System.Drawing.Point(6, 20);
            this.BVMBtn.Name = "BVMBtn";
            this.BVMBtn.Size = new System.Drawing.Size(70, 35);
            this.BVMBtn.TabIndex = 4;
            this.BVMBtn.Text = "BVM";
            this.BVMBtn.UseVisualStyleBackColor = true;
            this.BVMBtn.Click += new System.EventHandler(this.BVMBtn_Click);
            // 
            // CirculationGroupBox
            // 
            this.CirculationGroupBox.Controls.Add(this.WoundDressingsBtn);
            this.CirculationGroupBox.Controls.Add(this.BloodsBtn);
            this.CirculationGroupBox.Controls.Add(this.FluidsBtn);
            this.CirculationGroupBox.Location = new System.Drawing.Point(13, 528);
            this.CirculationGroupBox.Name = "CirculationGroupBox";
            this.CirculationGroupBox.Size = new System.Drawing.Size(214, 110);
            this.CirculationGroupBox.TabIndex = 3;
            this.CirculationGroupBox.TabStop = false;
            this.CirculationGroupBox.Visible = false;
            // 
            // WoundDressingsBtn
            // 
            this.WoundDressingsBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WoundDressingsBtn.Location = new System.Drawing.Point(6, 61);
            this.WoundDressingsBtn.Name = "WoundDressingsBtn";
            this.WoundDressingsBtn.Size = new System.Drawing.Size(200, 35);
            this.WoundDressingsBtn.TabIndex = 7;
            this.WoundDressingsBtn.Text = "Wound dressings";
            this.WoundDressingsBtn.UseVisualStyleBackColor = true;
            this.WoundDressingsBtn.Click += new System.EventHandler(this.WoundDressingsBtn_Click);
            // 
            // BloodsBtn
            // 
            this.BloodsBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodsBtn.Location = new System.Drawing.Point(109, 20);
            this.BloodsBtn.Name = "BloodsBtn";
            this.BloodsBtn.Size = new System.Drawing.Size(97, 35);
            this.BloodsBtn.TabIndex = 6;
            this.BloodsBtn.Text = "Bloods";
            this.BloodsBtn.UseVisualStyleBackColor = true;
            this.BloodsBtn.Click += new System.EventHandler(this.BloodsBtn_Click);
            // 
            // FluidsBtn
            // 
            this.FluidsBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FluidsBtn.Location = new System.Drawing.Point(6, 19);
            this.FluidsBtn.Name = "FluidsBtn";
            this.FluidsBtn.Size = new System.Drawing.Size(97, 35);
            this.FluidsBtn.TabIndex = 5;
            this.FluidsBtn.Text = "Fluids";
            this.FluidsBtn.UseVisualStyleBackColor = true;
            this.FluidsBtn.Click += new System.EventHandler(this.FluidsBtn_Click);
            // 
            // DrugsGroupBox
            // 
            this.DrugsGroupBox.Controls.Add(this.AmiodaroneBtn);
            this.DrugsGroupBox.Controls.Add(this.AdrenalineBtn);
            this.DrugsGroupBox.Controls.Add(this.TXABtn);
            this.DrugsGroupBox.Location = new System.Drawing.Point(390, 528);
            this.DrugsGroupBox.Name = "DrugsGroupBox";
            this.DrugsGroupBox.Size = new System.Drawing.Size(237, 110);
            this.DrugsGroupBox.TabIndex = 21;
            this.DrugsGroupBox.TabStop = false;
            this.DrugsGroupBox.Visible = false;
            // 
            // AmiodaroneBtn
            // 
            this.AmiodaroneBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmiodaroneBtn.Location = new System.Drawing.Point(6, 61);
            this.AmiodaroneBtn.Name = "AmiodaroneBtn";
            this.AmiodaroneBtn.Size = new System.Drawing.Size(220, 35);
            this.AmiodaroneBtn.TabIndex = 7;
            this.AmiodaroneBtn.Text = "Amiodarone";
            this.AmiodaroneBtn.UseVisualStyleBackColor = true;
            this.AmiodaroneBtn.Click += new System.EventHandler(this.AmiodaroneBtn_Click);
            // 
            // AdrenalineBtn
            // 
            this.AdrenalineBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdrenalineBtn.Location = new System.Drawing.Point(87, 20);
            this.AdrenalineBtn.Name = "AdrenalineBtn";
            this.AdrenalineBtn.Size = new System.Drawing.Size(139, 35);
            this.AdrenalineBtn.TabIndex = 6;
            this.AdrenalineBtn.Text = "Adrenaline";
            this.AdrenalineBtn.UseVisualStyleBackColor = true;
            this.AdrenalineBtn.Click += new System.EventHandler(this.AdrenalineBtn_Click);
            // 
            // TXABtn
            // 
            this.TXABtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXABtn.Location = new System.Drawing.Point(7, 20);
            this.TXABtn.Name = "TXABtn";
            this.TXABtn.Size = new System.Drawing.Size(74, 35);
            this.TXABtn.TabIndex = 5;
            this.TXABtn.Text = "TXA";
            this.TXABtn.UseVisualStyleBackColor = true;
            this.TXABtn.Click += new System.EventHandler(this.TXABtn_Click);
            // 
            // OtherGroupBox
            // 
            this.OtherGroupBox.Controls.Add(this.ThoracotomyBtn);
            this.OtherGroupBox.Controls.Add(this.ThoracostomyRBtn);
            this.OtherGroupBox.Controls.Add(this.ThoracostomyLBtn);
            this.OtherGroupBox.Location = new System.Drawing.Point(12, 528);
            this.OtherGroupBox.Name = "OtherGroupBox";
            this.OtherGroupBox.Size = new System.Drawing.Size(495, 100);
            this.OtherGroupBox.TabIndex = 22;
            this.OtherGroupBox.TabStop = false;
            this.OtherGroupBox.Visible = false;
            // 
            // ThoracotomyBtn
            // 
            this.ThoracotomyBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoracotomyBtn.Location = new System.Drawing.Point(221, 19);
            this.ThoracotomyBtn.Name = "ThoracotomyBtn";
            this.ThoracotomyBtn.Size = new System.Drawing.Size(261, 35);
            this.ThoracotomyBtn.TabIndex = 7;
            this.ThoracotomyBtn.Text = "Clamshell Thoracotomy";
            this.ThoracotomyBtn.UseVisualStyleBackColor = true;
            this.ThoracotomyBtn.Click += new System.EventHandler(this.ThoracotomyBtn_Click);
            // 
            // ThoracostomyRBtn
            // 
            this.ThoracostomyRBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoracostomyRBtn.Location = new System.Drawing.Point(7, 60);
            this.ThoracostomyRBtn.Name = "ThoracostomyRBtn";
            this.ThoracostomyRBtn.Size = new System.Drawing.Size(209, 35);
            this.ThoracostomyRBtn.TabIndex = 6;
            this.ThoracostomyRBtn.Text = "Thoracostomy (R)";
            this.ThoracostomyRBtn.UseVisualStyleBackColor = true;
            this.ThoracostomyRBtn.Click += new System.EventHandler(this.ThoracostomyRBtn_Click);
            // 
            // ThoracostomyLBtn
            // 
            this.ThoracostomyLBtn.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoracostomyLBtn.Location = new System.Drawing.Point(6, 20);
            this.ThoracostomyLBtn.Name = "ThoracostomyLBtn";
            this.ThoracostomyLBtn.Size = new System.Drawing.Size(209, 35);
            this.ThoracostomyLBtn.TabIndex = 5;
            this.ThoracostomyLBtn.Text = "Thoracostomy (L)";
            this.ThoracostomyLBtn.UseVisualStyleBackColor = true;
            this.ThoracostomyLBtn.Click += new System.EventHandler(this.ThoracostomyLBtn_Click);
            // 
            // DoctorGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 645);
            this.Controls.Add(this.OtherGroupBox);
            this.Controls.Add(this.DrugsGroupBox);
            this.Controls.Add(this.CirculationGroupBox);
            this.Controls.Add(this.BreathingGroupBox);
            this.Controls.Add(this.AirwayGroupBox);
            this.Controls.Add(this.resusGroupBox);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messagesGroupBox);
            this.Controls.Add(this.respirationRateLabel);
            this.Controls.Add(this.satsLbl);
            this.Controls.Add(this.bloodPressureLbl);
            this.Controls.Add(this.heartRateLbl);
            this.Name = "DoctorGame";
            this.Text = "Doctor Game";
            this.resusGroupBox.ResumeLayout(false);
            this.AirwayGroupBox.ResumeLayout(false);
            this.messagesGroupBox.ResumeLayout(false);
            this.BreathingGroupBox.ResumeLayout(false);
            this.CirculationGroupBox.ResumeLayout(false);
            this.DrugsGroupBox.ResumeLayout(false);
            this.OtherGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label heartRateLbl;
        private System.Windows.Forms.Label bloodPressureLbl;
        private System.Windows.Forms.Label satsLbl;
        private System.Windows.Forms.Label respirationRateLabel;
        private System.Windows.Forms.GroupBox resusGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DrugsBtn;
        private System.Windows.Forms.Button CirculationBtn;
        private System.Windows.Forms.Button BreathingBtn;
        private System.Windows.Forms.Button AirwayBtn;
        private System.Windows.Forms.GroupBox messagesGroupBox;
        private System.Windows.Forms.Label messages;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button OtherBtn;
        private System.Windows.Forms.GroupBox AirwayGroupBox;
        private System.Windows.Forms.Button NPABtn;
        private System.Windows.Forms.Button IntubationKitBtn;
        private System.Windows.Forms.Button OPABtn;
        private System.Windows.Forms.GroupBox BreathingGroupBox;
        private System.Windows.Forms.Button NRMBtn;
        private System.Windows.Forms.Button OxygenBtn;
        private System.Windows.Forms.Button BVMBtn;
        private System.Windows.Forms.Button SuctionBtn;
        private System.Windows.Forms.Button LMABtn;
        private System.Windows.Forms.GroupBox CirculationGroupBox;
        private System.Windows.Forms.Button FluidsBtn;
        private System.Windows.Forms.Button WoundDressingsBtn;
        private System.Windows.Forms.Button BloodsBtn;
        private System.Windows.Forms.GroupBox DrugsGroupBox;
        private System.Windows.Forms.Button TXABtn;
        private System.Windows.Forms.Button AdrenalineBtn;
        private System.Windows.Forms.Button AmiodaroneBtn;
        private System.Windows.Forms.GroupBox OtherGroupBox;
        private System.Windows.Forms.Button ThoracotomyBtn;
        private System.Windows.Forms.Button ThoracostomyRBtn;
        private System.Windows.Forms.Button ThoracostomyLBtn;
    }
}

