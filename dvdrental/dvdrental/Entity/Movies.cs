namespace dvdrental.Entity
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int No_of_Copies { get; set; }

        public int CategoryId { get; set; }

       
        public Category Category { get; set; }

      
        public byte[] Image { get; set; }
        public bool IsDeleted { get; set; }


        public ICollection<RentalRequest> RentalRequests { get; set; }

    }
}
