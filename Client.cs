using System.Security.Cryptography;
using MatchesAbstractFactory.Infrastructure;
using MatchesAbstractFactory.Infrastructure.Enumerations;

namespace MatchesAbstractFactory;

public class Client
{
    private readonly IMatchFactory _matchFactory;
    
    public Client(IMatchFactory matchFactory)
    {
        _matchFactory = matchFactory;
    }

    public void SimulateMatch()
    {
        ITeam localTeam = _matchFactory.CreateTeam();
        ITeam visitorTeam = _matchFactory.CreateTeam();
        IMatchScoreboard scoreboard = _matchFactory.CreateScoreboard();
        IReferee referee = _matchFactory.CreateReferee();

        while (scoreboard.Duration-- > 0)
        {
            switch (RandomNumberGenerator.GetInt32(0, 4))
            {
                case 0:
                    SimulatePlayerInfraction(localTeam, referee);
                    break;
                case 1:
                    SimulatePlayerInfraction(visitorTeam, referee);
                    break; 
                case 2:
                    scoreboard.ScoreLocal();
                    break;
                case 3:
                    scoreboard.ScoreVisitor();
                    break;
            }
        }
        NotifyWinner(scoreboard);
    }
    
    private void SimulatePlayerInfraction(ITeam team, IReferee referee)
    {
        Player player = team.GetRandomPlayingPlayer();

        SanctionType sanctionType = referee.SanctionPlayer(player);

        if (sanctionType == SanctionType.Expulsion)
        {
            team.PlayerExpulsion(player);
        }
    }

    private void NotifyWinner(IMatchScoreboard scoreboard)
    {
        var winner = scoreboard.LocalPoints >= scoreboard.VisitorPoints ? "LocalTeam" : "VisitorTeam";
        Console.WriteLine($"The winner is {winner}");
    }
}