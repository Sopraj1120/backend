using dvdrental.DTOs;
using dvdrental.DTOs.RequestDtos;
using dvdrental.DTOs.ResponceDtos;
using dvdrental.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace dvdrental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalRequestController : ControllerBase
    {
        private readonly IRentalRequestService _rentalRequestService;
        private readonly IFileService _fileService;

        public RentalRequestController(IRentalRequestService rentalRequestService)
        {
            _rentalRequestService = rentalRequestService;
        }

        [HttpPost]
        [Route ("AddRentalRequest")]
        public async Task<IActionResult> AddRentalRequest([FromForm] RentalRequestDto rentalRequestDto)
        {
         
            if (rentalRequestDto == null)
            {
                return BadRequest("Rental request data is required.");
            }

            // Call the service to add the rental request
            var rentalResponseDto = await _rentalRequestService.AddRentalRequest(rentalRequestDto);

            // Return a Created response with the new rental request details
            return CreatedAtAction(nameof(AddRentalRequest), new { id = rentalResponseDto.Id }, rentalResponseDto);
        }

        // PUT: api/rentalrequest/accept/{id}
        [HttpPut("accept/{id}")]
        public async Task<IActionResult> AcceptRentalRequest(int id,  bool isAccepted)
        {
           
            var result = await _rentalRequestService.AcceptRentalRequest(id, isAccepted);

            
            if (result)
            {
                return NoContent(); // 204 No Content
            }
            return NotFound(); // 404 Not Found
        }
        [HttpGet("get-All-RentalRequest")]
        public async Task<IActionResult> GetAllRentalRequests()
        {
            var data= await _rentalRequestService.GetAllRentalRequests();
            return Ok(data);
        }
        [HttpGet("get-All-rentelrequests-bymovieId")]
        public async Task<IActionResult> GetRentalsByMovieId(int movieId)
        {
          var data=_rentalRequestService.GetRentalsByMovieId(movieId);
            return Ok(data);
        }
        [HttpGet("get-all-rentelrequest-bycustomerid")]
        public async Task<IActionResult> GetRentalsByCustomerId(int customerId)
        {
            var data=_rentalRequestService.GetRentalsByCustomerId(customerId);
            return Ok(data);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        }

        [HttpGet("get-all-rentelrequest-byId/{id}")]
        public async Task<IActionResult> GetRentalRequestById(int id)
        {
            var data = await _rentalRequestService.GetRentalRequestById(id);

            if (data == null)
            {
                return NotFound(new { Message = "Rental request not found" });
            }

            return Ok(data);
        }

        [HttpGet("category/{categoryId}")]
        public async Task<IActionResult> GetRentalsByCategoryId(int categoryId)
        {
            var data = await _rentalRequestService.GetRentalsByCategoryId(categoryId);

            if (data == null || !data.Any())
            {
                return NotFound(new { Message = "No rental requests found for this category." });
            }

            return Ok(data);
        }

        [HttpGet("director/{director}")]
        public async Task<IActionResult> GetRentalsByDirector(string director)
        {
            // Validate the input
            if (string.IsNullOrWhiteSpace(director))
            {
                return BadRequest(new { Message = "Director name cannot be empty." });
            }

            var data = await _rentalRequestService.GetRentalsByDirector(director);

            if (data == null || !data.Any())
            {
                return NotFound(new { Message = "No rental requests found for this director." });
            }

            return Ok(data);
        }




    }

}
