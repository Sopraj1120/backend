using dvdrental.DTOs.RequestDtos;
using dvdrental.DTOs.ResponceDtos;
using dvdrental.Entity;
using dvdrental.IRepository;
using dvdrental.IService;

namespace dvdrental.Service
{
    public class RentalrequestService : IRentalRequestService
    {
        private readonly IRentalRequestRepository _rentalRequestsRepository;

        public RentalrequestService(IRentalRequestRepository rentalRequestsRepository)
        {
            _rentalRequestsRepository = rentalRequestsRepository;
        }

      
        public async Task<RentalResponceDto> AddRentalRequest(RentalReuest_RequestDto rentalRequestDto)
        {
  
        }

       
        public async Task<bool> AcceptRentalRequest(int id, bool isAccepted)
        {
           
        }

       
        public async Task<bool> ReturnRentalRequest(int id)
        {
         
        }

      
        public async Task<RentalResponceDto> GetRentalRequestById(int id)
        {
          
        }

      
        public async Task<List<RentalResponceDto>> GetAllRentalRequests()
        {
          
        }

       
        public async Task<List<RentalResponceDto>> GetRentalsByMovieId(int movieId)
        {

        }

       
        public async Task<List<RentalResponceDto>> GetRentalsByCustomerId(int customerId)
        {

        }

    
        public async Task<List<RentalResponceDto>> GetRentalsByCategoryId(int categoryId)
        {
           
        }

       
        public async Task<List<RentalResponceDto>> GetRentalsByDirector(string director)
        {
           
        }
    }

}
