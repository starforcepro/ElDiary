using System.Collections.Generic;
using ElDiary.DAL.Entities;
using ElDiary.DAL.Repositories;

namespace ElDiary.Handlers
{
    public class ContactHandler : IContactHandler
    {
        private readonly ContactsRepository contactsRepository;

        public ContactHandler(ContactsRepository contactsRepository)
        {
            this.contactsRepository = contactsRepository;
        }

        public IEnumerable<Contact> GetAll()
        {
            return contactsRepository.GetAll();
        }

        public void Create(Contact contact)
        {
            contactsRepository.Create(contact);
        }

        public void Delete(int id)
        {
            contactsRepository.Delete(id);
        }

        public void Update(Contact contact)
        {
            contactsRepository.Update(contact);
        }
    }
}