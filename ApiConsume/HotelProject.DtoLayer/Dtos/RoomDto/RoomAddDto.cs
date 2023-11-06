using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage = "Please, enter room number!")]
        public required string RoomNumber { get; set; }
        
        public required string RoomCoverImage { get; set; }
        
        [Required(ErrorMessage = "Please, enter room price!")]
        public required int Price { get; set; }
        
        [Required(ErrorMessage = "Please, enter room title!")]
        public required string Title { get; set; }
        
        [Required(ErrorMessage = "Please, enter room bedcount!")]
        public required string BedCount { get; set; }
        
        [Required(ErrorMessage = "Please, enter room bathcount!")]
        public required string BathCount { get; set; }
        
        public required string Wifi { get; set; }
        
        public required string Description { get; set; }
    }
}
