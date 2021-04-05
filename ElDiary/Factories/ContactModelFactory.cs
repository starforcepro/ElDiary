using ElDiary.Entities;

namespace ElDiary.Factories
{
    public class ContactModelFactory : IContactModelFactory
    {
        public ContactModel Create(Contact contact)
        {
            return new ContactModel
            {
                Name = contact.Name,
                Phone = contact.Phone,
                Email = contact.Email
            };
        }
    }
}