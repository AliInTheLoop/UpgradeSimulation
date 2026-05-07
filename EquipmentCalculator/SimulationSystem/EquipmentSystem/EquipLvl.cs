namespace EquipmentCalculator.SimulationSystem.EquipmentSystem;
using UpgradeSystem;
using ItemsToUpgrade.TotalUsedMaterials;


public class EquipLvl
{
    internal int CurrentLevel { get; set; }
    private Random _rand = new Random();
    

    internal int UpgradeSimulation(int currentLevel)
    {
        CurrentLevel = currentLevel;
        double roll = _rand.NextDouble() * 100;

        return currentLevel;
    }
}

