using dvdrental.DTOs.RequestDtos;
using dvdrental.DTOs.ResponceDtos;
using dvdrental.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dvdrental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalRequestController : ControllerBase
    {
        private readonly IRentalRequestService _rentalRequestService;

        public RentalRequestController(IRentalRequestService rentalRequestService)
        {
            _rentalRequestService = rentalRequestService;
        }

     
       
    }

}
