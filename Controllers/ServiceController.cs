using Microsoft.AspNetCore.Mvc;
using Task1.Domain.Services;

namespace Task1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : ControllerBase
    {
        public List<Service> Services;

        private readonly ILogger<ServiceController> _logger;

        public ServiceController(ILogger<ServiceController> logger)
        {
            _logger = logger;

            Services = new List<Service> {
                new Service(
                    "0",
                    new DateTime(2000, 3, 4),
                    new Device("0000", "S22", "Samsung")
                )
            };
        }
    }
}