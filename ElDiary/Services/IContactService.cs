using System;
using ElDiary.Entities;
using ElDiary.Models;

namespace ElDiary.Services
{
    public interface IContactService
    {
        Contact[] Select();
        void Create(AddContactViewModel addContactViewModel);
        void Delete(Guid guidOfContact);
    }
}