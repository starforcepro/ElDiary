using System;
using ElDiary.Entities;
using ElDiary.Models;

namespace ElDiary.Factories
{
    public class NoteFactory : INoteFactory
    {
        public Note Create(AddNoteViewModel addNoteViewModel)
        {
            return new Note
            {
                Id = Guid.NewGuid(),
                Subject = addNoteViewModel.Subject,
                Date = addNoteViewModel.Date,
                Description = addNoteViewModel.Description
            };
        }
    }
}