namespace HotelProject.WebUI.Dtos.BookingDtos
{
    public class ResultBookingDto
    {
        public int id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeactive { get; set; } = false;
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string AdultCount { get; set; }
        public string ChildCount { get; set; }
        public string RoomCount { get; set; }
        public string SpecialRequest { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; }
    }
}
