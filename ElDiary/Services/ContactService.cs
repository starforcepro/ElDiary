using System;
using ElDiary.Entities;
using ElDiary.Factories;
using ElDiary.Handlers;
using ElDiary.Models;

namespace ElDiary.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactHandler contactHandler;
        private readonly IContactFactory contactFactory;

        public ContactService(IContactHandler contactHandler, IContactFactory contactFactory)
        {
            this.contactHandler = contactHandler;
            this.contactFactory = contactFactory;
        }

        public Contact[] Select()
        {
            return contactHandler.Select();
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