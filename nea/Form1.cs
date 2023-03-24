using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace hospitalgame
{
    public partial class DoctorGame : Form
    {
        public DoctorGame()
        {
            InitializeComponent();
        }

        readonly Patient stabbedMan = new Patient(134, new int[] { 92, 55 }, 24, 77);
        bool started;

        // writes messages to label
        public void Write(string message)
        {
            for (int i = 1; i <= message.Length; i++)
            {
                this.messages.Text = message.Substring(0, i);
                Application.DoEvents();
                //Thread.Sleep(25);
            }
            //Thread.Sleep(2000);
        }


        private void WriteMessages(object sender, WriteMessagesEventArgs e)
        {
            foreach (string message in e.messages)
            {
                Write(message);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(!started) { return; }
            // updates observations
            BodyManager bm = stabbedMan.GetBodyManager();

            bm.UpdateObs();
            int hr = bm.GetHeartRate();
            int rr = bm.GetRespirationRate();
            int sats = bm.GetOxygenSaturation();

            if (hr != -1) { heartRateLbl.Text = "HR: " + hr; }
            int[] bloodPressure = bm.GetBloodPressure();
            if(bloodPressure[0] != -1) { bloodPressureLbl.Text = "BP: " + bloodPressure[0] + "/" + bloodPressure[1]; }

            if (rr != -1) { respirationRateLabel.Text = "RR: " + rr; }
            if(sats != -1) { satsLbl.Text = "SpO2: " + sats; }
        }


        // called on initial start of simulation; plays introduction
        public void StartSim()
        {
            stabbedMan.userInterfacer.WriteMessages += WriteMessages;
            CardiacTamponadeTrauma tamponade = new CardiacTamponadeTrauma(stabbedMan.GetConditionManager());

            Write("You are an emergency medicine consultant, working a shift in the Emergency Department. You receive a trauma alert for a patient being transported to you to arrive in 10 minutes' time, a stabbing with major trauma. No other details are given.");
            Write("A patient is wheeled into A&&E by paramedics. He is bleeding heavily from the chest, and is barely conscious.");
            Write("The paramedic begins to give you a handover. \"This male is 24 years old. Roughly half an hour ago he was stabbed once in the central upper chest with a kitchen knife roughly 6 inches long. Initially conscious and talking, he's been GCS 8 for about 2 minutes. Heart rate 134, blood pressure 92 / 55, respiration rate 24, sats 77%. We've put haemostatic gauze on his stab wound, given 0.5g TXA, began a bag of fluids and transported to hospital.\"");

            started = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartSim();
        }

        private void heartRateLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Heart Rate: How many times in a minute their heart is beating. Usually around 60-100, and anything out of that range is considered bad.", "Heart Rate");
        }

        private void bloodPressureLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blood Pressure: the pressure inside of the arteries of the body. The first number is when the heart beats, and the second number is when it's at rest. The 'textbook' value is 120/80. Low blood pressure can be associated with blood loss.", "Blood Pressure");
        }

        private void satsLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SpO2: the 'peripheral' saturation of oxygen. This is in your fingers or toes. The normal value is above 95%. Anything below in a normally healthy person is an issue, and should be addressed.", "Oxygen Saturation");
        }

        private void respirationRateLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Respiration Rate: how many times in a minute a person breathes. The normal rate for a healthy adult is 12 to 20. If it is less than that, it may be a sign the person is not conscious enough to breath properly. If above that, the person likely has an issue with their breathing, or low blood oxygen.", "Respiration Rate");
        }




        // controls to show various portions of resuscitation trolley
        private void AirwayBtn_Click(object sender, EventArgs e)
        {
            if (AirwayGroupBox.Visible)
            {
                AirwayGroupBox.Hide();
            }
            else
            {
                if(CirculationGroupBox.Visible) { CirculationGroupBox.Hide(); }
                AirwayGroupBox.Show();
            }
        }

        private void BreathingBtn_Click(object sender, EventArgs e)
        {
            if (BreathingGroupBox.Visible)
            {
                BreathingGroupBox.Hide();
            }
            else
            {
                if(DrugsGroupBox.Visible) { DrugsGroupBox.Hide(); }
                BreathingGroupBox.Show();
            }
        }

        private void CirculationBtn_Click(object sender, EventArgs e)
        {
            if(CirculationGroupBox.Visible)
            {
                CirculationGroupBox.Hide();
            }
            else
            {
                if(AirwayGroupBox.Visible) { AirwayGroupBox.Hide(); }
                CirculationGroupBox.Show();
            }
        }


        private void DrugsBtn_Click(object sender, EventArgs e)
        {
            if(DrugsGroupBox.Visible)
            {
                DrugsGroupBox.Hide();
            }
            else
            {
                if(BreathingGroupBox.Visible) { BreathingGroupBox.Hide(); }
                DrugsGroupBox.Show();
            }
        }
        private void OtherBtn_Click(object sender, EventArgs e)
        {
            if(OtherGroupBox.Visible)
            {
                OtherGroupBox.Hide();
            }
            else
            {
                if(AirwayGroupBox.Visible) { AirwayGroupBox.Hide(); }
                if(BreathingGroupBox.Visible) { BreathingGroupBox.Hide(); }
                if(CirculationGroupBox.Visible) { CirculationGroupBox.Hide(); }
                if (DrugsGroupBox.Visible) { DrugsGroupBox.Hide(); }
                OtherGroupBox.Show();
            }
        }












        // buttons for equipment / procedures / drugs

        private void NPABtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("This is a tube that goes into the nose, and reaches the back of the throat. It helps maintain a 'patent' (clear) airway. Often used with OPAs.", "NPA: Nasopharyngeal airway");
            }
            else
            {

            }
        }

        private void OPABtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("This is a tube that goes into the mouth, and reaches the back of the throat. It helps maintain a 'patent' (clear) airway. Often used with NPAs.", "Oropharyngeal airway");
            }
        }

        private void LMABtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("This is a tube that goes into the mouth, and reaches an opening in the airway before the vocal chords, called the 'glottis'. It inflates, and allows a secure airway in the majority of situations.", "Laryngeal mask airway");
            }
        }

        private void SuctionBtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("A portable device which allows the suctioning of fluids out of the airway and mouth, which may otherwise obstruct the airway.", "Suction");
            }
        }

        private void IntubationKitBtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("Intubation involves a small tube (an endotracheal tube, or ETT) that is passed through the mouth and throat into the trachea, the start of the lungs. A balloon is inflated to keep the tube in place, and it allows the most effective oxygen delivery to the patient.", "Intubation kit");
            }
        }

        private void BVMBtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("A BVM, or bag valve mask, is a mask with a self inflating bag attached to it, with tubing to attach to oxygen. If a patient's breathing is outside of the normal ranges, a bag valve mask is used to provide adequate oxygen to the patient.", "Bag valve mask");
            }
        }

        private void OxygenBtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("Oxygen canisters provide pure oxygen to patients when it is clinically necessary. It can be attached to a non-rebreathe mask, or a bag valve mask, as well as to an endotracheal tube and a laryngeal mask airway.", "Oxygen");
            }
        }

        private void NRMBtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("A non-rebreathe mask allows delivery of high-flow oxygen (15L/min) to patients who can breathe by themselves.", "Non-rebreathe mask");
            }
        }

        

        private void FluidsBtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("A solution of water and sodium chloride (salt) at 0.9% concentration. Can be used to address hypovolaemia (", "Fluids");
            }
        }

        private void BloodsBtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("Blood can be given to patients with blood loss to replenish it. It is warmed before it is given, so it doesn't reduce the body's core temperature.", "Bloods");
            }
        }

        private void WoundDressingsBtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("Bandages, gauze, and other products designed to stop or minimise bleeding and stabilise a patient before the bleeding can be definitively stopped with surgery.", "Wound dressings");
            }
        }

        private void TXABtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("A drug which reduces blood loss by stopping the breakdown of substances which cause blood clots. Used frequently in trauma with blood loss.", "Tranexamic acid");
            }
        }

        private void AdrenalineBtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("1mL of 1 in 1,000 parts adrenaline, given intravenously within cardiac arrest to attempt to restart the heart. Indicated immediately if PEA / asystole, and after third shock if VF / VT.", "Adrenaline");
            }
        }

        private void AmiodaroneBtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("Amiodarone is an anti-arrhythmic drug. Given after the third shock when the patient remains in VF / VT at a 300mg dose.", "Amiodarone");
            }
            else
            {
                AmiodaroneBtn.Hide();
            }
        }

        private void ThoracostomyLBtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("A thoracostomy is an incision made under the armpit to access the space between the lungs and the chest wall. When performed, it will relieve any pressure from air or blood pushing on the lung on the left side.", "Thoracostomy");
            }
        }

        private void ThoracostomyRBtn_Click(object sender, EventArgs e)
        {
            if(!started)
            {
                MessageBox.Show("A thoracostomy is an incision made under the armpit to access the space between the lungs and the chest wall. When performed, it will relieve any pressure from air or blood pushing on the lung on the right side.", "Thoracostomy");
            }
            
        }

        private void ThoracotomyBtn_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                MessageBox.Show("A clamshell thoracotomy is performed by extending thoracostomy incisions on either side across the chest, and then cracking the sternum, and spreading the chest to access the heart and other organs. This is only performed if a patient is in cardiac arrest with cardiac tamponade, and is a last resort to save the patient's life.", "Clamshell thoracotomy");
            }
            else
            {
            }
        }

    }
}
