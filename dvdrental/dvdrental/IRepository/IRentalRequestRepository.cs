using dvdrental.Entity;

namespace dvdrental.IRepository
{
    public interface IRentalRequestRepository
    {
        Task<RentalRequest> AddRentalRequest(RentalRequest rentalRequest);
        Task NotifyAdminAboutRentalRequest(RentalRequest rentalRequest);
        Task<bool> AcceptRentalRequest(int id, bool isAccepted);
        Task NotifyCustomerAboutRentalStatus(int rentalRequestId, string status);
        Task<bool> ReturnRentalRequest(int id);
        Task NotifyCustomerAboutReturn(int rentalRequestId);
        Task<RentalRequest> GetRentalRequestById(int id);
        Task<List<RentalRequest>> GetAllRentalRequests();
        Task<List<RentalRequest>> GetRentalsByMovieId(int movieId);
        Task<List<RentalRequest>> GetRentalsByCustomerId(int customerId);
        Task<List<RentalRequest>> GetRentalsByCategoryId(int categoryId);
        Task<List<RentalRequest>> GetRentalsByDirector(string director);



    }
}
