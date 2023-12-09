namespace HotelProject.WebUI.Dtos.GuestDtos
{
    public class UpdateGuestDto
    {
        public required int GuestId { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string City { get; set; }
    }
}
