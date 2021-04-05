using ElDiary.Entities;
using ElDiary.Models;

namespace ElDiary.Factories
{
    public interface INoteFactory
    {
        Note Create(AddNoteViewModel addNoteViewModel);
    }
}