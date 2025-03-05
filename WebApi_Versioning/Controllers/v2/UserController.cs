using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;


namespace WebApi_Versioning.Controllers.v2;


[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
[ApiVersion("2.0")]
public class UserController : ControllerBase
{
    // GET: api/<UserController>

  
    //GET api/v2/user
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Version 2" };
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


}
