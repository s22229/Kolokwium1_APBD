using Kolokwium1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        IDbService _dbService;

        public ApiController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        [Route("api/medicaments/{IdMedicament}")]
        public IActionResult getMedicament(int IdMedicament)
        {
            return Ok(_dbService.GetMedicament(IdMedicament));
        }

        /*
        [HttpDelete]
        [Route("api/patients/{IdPatient}")]
        public IActionResult deletePatient(int IdPateint)
        {
            //return Ok(_dbService.DeletePatient(IdPateint));
        }
        */
    }
}
