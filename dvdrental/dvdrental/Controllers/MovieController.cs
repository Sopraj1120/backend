using dvdrental.DTOs.RequestDtos;
using dvdrental.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dvdrental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMoviesService _movieService;

        public MovieController(IMoviesService movieService)
        {
            _movieService = movieService;
        }

     
    }
}
