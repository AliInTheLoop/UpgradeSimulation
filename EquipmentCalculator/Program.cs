namespace EquipmentCalculator;
using EquipmentCalculator.SimulationSystem.ItemsToUpgrade.TotalUsedMaterials;
using SimulationSystem.UpgradeSystem.LevelManager;
using SimulationSystem.EquipmentSystem;
using EquipmentCalculator.SimulationSystem.ItemsToUpgrade.ForASaverEnchant;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose your Akhram: (50 % type 1 for 100% type 2)");
        int getAkhram = int.Parse(Console.ReadLine() ?? string.Empty);

        ConsumedMaterials level = new Leveling().EquipmentLeveling(getAkhram);
        Console.WriteLine(level);
    }
}
