using EquipmentCalculator.SimulationSystem.EquipmentSystem;
using EquipmentCalculator.SimulationSystem.ItemsToUpgrade.TotalUsedMaterials;

namespace EquipmentCalculator;


class Program
{
    static void Main(string[] args)
    {
        ConsumedMaterials result = new EquipLvl().UpgradeSimulation();
        Console.WriteLine($"{result}");
    }
}