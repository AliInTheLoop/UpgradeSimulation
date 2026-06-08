namespace EquipmentCalculator.SimulationSystem.UpgradeSystem.LevelManager;
using EquipmentSystem;
using ItemsToUpgrade.TotalUsedMaterials;


public class Leveling
{
    // In Leveling.cs
    private  int CurrentLevel { get; set; }
    private readonly Random _rand = new();
    private  readonly ConsumedMaterials _count = new(); // create a new instance  of the class.

    internal Leveling(int currentLevel)
    {
        CurrentLevel = currentLevel;
    }

    internal Leveling() : this(0){}
    

    internal ConsumedMaterials EquipmentLeveling() 
    {
        while (CurrentLevel <= 10)
        {
            _count.ConsumedResources(200,200); // add 200 per try to the result for silver and regRolls
            double roll = _rand.NextDouble() * 100; // roll between 0.1 => 99.9

            if (LevelSuccessRates.UpgradeInformation.TryGetValue(CurrentLevel, out double succOrFail))
            {
                Console.WriteLine($"Trie: {_count.TotalAttempts}\n" +
                                  $"Current Level: {CurrentLevel}\n" +
                                  $"Roll: {roll:F2} | Rates: {succOrFail}");
                
                if (roll < succOrFail)
                {
                    Console.WriteLine($"Level after success: {++CurrentLevel}");
                }
                else
                {
                    if (roll > succOrFail && CurrentLevel == 0)
                    {
                        CurrentLevel = 0;
                        Console.WriteLine($"Fail {CurrentLevel}");
                    }
                    else
                    {
                        Console.WriteLine($"Level after fail: {--CurrentLevel}");
                    }
                }
                Console.WriteLine();
                if (_count.TotalAttempts >= 10) break;
            }
        }
        return _count;
    }
}