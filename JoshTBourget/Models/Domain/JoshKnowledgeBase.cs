namespace JoshTBourget.Models.Domain
{
    public class JoshKnowledgeBase
    {
        private int id;
        private string category = string.Empty;
        private string topic = string.Empty;
        private string content = string.Empty;
        private string keywords = string.Empty;
        private DateTime lastUpdated = DateTime.UtcNow;

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
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public string Topic
        {
            get
            {
                return topic;
            }
            set
            {
                topic = value;
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
        public string Keywords
        {
            get
            {
                return keywords;
            }
            set
            {
                keywords = value;
            }
        }
        public DateTime LastUpdated
        {
            get
            {
                return lastUpdated;
            }
            set
            {
                lastUpdated = value;
            }
        }
    }
}