using FilmWebsite.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmRepository _filmRepository;
        public FilmController(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
            var films = GetAll();
            //return BadRequest("Yetkiniz Yok!");
            return Ok(films);   
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var film = _filmRepository.GetById(id);
            return Ok(film);
        }
        //[HttpPost]
        //public IActionResult Post([FromBody]Film film )
        //{

        //}

    }
}
