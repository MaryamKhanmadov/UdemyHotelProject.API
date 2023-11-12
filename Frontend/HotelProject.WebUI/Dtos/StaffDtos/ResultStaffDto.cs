namespace HotelProject.WebUI.Dtos.StaffDtos
{
    public class ResultStaffDto
    {
        public int id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeactive { get; set; } = false;
        public required string Name { get; set; }
        public required string Title { get; set; }
        public required string Image { get; set; }
        public required string SocialMedia1 { get; set; }
        public required string SocialMedia2 { get; set; }
        public required string SocialMedia3 { get; set; }
    }
}
