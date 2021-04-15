using System;
using System.Collections.Generic;
using ElDiary.DAL.Entities;

namespace ElDiary.DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T contact);
        void Update(T contact);
        IEnumerable<Contact> Find(Func<Contact, bool> predicate);
        void Delete(int id);
    }
}