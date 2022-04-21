using MatchesAbstractFactory.Infrastructure.Enumerations;

namespace MatchesAbstractFactory.Infrastructure;

public interface IReferee
{
    SanctionType SanctionPlayer(Player player);
}