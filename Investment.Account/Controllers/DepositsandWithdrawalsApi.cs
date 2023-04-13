using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

using Investment.Account.Requestresponse;
using Investment.Account.Repository;
using Investment.Account.Models;

namespace Investment.Account.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DepositsandWithdrawalsApiController : ControllerBase
    {
        private InvestmentAccountContext _ctx;

        public DepositsandWithdrawalsApiController(InvestmentAccountContext ctx)
        {
            _ctx = ctx;
        }


        /// <summary>
        /// Execute a securities deposit or withdrawal transaction
        /// </summary>
        /// <remarks>Execute a securities deposit or withdrawal transaction</remarks>
        /// <param name="body"></param>
        /// <param name="customerreference"></param>
        /// <param name="investmentaccountid"></param>
        /// <response code="200">DepositsandWithdrawals</response>
        /// <response code="400">BadRequest</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">NotFound</response>
        /// <response code="429">TooManyRequests</response>
        /// <response code="500">InternalServerError</response>
        [HttpPost]
        [Route("/{customerreference}/InvestmentAccount/{investmentaccountid}/DepositsandWithdrawals")]
        public virtual IActionResult ExecuteDepositsandWithdrawals([FromBody] ExecuteDespositWithdrawlRequest body, [FromRoute][Required] string customerreference, [FromRoute][Required] string investmentaccountid)
        {
            // Er der tale om withdrawl, skal vi checke om der er 'nok at sælge ud af'
            InvestmentAccountEntry entry = new InvestmentAccountEntry()
            {
                CustomerReference = customerreference,
                InvestmentAccountNumber = investmentaccountid,
                InstrumentReference = body.InstrumentReference,
                PricePrShare = body.PricePrShare,
                InstrumentType = body.InstrumentType,
                Quantity = body.Quantity,
                TradingDate = body.TradingDate
            };

            _ctx.InvestmentAccountEntry.Add(entry);
            _ctx.SaveChanges();

            ExecuteDespositWithdrawlResponse res = new ExecuteDespositWithdrawlResponse()
            {
                CustomerReference = entry.CustomerReference,
                InstrumentReference = entry.InstrumentReference,
                InstrumentType = entry.InstrumentType,
                InvestmentAccountNumber = entry.InvestmentAccountNumber,
                InvestmentEntryId = entry.InvestmentEntryId,
                PricePrShare = entry.PricePrShare,
                Quantity = entry.Quantity,
                TradingDate = entry.TradingDate
            };
            return StatusCode(200, res);
        }


        /// <summary>
        /// Retrieve details about a securities deposit or withdrawal action
        /// </summary>
        /// <remarks>Retrieve details about a securities deposit or withdrawal action</remarks>
        /// <param name="customerreference"></param>
        /// <param name="investmentaccountid"></param>
        /// <response code="200">RetrieveDepositsandWithdrawalsResponse</response>
        /// <response code="400">BadRequest</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">NotFound</response>
        /// <response code="429">TooManyRequests</response>
        /// <response code="500">InternalServerError</response>
        [HttpGet]
        [Route("/{customerreference}/InvestmentAccount/{investmentaccountid}/DepositsandWithdrawals")]
        public virtual IActionResult RetrieveDepositsandWithdrawals([FromRoute][Required] string customerreference, [FromRoute][Required] string investmentaccountid)
        {
            var result = (from entries in _ctx.InvestmentAccountEntry
                          where entries.InvestmentAccountNumber == investmentaccountid && entries.CustomerReference == customerreference
                          select entries).ToList<InvestmentAccountEntry>();

            return StatusCode(200, result);
        }

    }
}
