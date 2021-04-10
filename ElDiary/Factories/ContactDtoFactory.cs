using ElDiary.Entities;

namespace ElDiary.Factories
{
    public class ContactDtoFactory : IContactDtoFactory
    {
        public ContactDto Create(ContactModel contactModel)
        {
            return new ContactDto
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