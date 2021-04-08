using System;
using ElDiary.Entities;
using ElDiary.Models;

namespace ElDiary.Services
{
    public interface IContactsService
    {
        ContactModel[] GetAll();
        void Create(AddContactViewModel addContactViewModel);
        void Delete(Guid guidOfContact);
    }
}