namespace EquipmentCalculator.SimulationSystem.EquipmentSystem;
using ItemsToUpgrade.TotalUsedMaterials;
using UpgradeSystem;


public class EquipLvl
{
    internal int CurrentLevel { get; set; }
    private readonly Random _rand = new Random();
    internal ConsumedMaterials Sum { get; set; }

    internal EquipLvl(int attempts, int regRolls, int crystal, int ratesUsed, int silverCost)
    {
        Sum = new ConsumedMaterials()
        {
            TotalAttempts = attempts,
            TotalRegRolls = regRolls,
            TotalPrestineCrystals = crystal,
            TotalRatesUsed = ratesUsed,
            TotalSilverCost = silverCost
        };
    }
    
    internal EquipLvl() : this(0,0,0,0,0)
    {
        
    }
    


    internal ConsumedMaterials UpgradeSimulation(int currentLevel)
    {
        CurrentLevel = currentLevel;
        ConsumedMaterials sum = new ConsumedMaterials();
        
        while (CurrentLevel < 10)
        {
            double roll = _rand.NextDouble() * 100;
            
            if (LevelSuccessRates.UpgradeInformation.TryGetValue(CurrentLevel, out  double currentChance))
            {
                Console.WriteLine($"Current Level: {CurrentLevel}");
                Console.WriteLine($"Current Attempt: {Attempts}");
                Console.WriteLine($"Roll: {roll:F2}");
                Console.WriteLine($"For Success: {currentChance}% or less.");
                
                if (roll < currentChance)
                {
                    sum.TotalRegRolls++;
                    sum.TotalPrestineCrystals++;
                    sum.TotalRatesUsed++;
                    sum.TotalSilverCost++;
                    Console.WriteLine($"Lvl UP: {++CurrentLevel}\n");
                }
                else
                {
                    if (CurrentLevel < 1)
                    {
                        CurrentLevel = 0;
                        sum.TotalRegRolls++;
                        sum.TotalPrestineCrystals++;
                        sum.TotalRatesUsed++;
                        sum.TotalSilverCost++;
                    }
                    else
                    {
                        sum.TotalRegRolls++;
                        sum.TotalPrestineCrystals++;
                        sum.TotalRatesUsed++;
                        sum.TotalSilverCost++;
                        Console.WriteLine($"Fail Lvl down: {--CurrentLevel}\n");
                    }
                    if (Attempts > 99)
                    {
                        break;
                    }
                }
                Attempts++;
            }
        }

        return new ConsumedMaterials();
    }
}