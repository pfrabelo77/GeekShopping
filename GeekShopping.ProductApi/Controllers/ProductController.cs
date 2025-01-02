using GeekShopping.ProductApi.Data.ValueObjects;
using GeekShopping.ProductApi.Model;
using GeekShopping.ProductApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductApi.Controllers
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }



        [HttpGet("FindAll")]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
        {
            var products = await _repository.FindAll();
            if (products == null) { return NotFound(); }
            return Ok(products);

        }

        [HttpGet("FindById/{id}")]
        public async Task<ActionResult<ProductVO>> FindById(long id)
        {
            var product = await _repository.FindById(id);
            if (product == null) {return NotFound();}
            return Ok(product);
            
        }

        [HttpPost("Create")]
        public async Task<ActionResult<ProductVO>> Create([FromBody] ProductVO productVO)
        {
           if (productVO == null) { return BadRequest(); }
           var product = await _repository.Create(productVO);

            return Ok(product);

        }

        [HttpPut("Update")]
        public async Task<ActionResult<ProductVO>> Update([FromBody] ProductVO productVO)
        {
            if (productVO == null) { return BadRequest(); }
            var product = await _repository.Update(productVO);

            return Ok(product);

        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (status == false) { return BadRequest(); }
            return Ok(status);

        }

    }
}
