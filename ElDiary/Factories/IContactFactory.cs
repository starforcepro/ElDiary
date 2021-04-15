using ElDiary.DAL.Entities;
using ElDiary.Models;
using ElDiary.ViewModels;

namespace ElDiary.Factories
{
    public interface IContactFactory
    {
        Contact Create(AddContactViewModel addContactViewModel);
        Contact Create(ContactModel contactModel);
    }
}