using hospitalgame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalgame
{
    public class UserInterfacer
    {
        public event EventHandler<WriteMessagesEventArgs> WriteMessages;

        public void HandleWriteMessages(List<string> _messages)
        {
            WriteMessagesEventArgs wmargs = new WriteMessagesEventArgs()
            {
                messages = _messages
            };
            WriteMessages?.Invoke(this, wmargs);
        }
    }
}
