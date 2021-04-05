using System;

namespace ElDiary.Entities
{
    public class NoteModel
    {
        public Guid Id { get; set; }
        public string Date { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public ContactModel[] ContactModels { get; set; }
    }
}