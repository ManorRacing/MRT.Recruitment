using System;
using System.Collections.Generic;
using Manor.DreamTeam.Recruitment.Domain;
using Manor.DreamTeam.Recruitment.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Manor.DreamTeam.Recruitment.Controllers
{
    [Route("api/[controller]")]
    public class TelemetryController : Controller
    {
        private readonly IRepository<Telemetry> _telemetryRepo;

        public TelemetryController(IRepository<Telemetry> telemetryRepo)
        {
            _telemetryRepo = telemetryRepo;
        }

        // GET: api/telemetry
        [HttpGet]
        public IEnumerable<Telemetry> Get()
        {
            throw new NotImplementedException();
        }

        // GET api/telemetry/chassis/CH1
        [HttpGet("chassis/{chassis}")]
        public Telemetry GetByChassis(string chassis)
        {
            throw new NotImplementedException();
        }

        // GET api/telemetry/lap/23
        [HttpGet("lap/{lap}")]
        public Telemetry GetByLap(int lap)
        {
            throw new NotImplementedException();
        }
    }
}
