namespace JoshTBourget.Models.DTOs
{
    public class ChatResponseDto
    {
        private string message = String.Empty;
        private WidgetTriggerDto? trigger;
        private DateTime timeStamp = DateTime.UtcNow;

        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
        public WidgetTriggerDto? Trigger
        {
            get
            {
                return trigger;
            }
            set
            {
                trigger = value;
            }
        }
        public DateTime TimeStamp
        {
            get
            {
                return timeStamp;
            }
            set
            {
                timeStamp = value;
            }
        }
    }
}