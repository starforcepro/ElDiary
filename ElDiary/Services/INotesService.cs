using System;
using ElDiary.Entities;
using ElDiary.Models;

namespace ElDiary.Services
{
    public interface INotesService
    {
        NoteModel[] Select();
        void Create(AddNoteViewModel addNoteViewModel);
        void Delete(Guid parse);
    }
}