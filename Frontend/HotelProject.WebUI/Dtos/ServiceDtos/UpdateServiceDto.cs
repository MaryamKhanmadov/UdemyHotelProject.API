using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDtos
{
    public class UpdateServiceDto
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Please, enter service icon link!")]
        public required string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Please, enter service title!")]
        [StringLength(100, ErrorMessage = "Plaese, enter maximum 100 symbol!")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Please, enter service description!")]
        [StringLength(500, ErrorMessage = "Plaese, enter maximum 500 symbol!")]
        public required string Description { get; set; }
    }
}
