using MatchesAbstractFactory.Infrastructure;

namespace MatchesAbstractFactory;
public interface IMatchFactory
{
    ITeam CreateTeam();
    IMatchScoreboard CreateScoreboard();
    IReferee CreateReferee();
}