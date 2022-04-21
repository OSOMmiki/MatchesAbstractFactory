namespace MatchesAbstractFactory.Infrastructure;

public interface ITeam
{
    string Name { get; set; }
    void PlayerExpulsion(Player player);
    Player GetRandomPlayingPlayer();
}
