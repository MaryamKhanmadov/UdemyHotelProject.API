using Newtonsoft.Json;

namespace HotelProject.WebUI.Models.Staff
{
    public class StaffViewModel
    {
        public required int ID { get; set; }
        [JsonProperty]
        public required string Name { get; set; }
        [JsonProperty]
        public required string Title { get; set; }
        [JsonProperty]
        public required string Image { get; set; }
        [JsonProperty]
        public required DateTime CreatedDate { get; set; }
    }
}
