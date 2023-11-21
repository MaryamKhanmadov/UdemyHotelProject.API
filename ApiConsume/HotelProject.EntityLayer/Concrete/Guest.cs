namespace HotelProject.EntityLayer.Concrete
{
    public class Guest
    {
        public required int GuestId { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string City { get; set; }
    }
}
