﻿using System;
using System.Web.Mvc;
using ElDiary.Models;
using ElDiary.Services;
using ElDiary.ViewModels;

namespace ElDiary.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactsService contactsService;

        public ContactsController(IContactsService contactsService)
        {
            this.contactsService = contactsService;
        }

        [HttpGet]
        public ViewResult Contacts()
        {
            var contacts = contactsService.GetAll();

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
            contactsService.Create(addContactViewModel);

            var contacts = contactsService.GetAll();
            return View("Contacts", new ContactsViewModel {Contacts = contacts});
        }


        [HttpPost]
        public void ReceiveData(object guidOfContact)
        {
            contactsService.Delete(Guid.Parse(guidOfContact.ToString()));
        }
    }
}