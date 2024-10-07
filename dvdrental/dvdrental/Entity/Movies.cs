namespace dvdrental.Entity
{
    public class Movies
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public int No_of_Copies { get; set; }

        public bool IsAviable {  get; set; }

        public Guid CategoryId { get; set; }

        public string ImageUrl { get; set; }

        public Categories Category {  get; set; }

    }
}
