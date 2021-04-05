using ElDiary.Entities;

namespace ElDiary.Factories
{
    public interface INoteModelFactory
    {
        NoteModel Create(ContactModel[] contacts, Note note);
    }
}