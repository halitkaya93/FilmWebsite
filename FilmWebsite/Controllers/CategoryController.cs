using FilmWebsite.Data.Repositories;
using FilmWebsite.WebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmWebsite.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var categories = _categoryRepository.GetAll();
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var category = _categoryRepository.GetById(id);
            return Ok(category);
        }
        [HttpPost]
        public IActionResult Post([FromBody]AddCategoryModel category)
        {
            _categoryRepository.Create(new Data.Entities.Category
            {
                //CreateDate=category
            });
            return Ok();
        }
    }
}
