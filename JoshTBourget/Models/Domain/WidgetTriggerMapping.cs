namespace JoshTBourget.Models.Domain
{
    public class WidgetTriggerMapping
    {
        private int id;
        private int widgetId;
        private Widget widget;
        private string intent = string.Empty;
        private string keywords = string.Empty;
        private string promptText = string.Empty;
        private int priority;

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
        public Widget Widget
        {
            get
            {
                return widget;
            }
            set
            {
                widget = value;
            }
        }
        public string Intent
        {
            get
            {
                return intent;
            }
            set
            {
                intent = value;
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
        public int Priority
        {
            get
            {
                return priority;
            }
            set
            {
                priority = value;
            }
        }
    }
}