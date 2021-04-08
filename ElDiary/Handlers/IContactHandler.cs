using System;
using ElDiary.Entities;

namespace ElDiary.Handlers
{
    public interface IContactHandler
    {
        ContactDto[] Select(Guid id);
        ContactDto[] SelectAll();
        void Create(ContactDto contactDto);
        void Delete(Guid guidOfContact);
    }
}