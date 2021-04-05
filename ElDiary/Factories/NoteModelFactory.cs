using ElDiary.Entities;

namespace ElDiary.Factories
{
    public class NoteModelFactory : INoteModelFactory
    {
        public NoteModel Create(ContactModel[] contacts, Note note)
        {
            return new NoteModel
            {
                Id = note.Id,
                Date = note.Date,
                Subject = note.Subject,
                Description = note.Description,
                ContactModels = contacts
            };
        }
    }
}