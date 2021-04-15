using System.Collections.Generic;
using System.Linq;
using ElDiary.Factories;
using ElDiary.Handlers;
using ElDiary.Models;
using ElDiary.ViewModels;
using Newtonsoft.Json;

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
            var contacts = contactHandler.GetAll();
            var contactModels = contacts.Select(x => contactModelFactory.Create(x)).ToArray();

            return contactModels;
        }

        public void Create(AddContactViewModel addContactViewModel)
        {
            var contact = contactFactory.Create(addContactViewModel);

            contactHandler.Create(contact);
        }

        public void Delete(int contactId)
        {
            contactHandler.Delete(contactId);
        }

        public void Edit(object editedContactsJson)
        {
            var editedContacts = JsonConvert.DeserializeObject<List<ContactModel>>(editedContactsJson.ToString());
            editedContacts.ForEach(x => contactHandler.Update(contactFactory.Create(x)));
        }
    }
}