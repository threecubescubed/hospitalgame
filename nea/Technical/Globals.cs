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
    }

    public class WriteMessagesEventArgs : EventArgs
    {
        public List<string> messages;
    }

    public class WriteQuestionEventArgs : EventArgs
    {
        public string message;
        public List<Globals.Options> options;
    }

    public class ChangeLastButtonPressedEventArgs : EventArgs
    {
        public Globals.Options LastOption;
    }
}
