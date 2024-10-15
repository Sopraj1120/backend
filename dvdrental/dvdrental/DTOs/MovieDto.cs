namespace dvdrental.DTOs
{
    public class MovieDto
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int No_of_Copies { get; set; }
        public int CategoryId { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
