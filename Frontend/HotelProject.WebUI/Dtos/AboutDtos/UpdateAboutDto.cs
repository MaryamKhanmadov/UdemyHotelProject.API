namespace HotelProject.WebUI.Dtos.AboutDtos
{
    public class UpdateAboutDto
    {
        public int id { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeactive { get; set; } = false;
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Content { get; set; }
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int ClientCount { get; set; }
    }
}
