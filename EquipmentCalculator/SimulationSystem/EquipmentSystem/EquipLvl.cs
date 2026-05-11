namespace EquipmentCalculator.SimulationSystem.EquipmentSystem;
using ItemsToUpgrade.TotalUsedMaterials;
using UpgradeSystem;


public class EquipLvl
{
    private int CurrentLevel { get; set; }
    private readonly Random _rand = new Random();
    ConsumedMaterials sum = new ConsumedMaterials();

    private EquipLvl(int currentLevel)
    {
        CurrentLevel = currentLevel;
    }

    internal EquipLvl() : this(0)
    {
        
    }
    
    internal ConsumedMaterials UpgradeSimulation()
    {
        
        while (CurrentLevel < 10)
        {
            double roll = _rand.NextDouble() * 100;
            // each attempt cost 200 rolls and 500 silver
            sum.ConsumedResources(200,500);
            
            if (LevelSuccessRates.UpgradeInformation.TryGetValue(CurrentLevel, out  double currentChance))
            {
                if (roll < currentChance)
                {
                    ++CurrentLevel;
                }
                else
                {
                    if (CurrentLevel < 1)
                    {
                        CurrentLevel = 0;
                    }
                    else
                    {
                        --CurrentLevel;
                    }
                    // TODO: Remove this limit for real simulation or increase it to 1 000 000
                    if (sum.TotalAttempts > 9)
                    {
                        break;
                    }
                }
            }
        }
        // return the accumulated materials ( Consumed.Materials.ToString handles the formatting)
        return sum;
    }
}