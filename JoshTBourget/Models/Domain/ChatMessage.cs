using JoshTBourget.Models.Enums;

namespace JoshTBourget.Models.Domain
{
    public class ChatMessage
    {
        private int id;
        private int chatSessionId;
        private ChatSession chatSession;
        private SenderType sender;
        private string content = string.Empty;
        private DateTime timestamp = DateTime.UtcNow;
        private int? triggeredWidgetId;
        private Widget? triggeredWidget;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int ChatSessionId
        {
            get
            {
                return chatSessionId;
            }
            set
            {
                chatSessionId = value;
            }
        }
        public ChatSession ChatSession
        {
            get
            {
                return chatSession;
            }
            set
            {
                chatSession = value;
            }
        }
        public SenderType Sender
        {
            get
            {
                return sender;
            }
            set
            {
                sender = value;
            }
        }
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        public DateTime Timestamp
        {
            get
            {
                return timestamp;
            }
            set
            {
                timestamp = value;
            }
        }
        public int? TriggeredWidgetId
        {
            get
            {
                return triggeredWidgetId;
            }
            set
            {
                triggeredWidgetId = value;
            }
        }
        public Widget? TriggeredWidget
        {
            get
            {
                return triggeredWidget;
            }
            set
            {
                triggeredWidget = value;
            }
        }
    }
}