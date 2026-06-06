namespace EquipmentCalculator.SimulationSystem.UpgradeSystem.LevelManager;
using EquipmentSystem;
using ItemsToUpgrade.TotalUsedMaterials;

public class Leveling : Anvil
{
    private int _currentLevel;
    private readonly Random _rand = new();
    private  readonly ConsumedMaterials _count = new(); // create a new instance  of the class.

    private Leveling(int currentLevel)
    {
        _currentLevel = currentLevel;
    }

    internal Leveling() : this(0){}

    internal ConsumedMaterials EquipmentLeveling() 
    {
        while (_currentLevel <= 10)
        {
            _count.ConsumedResources(200,200); // add 200 per try to the result for silver and regRolls
            double roll = _rand.NextDouble() * 100;

            if (LevelSuccessRates.UpgradeInformation.TryGetValue(_currentLevel, out double succOrFail))
            {

                Console.WriteLine($"Trie: {_count.TotalAttempts}\n" +
                                  $"Current Level: {_currentLevel}\n" +
                                  $"Roll: {roll:F2} | Rates: {succOrFail}");
                
                
                if (roll < succOrFail)
                {
                    Console.WriteLine($"Level after success: {++_currentLevel}");
                }
                else
                {
                    if (roll > succOrFail && _currentLevel == 0)
                    {
                        _currentLevel = 0;
                        Console.WriteLine($"Fail {_currentLevel}");
                    }
                    else
                    {
                        Console.WriteLine($"Level after fail: {--_currentLevel}");
                    }
                }
                Console.WriteLine();
                if (_count.TotalAttempts >= 10) break;
            }
        }
        return _count;
    }
}