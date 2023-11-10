using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDtos
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Please, enter service icon link!")]
        public required string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Please, enter service title!")]
        [StringLength(100, ErrorMessage ="Plaese, enter maximum 100 symbol!")]
        public required string Title { get; set; }

        public required string Description { get; set; }
    }
}
