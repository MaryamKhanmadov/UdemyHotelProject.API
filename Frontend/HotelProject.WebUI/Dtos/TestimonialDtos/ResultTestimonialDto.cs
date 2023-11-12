namespace HotelProject.WebUI.Dtos.TestimonialDtos
{
    public class ResultTestimonialDto
    {
        public int id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeactive { get; set; } = false;
        public required string Name { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Image { get; set; }
    }
}
