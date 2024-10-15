namespace dvdrental.DTOs.ResponceDtos
{
    public class MovieResponceDto : MovieDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
