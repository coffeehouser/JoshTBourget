using JoshTBourget.Models.Enums;

namespace JoshTBourget.Models.DTOs
{
    public class WidgetDto
    {
        private int id;
        private WidgetType widgetType;
        private string title = string.Empty;
        private string? description;
        private string? imageUrl;
        private string? embedUrl;
        private string? htmlContent;

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
    }
}