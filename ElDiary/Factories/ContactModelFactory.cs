using ElDiary.DAL.Entities;
using ElDiary.Models;

namespace ElDiary.Factories
{
    public class ContactModelFactory : IContactModelFactory
    {
        public ContactModel Create(Contact contact)
        {
            return new ContactModel
            {
                Id = contact.Id,
                SecondName = contact.SecondName,
                FirstName = contact.FirstName,
                ThirdName = contact.ThirdName,
                BirthDate = contact.BirthDate,
                Company = contact.Company,
                Position = contact.Position,
                Phone = contact.Phone,
                Email = contact.Email,
                Skype = contact.Skype,
                Other = contact.Other
            };
        }
    }
}