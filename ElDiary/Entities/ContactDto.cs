using System;

namespace ElDiary.Entities
{
    public class ContactDto
    {
        public Guid Id { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string ThirdName { get; set; }
        public string BirthDate { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string Other { get; set; }
    }
}