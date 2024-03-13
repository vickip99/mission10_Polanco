using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ASPMission10.Models
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlingcontext;

        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _bowlingcontext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlingcontext.Bowlers
            .Include(b => b.Team) // Include the Team entity
            .Where(b => b.Team != null && (b.Team.TeamName == "Sharks" || b.Team.TeamName == "Marlins"))
            .ToList();
    }
}
