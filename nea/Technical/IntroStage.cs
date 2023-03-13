using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalgame
{
    class IntroStage
    {
        private List<string> messages;
        private Question q;

        public IntroStage(List<string> _messages, Question _q)
        {
            messages = _messages;
            q = _q;
        }
        public void runIntroStage()
        {
            OnWriteMessages();
            OnWriteQuestion();
        }

        public Question getQuestion() { return q; }

        private void OnWriteMessages()
        {
            WriteMessagesEventArgs wmargs = new WriteMessagesEventArgs();
            wmargs.messages = this.messages;
            WriteMessages?.Invoke(this, wmargs);
        }

        private void OnWriteQuestion()
        {
            WriteQuestionEventArgs wqargs = new WriteQuestionEventArgs();
            wqargs.message = this.q.getQuestion();
            wqargs.options = this.q.getQuestionOptions();
            WriteQuestion?.Invoke(this, wqargs);
        }

        public event EventHandler<WriteMessagesEventArgs> WriteMessages;
        public event EventHandler<WriteQuestionEventArgs> WriteQuestion;

    }
}
