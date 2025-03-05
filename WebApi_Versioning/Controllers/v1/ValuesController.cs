//using Asp.Versioning;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace WebApi_Versioning.Controllers.v1
//{
//    [Route("api/v{version:apiVersion}/[con troller]")]
//    [ApiController]
//    [ApiVersion("1.0")]
//    public class ValuesController : ControllerBase
//    {
//        // GET: api/<ValuesController>
//        [HttpGet]
//        [MapToApiVersion("1.0")]
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "Map values to v1" };
//        }


//        [HttpGet]
//        [MapToApiVersion("2.0")]
//        public IEnumerable<string> GetV2()
//        {
//            return new string[] { "Map values to v2" };
//        }


//        // GET api/<ValuesController>/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/<ValuesController>
//        [HttpPost]
//        public void Post([FromBody] string value)
//        {
//        }

//        // PUT api/<ValuesController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        DELETE api/<ValuesController>/5
//[HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
