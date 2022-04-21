namespace MatchesAbstractFactory.Infrastructure;

public interface IMatchScoreboard
{
    int LocalPoints { get; set; }
    int VisitorPoints { get; set; }
    int Duration { get; set; }
    
    void ScoreLocal();
    void ScoreVisitor();
}