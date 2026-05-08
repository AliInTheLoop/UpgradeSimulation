namespace EquipmentCalculator.SimulationSystem.EquipmentSystem;
using ItemsToUpgrade.TotalUsedMaterials;
using UpgradeSystem;


public class EquipLvl
{
    internal int CurrentLevel { get; set; }
    private readonly Random _rand = new Random();
    private int Attempts { get; set; }
    


    internal ConsumedMaterials UpgradeSimulation(int currentLevel)
    {
        CurrentLevel = currentLevel;
        ConsumedMaterials sum = new ConsumedMaterials();
        
        while (CurrentLevel < 10)
        {
            double roll = _rand.NextDouble() * 100;
            
            if (LevelSuccessRates.UpgradeInformation.TryGetValue(CurrentLevel, out  double currentChance))
            {
                Console.WriteLine($"Current Attempt: {Attempts} | Current Level: {CurrentLevel}\n" +
                                  $"Current Level: {CurrentLevel} | Roll: {roll:F2} | Success Rate: {currentChance}%\n"+
                                  $"Current Level: {CurrentLevel}\n");
                
                if (roll < currentChance)
                {
                    CurrentLevel++;
                }
                else
                {
                    if (CurrentLevel < 1)
                    {
                        CurrentLevel = 0;
                    }
                    else
                    {
                        CurrentLevel--;
                    }
                    if (Attempts > 99)
                    {
                        break;
                    }
                }
                Attempts++;
            }
        }
        return sum;
    }
}