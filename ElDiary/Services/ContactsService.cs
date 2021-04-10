﻿using System;
using System.Linq;
using ElDiary.Entities;
using ElDiary.Factories;
using ElDiary.Handlers;
using ElDiary.ViewModels;

namespace ElDiary.Services
{
    public class ContactsService : IContactsService
    {
        private readonly IContactHandler contactHandler;
        private readonly IContactModelFactory contactModelFactory;
        private readonly IContactFactory contactFactory;

        public ContactsService(
            IContactHandler contactHandler,
            IContactModelFactory contactFactory,
            IContactFactory contactModelFactory)
        {
            this.contactHandler = contactHandler;
            this.contactModelFactory = contactFactory;
            this.contactFactory = contactModelFactory;
        }

        public ContactModel[] GetAll()
        {
            var contacts = contactHandler.SelectAll();
            var contactModels = contacts.Select(x => contactModelFactory.Create(x)).ToArray();

            return contactModels;
        }

        public void Create(AddContactViewModel addContactViewModel)
        {
            var contact = contactFactory.Create(addContactViewModel);

            contactHandler.Create(contact);
        }

        public void Delete(Guid guidOfContact)
        {
            contactHandler.Delete(guidOfContact);
        }
    }
}