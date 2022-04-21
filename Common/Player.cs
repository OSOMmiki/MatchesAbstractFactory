using MatchesAbstractFactory.Infrastructure.Enumerations;

namespace MatchesAbstractFactory;

public class Player
{
    public Player()
    {
        Sanctions = new List<SanctionType>();
    }
    
    public string Name { get; set; }
    public string Dorsal { get; set; }
    public List<SanctionType> Sanctions{ get; set; }
}