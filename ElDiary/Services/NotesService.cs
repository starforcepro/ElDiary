using System;
using System.Linq;
using ElDiary.Builders;
using ElDiary.Entities;
using ElDiary.Factories;
using ElDiary.Handlers;
using ElDiary.Models;

namespace ElDiary.Services
{
    public class NotesService : INotesService
    {
        private readonly INoteModelBuilder noteModelBuilder;
        private readonly INoteHandler noteHandler;
        private readonly INoteFactory noteFactory;

        public NotesService(INoteModelBuilder noteModelBuilder, 
            INoteHandler noteHandler, 
            INoteFactory noteFactory)
        {
            this.noteModelBuilder = noteModelBuilder;
            this.noteHandler = noteHandler;
            this.noteFactory = noteFactory;
        }       

        public NoteModel[] Select()
        {
            var notes = noteHandler.Select();

            return notes.Select(item => noteModelBuilder.Build(item)).ToArray();
        }

        public void Create(AddNoteViewModel addNoteViewModel)
        {
            var note = noteFactory.Create(addNoteViewModel);

            noteHandler.Create(note);
        }

        public void Delete(Guid guidOfNote)
        {
            noteHandler.Delete(guidOfNote);
        }
    }
}