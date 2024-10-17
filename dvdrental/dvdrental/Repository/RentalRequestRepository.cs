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
            const string query = @"
             INSERT INTO RentalRequests (MovieId, CustomerId, RentDate, ReturnDate)
             VALUE(@MovieId, @CustomerId, @RentDate, @ReturnDate);
             ";

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MovieId", rentalRequest.MovieId);
                    command.Parameters.AddWithValue("@CustomerId", rentalRequest.CustomerId);
                    command.Parameters.AddWithValue("@RentDate", rentalRequest.RentDate);
                    command.Parameters.AddWithValue("@ReturnDate", rentalRequest.ReturnDate);
                    //command.Parameters.AddWithValue("@MovieImage", rentalRequest.MovieImage);
                    //command.Parameters.AddWithValue("@MovieImageType", rentalRequest.MovieImageType);

                    var id = await command.ExecuteScalarAsync();
                    rentalRequest.Id = Convert.ToInt32(id);
                    return rentalRequest;
                }
            }
             
            
        }




        public async Task<bool> AcceptRentalRequest(int id, bool isAccepted)
        {
            return await AcceptRentalRequest(id, isAccepted);
        }




        public async Task<bool> ReturnRentalRequest(int id)
        {
            return !await AcceptRentalRequest(id, false);

        }



        //public async Task<RentalRequest> GetRentalRequestById(int id)
        //{
            

        //}


        //public async Task<List<RentalRequest>> GetAllRentalRequests()
        //{
        //}




        //public async Task<List<RentalRequest>> GetRentalsByMovieId(int movieId)
        //{

        //}


        //public async Task<List<RentalRequest>> GetRentalsByCustomerId(int customerId)
        //{

        //}


        //public async Task<List<RentalRequest>> GetRentalsByCategoryId(int categoryId)
        //{

        //}


        //public async Task<List<RentalRequest>> GetRentalsByDirector(string director)
        //{

        //}

        public Task NotifyAdminAboutRentalRequest(RentalRequest rentalRequest)
        {
            throw new NotImplementedException();
        }

        public Task NotifyCustomerAboutRentalStatus(int rentalRequestId, string status)
        {
            throw new NotImplementedException();
        }

        public Task NotifyCustomerAboutReturn(int rentalRequestId)
        {
            throw new NotImplementedException();
        }

        public Task<RentalRequest> GetRentalRequestById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RentalRequest>> GetAllRentalRequests()
        {
            throw new NotImplementedException();
        }

        public Task<List<RentalRequest>> GetRentalsByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }

        public Task<List<RentalRequest>> GetRentalsByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<RentalRequest>> GetRentalsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<RentalRequest>> GetRentalsByDirector(string director)
        {
            throw new NotImplementedException();
        }
    }
}
