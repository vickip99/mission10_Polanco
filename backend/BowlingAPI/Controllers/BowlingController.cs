using ASPMission10.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ASPMission10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;

        public BowlingController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }
        [HttpGet]
        public IActionResult GetBowlersWithTeam()
        {
            var bowlersData = _bowlingRepository.Bowlers.Select(b => new
            {
                b.BowlerLastName,
                b.BowlerFirstName,
                b.BowlerMiddleInit,
                b.BowlerAddress,
                b.BowlerCity,
                b.BowlerState,
                b.BowlerZip,
                b.BowlerPhoneNumber,
                TeamName = b.Team != null ? b.Team.TeamName : null
            }).ToList();

            return Ok(bowlersData);
        }

    }
}
