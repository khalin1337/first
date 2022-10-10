using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace first.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // GET: api/<ValuesController>
        [HttpGet]
        public string Get()
        {
            return "Hello";
        }
        // POST api/<ValuesController>
        [HttpPost]
        public string Post([FromBody] string value)
        {
            try
            {
                string sum = new DataTable().Compute(value, null).ToString();
                return sum;
            }
            catch (Exception) {

                return "Не правильный формат";
            }
        }

    }
}
