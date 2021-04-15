using System.ComponentModel.DataAnnotations;

namespace ElDiary.DAL.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
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