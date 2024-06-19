using EUROResultsWithBlazorWASM.Dtos.Matches;
using EUROResultsWithBlazorWASM.Dtos.Standings;

namespace EUROResultsWithBlazorWASM.Services;

public interface IMatchServices
{
    Task<StandingsResponseDto?> GetStandings();
    Task<MatchesResponseDto?> GetMatches();
}