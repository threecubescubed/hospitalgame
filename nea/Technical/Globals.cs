using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalgame
{
    public class Globals
    {
        public enum Options
        {
            Yes,
            No,
            One,
            Two,
            Three,
            Four
        }

        public enum Conditions
        {
            // Heart / circulation system
            Tamponade,
            Hypovolaemia,


            // Lungs / respiratory system
            Pneumothorax,
            Haemothorax,
            Pneumohaemothorax
        }
    }
    class WriteMessagesEventArgs : EventArgs
    {
        public List<string> messages { get; set; }
    }

    public class WriteQuestionEventArgs : EventArgs
    {
        public string message { get; set; }
        public List<Globals.Options> options { get; set; }
    }
}
