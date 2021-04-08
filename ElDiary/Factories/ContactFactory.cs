using System;
using ElDiary.Entities;
using ElDiary.Models;

namespace ElDiary.Factories
{
    public class ContactFactory : IContactFactory
    {
        public ContactDto Create(AddContactViewModel addContactViewModel)
        {
            return new ContactDto
            {
                Id = Guid.NewGuid(),
                Phone = addContactViewModel.Phone,
                Email = addContactViewModel.Email,
                FirstName = addContactViewModel.Name
            };
        }
    }
}