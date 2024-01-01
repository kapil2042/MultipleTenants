using Microsoft.AspNetCore.Mvc;
using MultipleTenants.Data;
using MultipleTenants.Models;
using MultipleTenants.Repository;

namespace MultipleTenants.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductGenericRepo<Products> _repo;
        public ProductsController(IProductGenericRepo<Products> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _repo.GetAllAsync());
        }


        [HttpPost]
        public async Task<IActionResult> CreateAsync(Products products)
        {
            return Ok(await _repo.AddAsync(products));
        }
    }
}
