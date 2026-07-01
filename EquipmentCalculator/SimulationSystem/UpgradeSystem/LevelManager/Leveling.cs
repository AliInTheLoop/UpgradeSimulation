namespace EquipmentCalculator.SimulationSystem.UpgradeSystem.LevelManager;
using ItemsToUpgrade.TotalUsedMaterials;
using FailStackManager;


public class Leveling
{
    // In Leveling.cs
    private  int CurrentLevel { get; }
    private  readonly ConsumedMaterials _count = new(); // create a new instance  of the class.
    private readonly Anvil _anvil = new();

    private  Leveling(int currentLevel)
    {
        CurrentLevel = currentLevel;
    }

    internal Leveling() : this(0){}
    

    internal ConsumedMaterials EquipmentLeveling() 
    {
        while (CurrentLevel <= 10)
        {
            _count.ConsumedResources(200,200); // add 200 per try to the result for silver and regRolls
            
            
            if (_anvil.GetRandomNumber())
            {
                Console.WriteLine();
                if (_count.TotalAttempts >= 20) break;
            }
        }
        return _count;
    }
}