namespace EUROResultsWithBlazorWASM.Services;

public interface IMatchServices
{
    Task<StandingsResponseDto?> GetStandings();
    Task<MatchesResponseDto?> GetMatches();
}