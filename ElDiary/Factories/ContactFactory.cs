using ElDiary.DAL.Entities;
using ElDiary.Models;
using ElDiary.ViewModels;

namespace ElDiary.Factories
{
    public class ContactFactory : IContactFactory
    {
        public Contact Create(AddContactViewModel addContactViewModel)
        {
            return new Contact
            {
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

        public Contact Create(ContactModel contactModel)
        {
            return new Contact
            {
                Id = contactModel.Id,
                SecondName = contactModel.SecondName,
                FirstName = contactModel.FirstName,
                ThirdName = contactModel.ThirdName,
                BirthDate = contactModel.BirthDate,
                Company = contactModel.Company,
                Position = contactModel.Position,
                Phone = contactModel.Phone,
                Email = contactModel.Email,
                Skype = contactModel.Skype,
                Other = contactModel.Other
            };
        }
    }
}