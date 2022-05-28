using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSegregationDependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IAnimalFeeder _animalFeeder;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IAnimalFeeder animalFeeder)
        {
            _logger = logger;
            _animalFeeder = animalFeeder;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _animalFeeder.Feed(new Dog());
            _animalFeeder.Feed(new Bird());

            return Ok("Hayvanlar Beslendi");
        }
    }
}
