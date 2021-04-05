using System;
using System.Collections.Generic;
using ElDiary.Entities;

namespace ElDiary.Repositories
{
    public static class FakeContactsRepository
    {
        private static List<Contact> contacts = new List<Contact>
        {
            new Contact {Email = "kolyan228@gmail.com",
                Name = "Kolyan",
                Phone = "89829999999",
                Id = Guid.Parse("cd3df559-c345-4b43-9e8b-22fd1a6d3d37") },

            new Contact {Email = "kolyan228@hotmail.com",
                Name = "Kolyan",
                Phone = "89828888888",
                Id =Guid.Parse("3fd315eb-79fe-4a53-93c2-8f8a8c9979da") },

            new Contact {Email = "kolyan228@yandex.com",
                Name = "Kolyan",
                Phone = "89827777777",
                Id = Guid.Parse("61bf9c72-b4d8-41e6-a60b-33b21119eb7e") }

        };

        public static IEnumerable<Contact> Contacts => contacts;

        public static void Create(Contact contact)
        {
            contacts.Add(contact);
        }

        public static void Delete(Guid guidOfContact)
        {

            foreach (var item in contacts)
            {
                if (item.Id == guidOfContact)

                    contacts.Remove(item);
                break;
            }
        }
    }
}
