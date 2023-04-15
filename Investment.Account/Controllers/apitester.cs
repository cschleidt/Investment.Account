using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Investment.Account.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Apitester : ControllerBase
    {
        // GET: api/<apitester>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<apitester>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<apitester>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<apitester>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<apitester>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
