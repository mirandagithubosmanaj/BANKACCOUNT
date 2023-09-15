using DATABASEE.Models;
using DATABASEE.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace ACCOUNTINGAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositsController : ControllerBase
    {
        private readonly IRepository<Deposits> _repository;

        public DepositsController(IRepository<Deposits> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("MerrDepositat/{Id}")]
        public async Task<ActionResult<Deposits>> MerrDepositat(int id, CancellationToken token)
        {
            var deposit = await _repository.Get(id, token);

            if (deposit == null)
            {
                return NotFound();
            }

            return deposit;
        }
    }
}
