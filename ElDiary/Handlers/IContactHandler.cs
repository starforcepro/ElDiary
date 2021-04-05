using System;
using ElDiary.Entities;

namespace ElDiary.Handlers
{
    public interface IContactHandler
    {
        Contact[] Select(Guid id);
        Contact[] Select();
        void Create(Contact contact);
        void Delete(Guid guidOfContact);
    }
}