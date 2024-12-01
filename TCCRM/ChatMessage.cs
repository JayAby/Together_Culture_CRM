using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCRM
{
    public class ChatMessage
    {
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string SenderName { get; set; }
        public string MessageContent { get; set; }
        public DateTime SentTime { get; set; }
    }
}
