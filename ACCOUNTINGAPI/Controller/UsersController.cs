using DATABASEE.Models;
using DATABASEE.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ACCOUNTINGAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        private readonly IRepository<Users> _repository;

        public UsersController(ILogger<UsersController> logger, IRepository<Users> repository)
        {
            _repository = repository;

            _logger = logger;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetUsersById(int Id, CancellationToken token)
        {
            Users usersData = await _repository.Get(Id, token);

            if (usersData == null)

            {
                return NotFound();
            }
            return Ok(usersData);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsers(Users newUsers)
        {
            await _repository.Add(newUsers);
            return Ok(newUsers);
        }
    }
}
