using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDtos
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Plaese, enter name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Plaese, enter surname!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Plaese, enter username!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Plaese, enter email!"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string? City { get; set; }

        [Required(ErrorMessage = "Plaese, enter password!"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Plaese, re-enter password!"),DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Please enter same password!")]
        public string ConfirmPassword { get; set; }
    }
}
