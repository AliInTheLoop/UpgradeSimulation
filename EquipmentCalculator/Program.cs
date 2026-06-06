namespace EquipmentCalculator;
using SimulationSystem.UpgradeSystem.LevelManager;
using SimulationSystem.ItemsToUpgrade.TotalUsedMaterials;

class Program
{
    static void Main(string[] args)
    {
        ConsumedMaterials lvl = new Leveling().EquipmentLeveling();
        
        Console.WriteLine(lvl);
        
    }
}