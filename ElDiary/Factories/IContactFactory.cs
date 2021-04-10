using ElDiary.Entities;
using ElDiary.ViewModels;

namespace ElDiary.Factories
{
    public interface IContactFactory
    {
        ContactDto Create(AddContactViewModel addContactViewModel);
    }
}