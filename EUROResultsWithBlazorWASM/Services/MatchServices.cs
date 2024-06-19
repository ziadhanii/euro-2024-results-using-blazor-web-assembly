using System.Net.Http.Json;
using EUROResultsWithBlazorWASM.Dtos.Matches;
using EUROResultsWithBlazorWASM.Dtos.Standings;

namespace EUROResultsWithBlazorWASM.Services;

public class MatchServices : IMatchServices
{
    private readonly HttpClient _http;

    private const string _baseUrl = "https://api.football-data.org/v4";

    public MatchServices(HttpClient http)
    {
        _http = http;
        _http.DefaultRequestHeaders.Add("X-Auth-Token", "YOUR_API_KEY HERE FOR FOOTBALL DATA API");

    }

    public async Task<StandingsResponseDto?> GetStandings()
    {

        return await _http.GetFromJsonAsync<StandingsResponseDto>($"{_baseUrl}/competitions/EC/standings");
    }

    public async Task<MatchesResponseDto?> GetMatches()
    {
        var date = DateTime.Today.ToString("yyyy-MM-dd");
        return await _http.GetFromJsonAsync<MatchesResponseDto>($"{_baseUrl}//competitions/EC/matches?dateFrom={date}&dateTo={date}");
    }
}