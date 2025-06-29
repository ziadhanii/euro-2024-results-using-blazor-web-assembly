namespace EUROResultsWithBlazorWASM.Dtos.Matches;

public class ScoreDto
{
    public IntervalScoreDto halfTime { get; set; }
    public IntervalScoreDto? fullTime { get; set; }
}
