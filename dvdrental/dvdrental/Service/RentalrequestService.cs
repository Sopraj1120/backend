using dvdrental.DTOs;
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

        public Task<bool> AcceptRentalRequest(int id, bool isAccepted)
        {
            throw new NotImplementedException();
        }

        public async Task<RentalResponceDto> AddRentalRequest(RentalRequestDto rentalRequestDto)
        {
            var rentalRequest = new RentalRequest
            {
                MovieId = rentalRequestDto.MovieId,
                CustomerId = rentalRequestDto.CustomerId,
                RentDate = rentalRequestDto.RentDate,
                ReturnDate = rentalRequestDto.ReturnDate,
                //MovieImage = rentalRequestDto.MovieImage,
                //MovieImageType = rentalRequestDto.MovieImageType,
            };

            var addedRentalRequest = await _rentalRequestsRepository.AddRentalRequest(rentalRequest);

            // Map the RentalRequest to RentalResponseDto
            var rentalResponseDto = new RentalResponceDto
            {
                Id = addedRentalRequest.Id, // Ensure RentalRequest has an Id property
                MovieId = addedRentalRequest.MovieId,
                CustomerId = addedRentalRequest.CustomerId,
                RentDate = addedRentalRequest.RentDate,
                ReturnDate = addedRentalRequest.ReturnDate,
                //MovieImage = (byte[])addedRentalRequest.MovieImage,
                //MovieImageType = (string)addedRentalRequest.MovieImageType
            };

            return rentalResponseDto;

        }

        public Task<List<RentalResponceDto>> GetAllRentalRequests()
        {
            throw new NotImplementedException();
        }

        public Task<RentalResponceDto> GetRentalRequestById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RentalResponceDto>> GetRentalsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<RentalResponceDto>> GetRentalsByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<RentalResponceDto>> GetRentalsByDirector(string director)
        {
            throw new NotImplementedException();
        }

        public Task<List<RentalResponceDto>> GetRentalsByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ReturnRentalRequest(int id)
        {
            throw new NotImplementedException();
        }



        //public async Task<bool> AcceptRentalRequest(int id, bool isAccepted)
        //{

        //}


        //public async Task<bool> ReturnRentalRequest(int id)
        //{

        //}


        //public async Task<RentalResponceDto> GetRentalRequestById(int id)
        //{

        //}


        //public async Task<List<RentalResponceDto>> GetAllRentalRequests()
        //{

        //}


        //public async Task<List<RentalResponceDto>> GetRentalsByMovieId(int movieId)
        //{

        //}


        //public async Task<List<RentalResponceDto>> GetRentalsByCustomerId(int customerId)
        //{

        //}


        //public async Task<List<RentalResponceDto>> GetRentalsByCategoryId(int categoryId)
        //{

        //}


        //public async Task<List<RentalResponceDto>> GetRentalsByDirector(string director)
        //{

        //}
    }

}
