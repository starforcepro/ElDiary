using System;
using System.Linq;
using ElDiary.Entities;
using ElDiary.Repositories;

namespace ElDiary.Handlers
{
    public class ContactHandler : IContactHandler
    {
        public ContactDto[] Select(Guid id)
        {
            return FakeContactsRepository.Contacts.Where(x => x.Id == id).ToArray();
        }

        public ContactDto[] SelectAll()
        {
            return FakeContactsRepository.Contacts.ToArray();
        }

        public void Create(ContactDto contactDto)
        {
            FakeContactsRepository.Create(contactDto);
        }

        public void Delete(Guid guidOfContact)
        {
            FakeContactsRepository.Delete(guidOfContact);
        }
    }
}