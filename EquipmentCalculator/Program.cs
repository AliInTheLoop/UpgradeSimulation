using EquipmentCalculator.SimulationSystem.EquipmentSystem;
using EquipmentCalculator.SimulationSystem.ItemsToUpgrade.TotalUsedMaterials;
using EquipmentCalculator.SimulationSystem.UpgradeSystem.FailStackManager;

namespace EquipmentCalculator;


class Program
{
    static void Main(string[] args)
    {
        ConsumedMaterials result = new EquipLvl().UpgradeSimulation(0);
        Console.WriteLine($"{result}");

        AnvilFull check = new AnvilFull();
        Console.WriteLine($"Test: {check.IsAnvilFull(0)}");
    }
}