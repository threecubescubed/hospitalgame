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
            StartSim();
        }

        readonly Patient stabbedMan = new Patient("John", "Doe", 24);

        // writes messages to label
        public void Write(string message)
        {
            for (int i = 1; i <= message.Length; i++)
            {
                this.messages.Text = message.Substring(0, i);
                Application.DoEvents();
                Thread.Sleep(25);
            }
        }

        /*
        private List<IntroStage> InitialiseStages()
        {
            var returnList = new List<IntroStage>();

            // first stage - intro, thoracotomy decision, begin obs monitoring
            void stageOneAction(Globals.Options option)
            {
                BodyManager bm = stabbedMan.getBodyManager();
                Heart h = bm.getHeart();
                Lungs l = bm.getLungs();

                bm.setTemperature(34.2);
                bm.setBloodSugar(3.4);
                if (option == Globals.Options.Yes)
                {
                    Write("You and your registrar begin to perform a clamshell thoracotomy on the man. You first perform bilateral thoracostomies, which produce bilateral air and blood. You then make the incision across the chest, crack the sternum, and use retractors to hold the chest open.");
                    Write("You lift the pericardium of the heart and cut it, gaining access to the heart. Clots and blood are both present. You manually remove the large blood clots, before suctioning the remaining blood, and examining the heart.");
                    Write("The heart begins beating again, but with a considerably reduced cardiac output. You suture the hole in the ventricle closed, before beginning manual cardiac massage.");

                    h.setHeartRate(34);
                    bm.setHeartRateModifier(0.20);
                    l.setOxygenSaturation(74);
                    bm.setSatsModifier(0.30);
                    l.setRespirationRate(4);
                    bm.setRespRateModifier(0.20);
                    bm.setBloodPressure(86, 54);

                }
                else
                {
                    h.setHeartRate(0);
                    l.setOxygenSaturation(0);
                    l.setRespirationRate(0);
                }

                heartRateLbl.Visible = true;
                bloodPressureLbl.Visible = true;
                satsLbl.Visible = true;
                respirationRateLabel.Visible = true;
                tempLbl.Visible = true;
                bloodSugarLbl.Visible = true;
            }
            
            Question stageOneQuestion = new Question("Do you want to perform a thoracotomy - cutting open the chest to access the heart?", new List<Globals.Options> { Globals.Options.Yes, Globals.Options.No }, stageOneAction);
            IntroStage stageOne = new IntroStage(stageOneMessages, stageOneQuestion);
            returnList.Add(stageOne);




            return returnList;
        }
        */


        // called on initial start of simulation; plays introduction
        public void StartSim()
        {
            // sets up condition manager + cardiac tamponade
            ConditionManager cm = stabbedMan.GetConditionManager();
            cm.WriteMessages += WriteMessages;
            cm.WriteQuestion += WriteQuestion;

            var tamponade = new CardiacTamponade();
            cm.AddCondition(tamponade);

            // writes intro messages, writes patient's symptoms
            List<string> messages = new List<string> { "You are an emergency medicine consultant working in A&&E when you receive a trauma alert for a young man who's been stabbed.",
                                                            "5 minutes later, he is wheeled into a resus bay, and the paramedic gives you a handover. \"24 year old male, stabbed once in the central upper chest 15 minutes ago. Initially conscious, he's been in cardiac arrest for two minutes.\"",
                                                            "Monitoring equipment begins to be placed on the patient, as the anaesthetist begins to intubate him, and large-bore cannulas are placed in each arm."};
            foreach(string message in messages)
            {
                Write(message);
            }
            cm.DisplayVisibleSymptoms();
        }

        private void WriteMessages(object sender, WriteMessagesEventArgs e)
        {
            foreach (string message in e.messages)
            {
                Write(message);
                Thread.Sleep(2000);
            }
        }

        private void WriteQuestion(object sender, WriteQuestionEventArgs e)
        {
            Write(e.message);
            foreach (Globals.Options option in e.options)
            {
                switch (option)
                {
                    case Globals.Options.Yes:
                        YesBtn.Visible = true;
                        break;
                    case Globals.Options.No:
                        NoBtn.Visible = true;
                        break;
                    case Globals.Options.One:
                        OneBtn.Visible = true;
                        break;
                    case Globals.Options.Two:
                        TwoBtn.Visible = true;
                        break;
                    case Globals.Options.Three:
                        ThreeBtn.Visible = true;
                        break;
                    case Globals.Options.Four:
                        FourBtn.Visible = true;
                        break;
                }
            }
            Application.DoEvents();
        }

        public static event EventHandler<ChangeLastButtonPressedEventArgs> ChangeLastOption;
        private void HandleButtonClick(Globals.Options option)
        {
            ChangeLastButtonPressedEventArgs args = new ChangeLastButtonPressedEventArgs()
            {
                LastOption = option
            };
            ChangeLastOption?.Invoke(this, args);
            HideButtons();
        }
        private void HideButtons()
        {
            YesBtn.Visible = false;
            NoBtn.Visible = false;
            OneBtn.Visible = false;
            TwoBtn.Visible = false;
            ThreeBtn.Visible = false;
            FourBtn.Visible = false;
        }
        private void YesBtn_Click(object sender, EventArgs e)
        {
            HandleButtonClick(Globals.Options.Yes);
        }
        private void NoBtn_Click(object sender, EventArgs e)
        {
            HandleButtonClick(Globals.Options.No);
        }
        private void OneBtn_Click(object sender, EventArgs e)
        {
            HandleButtonClick(Globals.Options.One);
        }
        private void TwoBtn_Click(object sender, EventArgs e)
        {
            HandleButtonClick(Globals.Options.Two);
        }
        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            HandleButtonClick(Globals.Options.Three);
        }
        private void FourBtn_Click(object sender, EventArgs e)
        {
            HandleButtonClick(Globals.Options.Four);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // updates observations
            BodyManager bm = stabbedMan.GetBodyManager();

            bm.UpdateObs();
            int hr = bm.GetHeartRate();
            int rr = bm.GetRespirationRate();
            int sats = bm.GetOxygenSaturation();
            double bloodSugar = bm.GetBloodSugar();
            double temp = bm.GetTemperature();

            if (hr != -1) { heartRateLbl.Text = "HR: " + hr; }
            int[] bloodPressure = bm.GetBloodPressure();
            if(bloodPressure[0] != -1) { bloodPressureLbl.Text = "BP: " + bloodPressure[0] + "/" + bloodPressure[1]; }

            if (rr != -1) { respirationRateLabel.Text = "RR: " + respirationRateLabel; }
            if(sats != -1) { satsLbl.Text = "SpO2: " + sats; }

            if(bloodSugar != -1d) { bloodSugarLbl.Text = "BM: " + bloodSugar; }
            if(temp != -1d) { tempLbl.Text = "Temp: " + temp; }
        }
    }
}
