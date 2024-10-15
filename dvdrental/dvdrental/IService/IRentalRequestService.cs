﻿using dvdrental.DTOs.RequestDtos;
using dvdrental.DTOs.ResponceDtos;

namespace dvdrental.IService
{
    public interface IRentalRequestService
    {
        Task<RentalResponceDto> AddRentalRequest(RentalReuest_RequestDto rentalRequestDto);
        Task<bool> AcceptRentalRequest(int id, bool isAccepted);
        Task<bool> ReturnRentalRequest(int id);
        Task<RentalResponceDto> GetRentalRequestById(int id);
        Task<List<RentalResponceDto>> GetAllRentalRequests();
        Task<List<RentalResponceDto>> GetRentalsByMovieId(int movieId);
        Task<List<RentalResponceDto>> GetRentalsByCustomerId(int customerId);
        Task<List<RentalResponceDto>> GetRentalsByCategoryId(int categoryId);
        Task<List<RentalResponceDto>> GetRentalsByDirector(string director);
    }
}
