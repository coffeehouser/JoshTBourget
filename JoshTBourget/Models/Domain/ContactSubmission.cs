namespace JoshTBourget.Models.Domain
{
    public class ContactSubmission
    {
        private int id;
        private string name = string.Empty;
        private string email = string.Empty;
        private string message = string.Empty;
        private DateTime submittedAt = DateTime.UtcNow;

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
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
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
        public DateTime SubmittedAt
        {
            get
            {
                return submittedAt;
            }
            set
            {
                submittedAt = value;
            }
        }
   }
}