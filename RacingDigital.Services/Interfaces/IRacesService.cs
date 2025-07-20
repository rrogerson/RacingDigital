using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RacingDigital.Models;

namespace RacingDigital.Services.Interfaces
{
    public interface IRacesService
    {
        IEnumerable<RaceResult> GetRaces();
        IEnumerable<Notes> GetNotes(int raceId);
        int AddNotes(Notes item);
    }
}
        
