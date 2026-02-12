namespace JoshTBourget.Models.Domain
{
    public class ChatSession
    {
        private int id;
        private string sessionToken = string.Empty;
        private DateTime startedAt = DateTime.UtcNow;
        private List<ChatMessage> messages = new();

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
        public string SessionToken
        {
            get
            {
                return sessionToken;
            }
            set
            {
                sessionToken = value;
            }
        }
        public DateTime StartedAt
        {
            get
            {
                return startedAt;
            }
            set
            {
                startedAt = value;
            }
        }
        public List<ChatMessage> Messages
        {
            get
            {
                return messages;
            }
            set
            {
                messages = value;
            }
        }
    }
}