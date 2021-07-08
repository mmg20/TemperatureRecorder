using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using telemed.Attributes;
using telemed.DTO;
using telemed.Model;

namespace telemed.Controllers
{
    [Auth]
    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {

        private readonly ILogger<TemperatureController> logger;
        private readonly TemperatureContext db;

        public TemperatureController(
            ILogger<TemperatureController> logger,
            TemperatureContext db
            )
        {
            this.logger = logger;
            this.db = db;
        }

        [HttpPost]
        public IActionResult GetTemp(AddTemperature newTemperature)
        {
            db.Temperatures.Add(new Temperature(
                newTemperature.value,
                newTemperature.location,
                newTemperature.sensorName
            ));
            db.SaveChanges();

            return Ok(new { ok = "ok" });
        }

        [HttpGet]
        public IEnumerable<Temperature> Get()
        {
            return db.Temperatures.ToList();
        }
    }
}
