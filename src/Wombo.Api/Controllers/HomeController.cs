using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Wombo.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IConfiguration _configuration;

        public HomeController(IWebHostEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetStatus()
        {
            return Ok(new
            {
                Project = "Wombo API",
                Version = "1.0",
                Environment = $"{_environment.EnvironmentName}",
                Status = "Running",
                AppSettings = new 
                {
                    AppName = _configuration["AppSettings:AppName"],
                    AppDescription = _configuration["AppSettings:AppDescription"]
                } 
            });
        }
    }
}
