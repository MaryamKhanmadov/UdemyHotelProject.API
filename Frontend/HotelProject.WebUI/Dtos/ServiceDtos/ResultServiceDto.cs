namespace HotelProject.WebUI.Dtos.ServiceDtos
{
    public class ResultServiceDto
    {
        public int id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeactive { get; set; } = false;
        public required string ServiceIcon { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
    }
}
