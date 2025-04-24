using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        // GET /hello
        [HttpGet]
        public string Get()
        {
            return "Hello, World!";
        }

        // GET /hello/{name}
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return $"Hello, {name}!";
        }
    }
}
