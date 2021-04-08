using ElDiary.Entities;

namespace ElDiary.Factories
{
    public class ContactModelFactory : IContactModelFactory
    {
        public ContactModel Create(ContactDto contactDto)
        {
            return new ContactModel
            {
                SecondName = contactDto.SecondName,
                FirstName = contactDto.FirstName,
                ThirdName = contactDto.ThirdName,
                BirthDate = contactDto.BirthDate,
                Company = contactDto.Company,
                Position = contactDto.Position,
                Phone = contactDto.Phone,
                Email = contactDto.Email,
                Skype = contactDto.Skype,
                Other = contactDto.Other
            };
        }
    }
}