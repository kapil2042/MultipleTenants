using Microsoft.AspNetCore.Mvc;
using MultiTenant.ChangeConnection.Repository;
using MultiTenat.ChangeConnection.Models;

namespace MultiTenant.ChangeConnection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IGenericRepo<Products> _repo;
        public ProductsController(IGenericRepo<Products> repo)
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
