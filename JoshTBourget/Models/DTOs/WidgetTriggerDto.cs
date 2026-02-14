using JoshTBourget.Models.Enums;

namespace JoshTBourget.Models.DTOs
{
    public class WidgetTriggerDto
    {
        private int widgetId;
        private WidgetType widgetType;
        private string title = string.Empty;
        private string promptText = string.Empty;

        public int WidgetId
        {
            get
            {
                return widgetId;
            }
            set
            {
                widgetId = value;
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
        public string PromptText
        {
            get
            {
                return promptText;
            }
            set
            {
                promptText = value;
            }
        }
    }
}