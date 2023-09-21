using DATABASEE.Models;
using DATABASEE.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ACCOUNTINGAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class User_rolesController : ControllerBase
    {
        private readonly ILogger<User_rolesController> _logger;

        private readonly IRepository<User_roles> _repository;

        public User_rolesController(ILogger<User_rolesController> logger, IRepository<User_roles> repository)
        {
            _repository = repository;

            _logger = logger;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetUser_rolesById(int Id, CancellationToken token)
        {
            User_roles User_rolesData = await _repository.Get(Id, token);

            if (User_rolesData == null)

            {
                return NotFound();
            }
            return Ok(User_rolesData);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser_roles(User_roles newUser_roles)
        {
            await _repository.Add(newUser_roles);
            return Ok(newUser_roles);
        }
    }
}
