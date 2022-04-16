using Microsoft.AspNetCore.Mvc;
using System.Linq; 
using blog.business.repositories; 

namespace blog.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categortRepository)
        {
            this._categoryRepository = categortRepository;
        }
        [HttpGet]
        public IActionResult GetProductList()
        {
            var values = _categoryRepository.GetAll();
            return Ok(values);
        }
        public object Get()
        {
            return _categoryRepository.GetAll().Select(x => new
            {
                x.Id,
                x.Name
            });
        }
    }
}