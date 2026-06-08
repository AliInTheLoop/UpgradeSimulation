using EquipmentCalculator.SimulationSystem.ItemsToUpgrade.TotalUsedMaterials;

namespace EquipmentCalculator;
using SimulationSystem.UpgradeSystem.LevelManager;
using SimulationSystem;

class Program
{
    static void Main(string[] args)
    {
        ConsumedMaterials level = new Leveling().EquipmentLeveling();
        
        Console.WriteLine(level);
    }
}