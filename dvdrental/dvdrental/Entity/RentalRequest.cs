namespace dvdrental.Entity
{
    public class RentalRequest
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieImage { get; set; }
        public int MovieAvailableCopies { get; set; }
        public Guid CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public Guid CategoryId { get; set; }
        public RentalStatus Status { get; set; }
        public DateTime RentDate { get; set; } = DateTime.Now;
        public DateTime ReturnTime { get; set; }

        public Movies Movie { get; set; }
        public Customer Customer { get; set; }
        public Categories Category { get; set; }
    }
}
