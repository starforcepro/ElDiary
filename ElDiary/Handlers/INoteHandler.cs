using System;
using ElDiary.Entities;

namespace ElDiary.Handlers
{
    public interface INoteHandler
    {
        Note[] Select();
        void Create(Note note);
        void Delete(Guid guidOfNote);
    }
}