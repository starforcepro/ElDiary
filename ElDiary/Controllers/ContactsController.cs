using System;
using System.Web.Mvc;
using ElDiary.Models;
using ElDiary.Services;

namespace ElDiary.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactService contactService;

        public ContactsController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet]
        public ViewResult Contacts()
        {
            var contacts = contactService.Select();

            return View("Contacts", new ContactsViewModel {Contacts = contacts});
        }

        [HttpGet]
        public ViewResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(AddContactViewModel addContactViewModel)
        {
            contactService.Create(addContactViewModel);

            var contacts = contactService.Select();
            return View("Contacts", new ContactsViewModel { Contacts = contacts });
        }


        [HttpPost]
        public void RecieveData(object guidOfContact)
        {
            contactService.Delete(Guid.Parse(guidOfContact.ToString()));
        }
    }
}