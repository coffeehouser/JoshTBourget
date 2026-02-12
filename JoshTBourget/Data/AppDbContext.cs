using Microsoft.EntityFrameworkCore;
using JoshTBourget.Models.Domain;

namespace JoshTBourget.Data
{
    public class AppDbContext : DbContext
    {
        private DbSet<ChatSession> chatSessions;
        private DbSet<ChatMessage> chatMessages;
        private DbSet<Widget> widgets;
        private DbSet<WidgetTriggerMapping> widgetTriggerMappings;
        private DbSet<ContactSubmission> contactSubmissions;
        private DbSet<JoshKnowledgeBase> joshKnowledgeBase;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ChatSession> ChatSessions
        {
            get
            {
                return chatSessions;
            }
            set
            {
                chatSessions = value;
            }
        }
        public DbSet<ChatMessage> ChatMessages
        {
            get
            {
                return chatMessages;
            }
            set
            {
                chatMessages = value;
            }
        }
        public DbSet<Widget> Widgets
        {
            get
            {
                return widgets;
            }
            set
            {
                widgets = value;
            }
        }
        public DbSet<WidgetTriggerMapping> WidgetTriggerMappings
        {
            get
            {
                return widgetTriggerMappings;
            }
            set
            {
                widgetTriggerMappings = value;
            }
        }
        public DbSet<ContactSubmission> ContactSubmissions
        {
            get
            {
                return contactSubmissions;
            }
            set
            {
                contactSubmissions = value;
            }
        }
        public DbSet<JoshKnowledgeBase> JoshKnowledgeBase
        {
            get
            {
                return joshKnowledgeBase;
            }
            set
            {
                joshKnowledgeBase = value;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ChatMessage>()
                .HasOne(m => m.ChatSession)
                .WithMany(s => s.Messages)
                .HasForeignKey(m => m.ChatSessionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChatMessage>()
                .HasOne(m => m.TriggeredWidget)
                .WithMany()
                .HasForeignKey(m => m.TriggeredWidgetId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<WidgetTriggerMapping>()
                .HasOne(t => t.Widget)
                .WithMany(w => w.TriggerMappings)
                .HasForeignKey(t => t.WidgetId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChatSession>()
                .HasIndex(s => s.SessionToken)
                .IsUnique();

            modelBuilder.Entity<JoshKnowledgeBase>()
                .HasIndex(k => k.Category);

            modelBuilder.Entity<ChatMessage>()
                .Property(m => m.Sender)
                .HasConversion<string>();

            modelBuilder.Entity<Widget>()
                .Property(w => w.WidgetType)
                .HasConversion<string>();
        }
    }
}