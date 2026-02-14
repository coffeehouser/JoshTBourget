namespace JoshTBourget.Models.DTOs
{
    public class ChatMessageDto
    {
        private string sender = string.Empty;
        private string content = string.Empty;
        private DateTime timestamp;

        public string Sender
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
    }
}