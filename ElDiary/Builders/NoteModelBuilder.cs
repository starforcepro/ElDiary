using System.Collections.Generic;
using System.Linq;
using ElDiary.Entities;
using ElDiary.Factories;
using ElDiary.Handlers;

namespace ElDiary.Builders
{
    public class NoteModelBuilder : INoteModelBuilder
    {
        private readonly INoteModelFactory noteModelFactory;
        private readonly IContactHandler contactHandler;
        private readonly IContactModelFactory contactModelFactory;

        public NoteModelBuilder(INoteModelFactory noteModelFactory, 
                                IContactHandler contactHandler, 
                                IContactModelFactory contactModelFactory)
        {
            this.noteModelFactory = noteModelFactory;
            this.contactHandler = contactHandler;
            this.contactModelFactory = contactModelFactory;
        }

        public NoteModel Build(Note currentNote)
        {
            var contacts = contactHandler.Select(currentNote.ContactId);

            var contactModels = contacts.Select(item => contactModelFactory.Create(item)).ToArray();

            return noteModelFactory.Create(contactModels, currentNote);
        }
    
    }
}