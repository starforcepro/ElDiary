using System;

namespace ElDiary.Entities
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Date { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public Guid ContactId { get; set; }
    }
}
