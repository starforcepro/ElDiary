using System.Data.Entity;
using ElDiary.DAL.Entities;


namespace ElDiary.DAL
{
    public class ContactsContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        static ContactsContext()
        {
            Database.SetInitializer(new StoreDbInitializer());
        }
    }

    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<ContactsContext>
    {
        protected override void Seed(ContactsContext contactsDb)
        {
            contactsDb.Contacts.Add(new Contact
            {
                FirstName = "Kolyan",
                SecondName = "Petrov",
                ThirdName = "Alekseevi4",
                BirthDate = "1999",
                Company = "SuperCompany",
                Position = "Genius",
                Phone = "89829999999",
                Email = "kolyan@gmail.com",
                Skype = "gg2",
                Other = "other",
                Id = 1
            });
            contactsDb.Contacts.Add(new Contact
            {
                FirstName = "Serega",
                SecondName = "Petrov",
                ThirdName = "Mihailovi4",
                BirthDate = "1998",
                Company = "SuperCompany",
                Position = "SDE II",
                Phone = "89829944999",
                Email = "serega@sde.com",
                Skype = "gg3",
                Other = "other",
                Id = 2
            });
            contactsDb.Contacts.Add(new Contact
            {
                FirstName = "Vovan",
                SecondName = "Petrov",
                ThirdName = "Alekseevi4",
                BirthDate = "1997",
                Company = "SuperCompany",
                Position = "SDET",
                Phone = "89829999228",
                Email = "vovan@sdet.com",
                Skype = "gg4",
                Other = "other",
                Id = 3
            });
            contactsDb.Contacts.Add(new Contact
            {
                FirstName = "Goshan",
                SecondName = "Gotov",
                ThirdName = "Kibavi4",
                BirthDate = "1996",
                Company = "CompanyName",
                Position = "17",
                Phone = "89829567228",
                Email = "goshan@17.com",
                Skype = "gg5",
                Other = "other",
                Id = 4
            });
            contactsDb.SaveChanges();
        }
    }
}