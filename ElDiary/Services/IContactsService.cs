using System;
using ElDiary.Entities;
using ElDiary.ViewModels;

namespace ElDiary.Services
{
    public interface IContactsService
    {
        ContactModel[] GetAll();
        void Create(AddContactViewModel addContactViewModel);
        void Delete(Guid contactId);
        void Edit(object editedContactsJson);
    }
}