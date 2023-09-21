using DATABASEE.Models;
using DATABASEE.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Annotations;

namespace ACCOUNTINGAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class WithdrawsController : ControllerBase
    {
        private readonly ILogger<WithdrawsController> _logger;

        private readonly IRepository<Withdraws> _repository;

        public WithdrawsController(ILogger<WithdrawsController> logger, IRepository<Withdraws> repository)
        {
            _repository = repository;

            _logger = logger;
        }


        [HttpGet("{Id}")]
        public async Task<IActionResult> GetWithdrawById(int Id, CancellationToken token)
        {
            Withdraws withdrawsData = await _repository.Get(Id, token);

            if  (withdrawsData == null)

            {

                return NotFound();
            }    


            return Ok(withdrawsData);
        }



        [HttpPost]
        public async Task<IActionResult> CreateWithdraw(Withdraws newWithdraw)
        {
            await _repository.Add(newWithdraw);
            return Ok(newWithdraw);
        }


    }



















}

