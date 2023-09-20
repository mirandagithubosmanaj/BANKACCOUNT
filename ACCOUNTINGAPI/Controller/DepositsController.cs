using DATABASEE.Models;
using DATABASEE.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Threading;
using System.Threading.Tasks;

namespace ACCOUNTINGAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositsController : ControllerBase
    {
        private readonly ILogger<DepositsController> _logger;

        private readonly IRepository<Deposits> _repository;



        public DepositsController(ILogger<DepositsController> logger, IRepository<Deposits> repository)
        {
            _repository = repository;

            _logger = logger;



        }

        [HttpGet]
        [Route("[action]/{Id}")]

        public async Task<Deposits> MerrDepositen(int id, CancellationToken token)
  
        
        
        
        {
            return await _repository.Get(id, token);

        }
}   }  