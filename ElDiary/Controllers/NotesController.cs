using System;
using System.Web.Mvc;
using ElDiary.Models;
using ElDiary.Services;

namespace ElDiary.Controllers
{
    public class NotesController : Controller
    {
        private readonly INotesService notesService;

        public NotesController(INotesService notesService)
        {
            this.notesService = notesService;
        }

        [HttpGet]
        public ViewResult Notes()
        {
            var notes = notesService.Select();

            return View("Notes", new NotesViewModel { Notes = notes });
        }

        [HttpGet]
        public ViewResult AddNote()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNote(AddNoteViewModel addNoteViewModel)
        {
            notesService.Create(addNoteViewModel);

            var notes = notesService.Select();
            return View("Notes", new NotesViewModel { Notes = notes });
        }

        [HttpPost]
        public void RecieveData(object guidOfNote)
        {
            notesService.Delete(Guid.Parse(guidOfNote.ToString()));
        }
    }
}