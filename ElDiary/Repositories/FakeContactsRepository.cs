using System;
using System.Collections.Generic;
using ElDiary.Entities;

namespace ElDiary.Repositories
{
    public static class FakeContactsRepository
    {
        public static readonly List<ContactDto> Contacts = new List<ContactDto>
        {
            new ContactDto
            {
                FirstName = "Kolyan",
                SecondName = "Petrov",
                ThirdName = "Alekseevi4",
                BirthDate = "1999",
                Company = "SuperCompany",
                Position = "Genius",
                Phone = "89829999999",
                Email = "kolyan@gmail.com",
                Skype = "gg2",
                Other = "other",
                Id = Guid.Parse("cd3df559-c345-4b43-9e8b-22fd1a6d3d37")
            },

            new ContactDto
            {
                FirstName = "Serega",
                SecondName = "Petrov",
                ThirdName = "Mihailovi4",
                BirthDate = "1998",
                Company = "SuperCompany",
                Position = "SDE II",
                Phone = "89829944999",
                Email = "serega@sde.com",
                Skype = "gg3",
                Other = "other",
                Id = Guid.Parse("3fd315eb-79fe-4a53-93c2-8f8a8c9979da")
            },

            new ContactDto
            {
                FirstName = "Vovan",
                SecondName = "Petrov",
                ThirdName = "Alekseevi4",
                BirthDate = "1997",
                Company = "SuperCompany",
                Position = "SDET",
                Phone = "89829999228",
                Email = "vovan@sdet.com",
                Skype = "gg4",
                Other = "other",
                Id = Guid.Parse("61bf9c72-b4d8-41e6-a60b-33b21119eb7e")
            }
        };

        public static void Create(ContactDto contactDto)
        {
            Contacts.Add(contactDto);
        }

        public static void Delete(Guid contactId)
        {
            Contacts.RemoveAll(x => x.Id == contactId);
        }
    }
}