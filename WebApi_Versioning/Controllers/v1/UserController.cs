using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;


namespace WebApi_Versioning.Controllers.v1;


[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
[ApiVersion("1.0", Deprecated = true)]

public class UserController : ControllerBase
{
    // GET: api/<UserController>

    //GET api/v1/user
  
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Version 1 " };
    }

    // GET api/<UserController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<UserController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<UserController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
