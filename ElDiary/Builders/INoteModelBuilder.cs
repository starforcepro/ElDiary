using ElDiary.Entities;

namespace ElDiary.Builders
{
    public interface INoteModelBuilder
    {
        NoteModel Build(Note currentNote);
    }
}