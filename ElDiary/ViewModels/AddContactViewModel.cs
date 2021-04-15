using System.ComponentModel.DataAnnotations;

namespace ElDiary.ViewModels
{
    public class AddContactViewModel
    {
        [StringLength(200, ErrorMessage = "length can't be more than 200.")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "can't create contact without first name")]
        [StringLength(200, ErrorMessage = "length can't be more than 200.")]
        public string FirstName { get; set; }

        [StringLength(200, ErrorMessage = "length can't be more than 200.")]
        public string ThirdName { get; set; }

        [StringLength(200, ErrorMessage = "length can't be more than 200.")]
        public string BirthDate { get; set; }

        [StringLength(200, ErrorMessage = "length can't be more than 200.")]
        public string Company { get; set; }

        [StringLength(200, ErrorMessage = "length can't be more than 200.")]
        public string Position { get; set; }

        [StringLength(200, ErrorMessage = "length can't be more than 200.")]
        public string Phone { get; set; }

        [StringLength(200, ErrorMessage = "length can't be more than 200.")]
        public string Email { get; set; }

        [StringLength(200, ErrorMessage = "length can't be more than 200.")]
        public string Skype { get; set; }

        [StringLength(200, ErrorMessage = "length can't be more than 200.")]
        public string Other { get; set; }
    }
}