using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Investment.Account.Requestresponse;
using Investment.Account.Repository;

namespace Investment.Account.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class InvestmentAccountFacilityApiController : ControllerBase
    {
        private InvestmentAccountContext _ctx;
        private readonly ILogger _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ctx"></param>
        public InvestmentAccountFacilityApiController(ILogger<InvestmentAccountFacilityApiController> logger, InvestmentAccountContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        /// <summary>
        /// InCR Initiate a new securities investment account
        /// </summary>
        /// <remarks>InCR Initiate a new securities investment account</remarks>
        /// <param name="body"></param>
        /// <response code="200">InitiateInvestmentAccountFacilityResponse</response>
        /// <response code="400">BadRequest</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">NotFound</response>
        /// <response code="429">TooManyRequests</response>
        /// <response code="500">InternalServerError</response>
        [HttpPost]
        [Route("/InvestmentAccount/Initiate")]
        public virtual IActionResult Initiate([FromBody]InitiateInvestmentAccountFacilityRequest body)
        {
            try { 
                var account = new Models.InvestmentAccountFacility()
                {
                    CustomerReference = body.InvestmentAccountFacility.CustomerReference,
                    Date = DateTime.Now.ToString(),
                    DateType = "Account opening",
                    InstrumentPositionHolding = "0",
                    InvestmentAccountType = "Standard Brokerage",
                    ProductInstanceReference = "0"
                };
                _ctx.InvestmentAccount.Add(account);
                _ctx.SaveChanges();

                InitiateInvestmentAccountFacilityResponse res = new()
                {
                    InvestmentAccountFacility = new InitiateInvestmentAccountFacilityResponseInvestmentAccountFacility() { 
                        InvestmentAccountNumber = account.InvestmentAccountNumber,
                        InstrumentPositionHolding = "0"
                    }
                };

                return StatusCode(200, res);
            }
            catch (Exception ex) {
                _logger.LogError(ex.Message, ex);

            }
            return StatusCode(404);
        }

        /// <summary>
        /// ReCR Retrieve information about an investment account - either standard canned reports or selected instance attribute values
        /// </summary>
        /// <remarks>ReCR Retrieve information about an investment account - either standard canned reports or selected instance attribute values</remarks>
        /// <param name="investmentaccountid"></param>
        /// <response code="200">RetrieveInvestmentAccountFacilityResponse</response>
        /// <response code="400">BadRequest</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">NotFound</response>
        /// <response code="429">TooManyRequests</response>
        /// <response code="500">InternalServerError</response>
        [HttpGet]
        [Route("/InvestmentAccount/{investmentaccountid}/Retrieve")]
        public virtual IActionResult Retrieve([FromRoute][Required]string investmentaccountid)
        {
            var account = _ctx.InvestmentAccount.FirstOrDefault(s => s.InvestmentAccountNumber == investmentaccountid);

            RetrieveInvestmentAccountFacilityResponse res = new() { 
                InvestmentAccountFacility = new UpdateInvestmentAccountFacilityRequestInvestmentAccountFacility() { 
                    CustomerReference = account.CustomerReference,
                    InstrumentPositionHolding = account.InstrumentPositionHolding,
                    InvestmentAccountNumber = account.InvestmentAccountNumber,
                    InvestmentAccountType = account.InvestmentAccountType,
                    DateType = account.DateType,
                    ProductInstanceReference = account.ProductInstanceReference
                }
            };
            return StatusCode(200, res);

        }

        /// <summary>
        /// UpCR Update details of an investment account
        /// </summary>
        /// <remarks>UpCR Update details of an investment account</remarks>
        /// <param name="body"></param>
        /// <param name="investmentaccountid"></param>
        /// <response code="200">UpdateInvestmentAccountFacilityResponse</response>
        /// <response code="400">BadRequest</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">NotFound</response>
        /// <response code="429">TooManyRequests</response>
        /// <response code="500">InternalServerError</response>
        [HttpPut]
        [Route("/InvestmentAccount/{investmentaccountid}/Update")]
        public virtual IActionResult Update([FromBody]UpdateInvestmentAccountFacilityRequest body, [FromRoute][Required]string investmentaccountid)
        { 
            return new ObjectResult(null);
        }
    }
}
