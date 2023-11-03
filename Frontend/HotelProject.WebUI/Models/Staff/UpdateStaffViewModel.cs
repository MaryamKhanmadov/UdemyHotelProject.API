using Newtonsoft.Json;

namespace HotelProject.WebUI.Models.Staff
{
    public class UpdateStaffViewModel
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string? SocialMedia1 { get; set; }
        public string? SocialMedia2 { get; set; }
        public string? SocialMedia3 { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeactive { get; set; } = false;
    }
}
