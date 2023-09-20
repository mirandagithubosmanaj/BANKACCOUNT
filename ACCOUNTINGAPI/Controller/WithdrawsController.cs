using DATABASEE.Models;
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
        private List<Withdraws> withdrawalsList = new List<Withdraws>();

        public WithdrawsController()

        {
            withdrawalsList.Add(new Withdraws { Id = 1, User = 1, Amount = 222, Withdraw_date = DateTime.Now });



            }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get a withdrawal by ID")]
        [ProducesResponseType(typeof(Withdraws), 200)]
        public IActionResult GetWithdrawById(int id)
        {
            Withdraws withdrawsData = GetWithdrawsDataById(id);

            if  (withdrawsData == null)

            {

                return NotFound();
            }    


            return Ok(withdrawsData);
        }

        private Withdraws  GetWithdrawsDataById(int id)

        {
            var  withdraws=withdrawalsList.FirstOrDefault(Withdraws => Withdraws.Id == id);


            return withdraws;
        }




        [HttpPost]
        [SwaggerOperation(Summary = "Create a new withdrawal")]
        [ProducesResponseType(typeof(Withdraws), 201)]
        public IActionResult CreateWithdraw([FromBody] Withdraws newWithdraw)
        {
            // Krijoni logjikën për të krijuar një tërheqje të re
            // ...

            return CreatedAtAction(nameof(GetWithdrawById), new { id = newWithdraw.Id }, newWithdraw);
        }

        // Shtoni metoda të tjera të ngjashme dhe anotime të Swagger sipas nevojës
    }



















}

