using System;
using System.Linq;
using ElDiary.Entities;
using ElDiary.Repositories;

namespace ElDiary.Handlers
{
    public class ContactHandler : IContactHandler
    {
        public Contact[] Select(Guid id)
        {
            return FakeContactsRepository.Contacts.Where(x => x.Id == id).ToArray();
        }

        public Contact[] Select()
        {
            return FakeContactsRepository.Contacts.ToArray();
        }

        public void Create(Contact contact)
        {
            FakeContactsRepository.Create(contact);
        }

        public void Delete(Guid guidOfContact)
        {
            FakeContactsRepository.Delete(guidOfContact);
        }
    }
}