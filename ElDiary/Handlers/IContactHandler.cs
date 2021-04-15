using System.Collections.Generic;
using ElDiary.DAL.Entities;

namespace ElDiary.Handlers
{
    public interface IContactHandler
    {
        IEnumerable<Contact> GetAll();
        void Create(Contact contact);
        void Delete(int id);
        void Update(Contact contact);
    }
}