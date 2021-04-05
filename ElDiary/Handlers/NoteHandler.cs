using System;
using System.Linq;
using ElDiary.Entities;
using ElDiary.Repositories;

namespace ElDiary.Handlers
{
    public class NoteHandler : INoteHandler
    {
        public Note[] Select()
        {
            return FakeNotesRepository.Notes.ToArray();
        }

        public void Create(Note note)
        {
            FakeNotesRepository.Create(note);
        }

        public void Delete(Guid guidOfNote)
        {
            FakeNotesRepository.Delete(guidOfNote);
        }
    }
}