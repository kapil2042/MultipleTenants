using Microsoft.AspNetCore.Mvc;
using MultipleTenants.Data;
using MultipleTenants.Models;
using MultipleTenants.Repository;

namespace MultipleTenants.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserGenericRepo<Users> _repo;
        public UserController(IUserGenericRepo<Users> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _repo.GetAllAsync());
        }


        [HttpPost]
        public async Task<IActionResult> CreateAsync(Users users)
        {
            return Ok(await _repo.AddAsync(users));
        }
    }
}
