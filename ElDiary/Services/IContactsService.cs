using ElDiary.Models;
using ElDiary.ViewModels;

namespace ElDiary.Services
{
    public interface IContactsService
    {
        ContactModel[] GetAll();
        void Create(AddContactViewModel addContactViewModel);
        void Delete(int contactId);
        void Edit(object editedContactsJson);
    }
}