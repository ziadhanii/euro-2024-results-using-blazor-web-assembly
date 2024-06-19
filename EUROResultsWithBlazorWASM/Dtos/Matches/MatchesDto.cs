namespace EUROResultsWithBlazorWASM.Dtos.Matches;

public class MatchesDto
{
    public DateTime utcDate { get; set; }
    public string status { get; set; }
    public string group { get; set; }
    public TeamDto homeTeam { get; set; }
    public TeamDto awayTeam { get; set; }
    public ScoreDto score { get; set; }

}
