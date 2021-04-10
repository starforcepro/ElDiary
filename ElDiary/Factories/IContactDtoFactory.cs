using ElDiary.Entities;

namespace ElDiary.Factories
{
    public interface IContactDtoFactory
    {
        ContactDto Create(ContactModel contactModel);
    }
}