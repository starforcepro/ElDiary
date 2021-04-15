using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ElDiary.DAL.Entities;

namespace ElDiary.DAL.Repositories
{
    public class ContactsRepository : IRepository<Contact>
    {
        private ContactsContext contactsContext;

        public ContactsRepository(ContactsContext contactsContext)
        {
            this.contactsContext = contactsContext;
        }

        public IEnumerable<Contact> GetAll()
        {
            return contactsContext.Contacts;
        }

        public Contact Get(int id)
        {
            return contactsContext.Contacts.Find(id);
        }

        public void Create(Contact contact)
        {
            contactsContext.Contacts.Add(contact);
            contactsContext.SaveChanges();
        }

        public void Update(Contact contact)
        {
            contactsContext.Entry(contact).State = EntityState.Modified;
            contactsContext.SaveChanges();
        }

        public IEnumerable<Contact> Find(Func<Contact, bool> predicate)
        {
            return contactsContext.Contacts.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            var contact = contactsContext.Contacts.Find(id);
            if (contact != null)
                contactsContext.Contacts.Remove(contact);
            contactsContext.SaveChanges();
        }
    }
}