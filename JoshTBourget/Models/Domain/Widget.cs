using JoshTBourget.Models.Enums;

namespace JoshTBourget.Models.Domain
{
    public class Widget
    {
        private int id;
        private string name = string.Empty;
        private WidgetType widgetType;
        private string title = string.Empty;
        private string? description;
        private string? imageUrl;
        private string? embedUrl;
        private string? htmlContent;
        private DateTime createdAt = DateTime.UtcNow;
        private List<WidgetTriggerMapping> triggerMappings = new();

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
        public WidgetType WidgetType
        {
            get
            {
                return widgetType;
            }
            set
            {
                widgetType = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string? Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public string? ImageUrl
        {
            get
            {
                return imageUrl;
            }
            set
            {
                imageUrl = value;
            }
        }
        public string? EmbedUrl
        {
            get
            {
                return embedUrl;
            }
            set
            {
                embedUrl = value;
            }
        }
        public string? HtmlContent
        {
            get
            {
                return htmlContent;
            }
            set
            {
                htmlContent = value;
            }
        }
        public DateTime CreatedAt
        {
            get
            {
                return createdAt;
            }
            set
            {
                createdAt = value;
            }
        }
        public List<WidgetTriggerMapping> TriggerMappings
        {
            get
            {
                return triggerMappings;
            }
            set
            {
                triggerMappings = value;
            }
        }
    }
}