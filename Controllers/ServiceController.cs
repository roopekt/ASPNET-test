using Microsoft.AspNetCore.Mvc;
using Task1.Domain.Services;

namespace Task1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : ControllerBase
    {
        public static List<Service> Services = new List<Service> {
            new Service(
                "0",
                new DateTime(2000, 3, 4),
                new Device("0000", "S22", "Samsung")
            )
        };

        private readonly ILogger<ServiceController> _logger;

        public ServiceController(ILogger<ServiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get-service")]
        public Service GetService(string id)
        {
            #pragma warning disable CS8603 // Possible null reference return.
            return Services.FirstOrDefault(x => x.Id == id);
            #pragma warning restore CS8603
        }

        [HttpGet("get-all-services")]
        public IEnumerable<Service> GetAllServices()
        {
            return Services;
        }

        [HttpPost("add-service")]
        public void AddService(Service service)
        {
            Services.Add(service);
        }
    }
}