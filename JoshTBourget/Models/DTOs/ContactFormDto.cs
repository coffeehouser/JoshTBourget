namespace JoshTBourget.Models.DTOs
{
    public class ContactFormDto
    {
        private string name = string.Empty;
        private string email = string.Empty;
        private string message = string.Empty;

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
    }
}