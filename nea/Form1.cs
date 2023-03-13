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
            stages = this.InitialiseStages();
        }

        int stage = -1;
        List<IntroStage> stages;
        Patient stabbedMan = new Patient("John", "Doe", 24);

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
            List<string> stageOneMessages = new List<string> { "You are an emergency medicine consultant working in A&&E when you receive a trauma alert for a young man who's been stabbed.",
                                                            "5 minutes later, he is wheeled into a resus bay, and the paramedic gives you a handover. \"24 year old male, stabbed once in the central upper chest 15 minutes ago. Initially conscious, he's been in cardiac arrest for two minutes.\"",
                                                            "Monitoring equipment begins to be placed on the patient, as the anaesthetist begins to intubate him, and large-bore cannulas are placed in each arm."};
            Question stageOneQuestion = new Question("Do you want to perform a thoracotomy - cutting open the chest to access the heart?", new List<Globals.Options> { Globals.Options.Yes, Globals.Options.No }, stageOneAction);
            IntroStage stageOne = new IntroStage(stageOneMessages, stageOneQuestion);
            returnList.Add(stageOne);




            return returnList;
        }

        // called on initial start of simulation; plays introduction
        public void StartSim()
        {
            stage = 0;
            startBtn.Visible = false;
            Application.DoEvents();

            IntroStage s = stages[stage];
            s.WriteMessages += IntroStage_WriteMessages;
            s.WriteQuestion += IntroStage_WriteQuestion;
            s.runIntroStage();
        }


        // runs the main game loop. Plays the messages, and then waits for a reply
        private void gameloop()
        {
            stage++;
            IntroStage s = stages[stage];
            s.WriteMessages += IntroStage_WriteMessages;
            s.WriteQuestion += IntroStage_WriteQuestion;
            s.runIntroStage();

        }


        private void IntroStage_WriteMessages(object sender, WriteMessagesEventArgs e)
        {
            foreach (string message in e.messages)
            {
                Write(message);
                Thread.Sleep(2000);
            }
        }

        private void IntroStage_WriteQuestion(object sender, WriteQuestionEventArgs e)
        {
            Write(e.message);
            foreach (Globals.Options option in e.options)
            {
                switch (option)
                {
                    case Globals.Options.Yes:
                        yesBtn.Visible = true;
                        break;
                    case Globals.Options.No:
                        noBtn.Visible = true;
                        break;
                    case Globals.Options.One:
                        oneBtn.Visible = true;
                        break;
                    case Globals.Options.Two:
                        twoBtn.Visible = true;
                        break;
                    case Globals.Options.Three:
                        threeBtn.Visible = true;
                        break;
                    case Globals.Options.Four:
                        fourBtn.Visible = true;
                        break;
                }
            }
            Application.DoEvents();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            StartSim();
        }

        private void handleButtonClick(Globals.Options option)
        {
            Action<Globals.Options> a = stages[stage].getQuestion().getAction();
            a.Invoke(option);
            gameloop();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            handleButtonClick(Globals.Options.Yes);
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            handleButtonClick(Globals.Options.No);
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            handleButtonClick(Globals.Options.One);
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            handleButtonClick(Globals.Options.Two);
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            handleButtonClick(Globals.Options.Three);
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            handleButtonClick(Globals.Options.Four);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // updates observations
            BodyManager bm = stabbedMan.getBodyManager();
            Heart h = bm.getHeart();
            Lungs l = bm.getLungs();

            bm.updateObs();

            int hr = h.getHeartRate();
            int rr = l.getRespirationRate();
            int sats = l.getOxygenSaturation();
            double bloodSugar = bm.getBloodSugar();
            double temp = bm.getTemperature();

            if (hr != -1) { heartRateLbl.Text = "HR: " + hr; }
            int[] bloodPressure = bm.getBloodPressure();
            if(bloodPressure[0] != -1) { bloodPressureLbl.Text = "BP: " + bloodPressure[0] + "/" + bloodPressure[1]; }

            if (rr != -1) { respirationRateLabel.Text = "RR: " + l.getRespirationRate(); }
            if(sats != -1) { satsLbl.Text = "SpO2: " + sats; }

            if(bloodSugar != -1d) { bloodSugarLbl.Text = "BM: " + bloodSugar; }
            if(temp != -1d) { tempLbl.Text = "Temp: " + temp; }
        }
    }
}
