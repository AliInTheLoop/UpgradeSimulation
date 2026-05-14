namespace EquipmentCalculator.SimulationSystem.UpgradeSystem;

/*
    The point of the Anvil system is that, if a certain level has reached max fail attempts, the next attempt will be
    guaranteed to level up. It will remove then the accumulated fail stack for the corresponded level only.
    This principal will hold for all levels.
*/
public class AnvilSystem
{
    internal int Level { get; set; }
    
        
    internal Dictionary<int, int> MaxAttemptsToLvlUp = new()
    {
        // current level | attempts needed for guaranteed level up 
        { 2, 2 }, { 3, 3 }, { 4, 5 }, { 5, 8 }, { 6, 10 }, { 7, 17 }, { 8, 50 }, { 9, 100 }
    };

    private AnvilSystem(int level)
    {
        Level = level;
    }

    internal AnvilSystem() : this(0)
    {
        
    }
}