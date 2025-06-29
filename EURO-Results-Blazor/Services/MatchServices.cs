namespace EUROResultsWithBlazorWASM.Services;

public class MatchServices(HttpClient http) : IMatchServices
{
    private const string _baseUrl = "https://footballdata.runasp.net/Euro";


    public async Task<StandingsResponseDto?> GetStandings()
    {
        return await http.GetFromJsonAsync<StandingsResponseDto>($"{_baseUrl}/standings");
    }

    public async Task<MatchesResponseDto?> GetMatches()
    {
        return await http.GetFromJsonAsync<MatchesResponseDto>($"{_baseUrl}/matches/today");
    }
}