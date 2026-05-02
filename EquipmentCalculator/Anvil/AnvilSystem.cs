namespace EquipmentCalculator.Anvil;

public class AnvilSystem
{
    internal int CountAnvilFails { get; set; } = 0;
    
    internal Dictionary<int, int> Guaranteed = new Dictionary<int, int>()
    {
        // Starts from level 2
        // From there how many fails does it need to get a guaranteed chance.
        { 2, 2 }, { 3, 3 }, { 4, 5 }, { 5, 8 }, { 6, 10 }, { 7, 17 }, { 8, 50 }, { 9, 100 }
    };
}