using System;
using ElDiary.Entities;
using ElDiary.Models;

namespace ElDiary.Factories
{
    public class ContactFactory : IContactFactory
    {
        public Contact Create(AddContactViewModel addContactViewModel)
        {
            return new Contact
            {
                Id = Guid.NewGuid(),
                Phone = addContactViewModel.Phone,
                Email = addContactViewModel.Email,
                Name = addContactViewModel.Name
            };
        }
    }
}