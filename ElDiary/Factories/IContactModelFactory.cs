using ElDiary.DAL.Entities;
using ElDiary.Models;

namespace ElDiary.Factories
{
    public interface IContactModelFactory
    {
        ContactModel Create(Contact contact);
    }
}