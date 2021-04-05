using ElDiary.Entities;
using ElDiary.Models;

namespace ElDiary.Factories
{
    public interface IContactFactory
    {
        Contact Create(AddContactViewModel addContactViewModel);
    }
}