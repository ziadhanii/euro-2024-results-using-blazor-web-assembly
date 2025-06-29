using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace EURO_Results_API.Controllers;

[ApiController]
[Route("[controller]")]
public class EuroController : ControllerBase
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;
    private const string BaseUrl = "https://api.football-data.org/v4";

    public EuroController(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;

        if (!_httpClient.DefaultRequestHeaders.Contains("X-Auth-Token"))
        {
            _httpClient.DefaultRequestHeaders.Add("X-Auth-Token", _configuration["FootballDataApiKey"]);
        }
    }

    [HttpGet("standings")]
    public async Task<IActionResult> GetStandings()
    {
        try
        {
            var response = await _httpClient.GetAsync($"{BaseUrl}/competitions/EC/standings");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Ok(JsonSerializer.Deserialize<object>(content));
            }

            return StatusCode((int)response.StatusCode, "Failed to fetch standings");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpGet("matches")]
    public async Task<IActionResult> GetMatches([FromQuery] string? dateFrom = null, [FromQuery] string? dateTo = null)
    {
        try
        {
            var date = dateFrom ?? DateTime.Today.ToString("yyyy-MM-dd");
            var endDate = dateTo ?? date;

            var response =
                await _httpClient.GetAsync($"{BaseUrl}/competitions/EC/matches?dateFrom={date}&dateTo={endDate}");

            if (!response.IsSuccessStatusCode)
                return StatusCode((int)response.StatusCode, "Failed to fetch matches");

            var content = await response.Content.ReadAsStringAsync();
            return Ok(JsonSerializer.Deserialize<object>(content));
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpGet("matches/today")]
    public async Task<IActionResult> GetTodayMatches()
    {
        var today = DateTime.Today.ToString("yyyy-MM-dd");
        return await GetMatches(today, today);
    }

}