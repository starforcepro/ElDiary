using ElDiary.Entities;
using ElDiary.Models;

namespace ElDiary.Factories
{
    public interface IContactFactory
    {
        ContactDto Create(AddContactViewModel addContactViewModel);
    }
}