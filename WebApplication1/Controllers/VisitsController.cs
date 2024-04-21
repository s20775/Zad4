/*using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

[Route("api/visits")]
[ApiController]
    public class VisitsController : ControllerBase
    {

        private static readonly List<Visit> _visits = new()
        {
            new Visit {VisitDate = DateTime.Now.AddDays(-5), Animal = Animal[0], Description = "Rutynowa wizyta", Price = 99},

        };


    [HttpGet]
    public IActionResult GetVisits()
    {
        return Ok(_visits);
    }


    [HttpPost]
    public IActionResult CreateVisit(Visit visit)
    {
        _visits.Add(visit);
        return StatusCode(StatusCodes.Status201Created);
    }
    }
}
*/