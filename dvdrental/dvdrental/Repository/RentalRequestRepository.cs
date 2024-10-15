using dvdrental.Entity;
using dvdrental.IRepository;
using Microsoft.Data.SqlClient;

namespace dvdrental.Repository
{
    public class RentalRequestRepository : IRentalRequestRepository
    {
        private readonly string _connectionString;

        public RentalRequestRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        
        public async Task<RentalRequest> AddRentalRequest(RentalRequest rentalRequest)
        {
            
        }

      
        public async Task NotifyAdminAboutRentalRequest(RentalRequest rentalRequest)
        {
        }

       
        public async Task<bool> AcceptRentalRequest(int id, bool isAccepted)
        {
           
        }

     
        private async Task NotifyCustomerAboutRentalStatus(int rentalRequestId, string status)
        {
            
        }

    
        public async Task<bool> ReturnRentalRequest(int id)
        {
           

            
        }

  
        private async Task NotifyCustomerAboutReturn(int rentalRequestId)
        {
           
        }

      
        public async Task<RentalRequest> GetRentalRequestById(int id)
        {
           
            
        }

       
        public async Task<List<RentalRequest>> GetAllRentalRequests()
        {
         
        }

            

      
        public async Task<List<RentalRequest>> GetRentalsByMovieId(int movieId)
        {
           
        }

    
        public async Task<List<RentalRequest>> GetRentalsByCustomerId(int customerId)
        {
          
        }

       
        public async Task<List<RentalRequest>> GetRentalsByCategoryId(int categoryId)
        {
          
        }

       
        public async Task<List<RentalRequest>> GetRentalsByDirector(string director)
        {
            
        }

        Task IRentalRequestRepository.NotifyCustomerAboutRentalStatus(int rentalRequestId, string status)
        {
          
        }

        Task IRentalRequestRepository.NotifyCustomerAboutReturn(int rentalRequestId)
        {
           
        }
    }
}
