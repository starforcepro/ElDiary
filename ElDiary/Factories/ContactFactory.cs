using System;
using ElDiary.Entities;
using ElDiary.ViewModels;

namespace ElDiary.Factories
{
    public class ContactFactory : IContactFactory
    {
        public ContactDto Create(AddContactViewModel addContactViewModel)
        {
            return new ContactDto
            {
                Id = Guid.NewGuid(),
                SecondName = addContactViewModel.SecondName,
                FirstName = addContactViewModel.FirstName,
                ThirdName = addContactViewModel.ThirdName,
                BirthDate = addContactViewModel.BirthDate,
                Company = addContactViewModel.Company,
                Position = addContactViewModel.Position,
                Phone = addContactViewModel.Phone,
                Email = addContactViewModel.Email,
                Skype = addContactViewModel.Skype,
                Other = addContactViewModel.Other
            };
        }
    }
}