using EquipmentCalculator.SimulationSystem.EquipmentSystem;
using EquipmentCalculator.SimulationSystem.ItemsToUpgrade.TotalUsedMaterials;

namespace EquipmentCalculator;


class Program
{
    static void Main(string[] args)
    {
        EquipLvl lvl = new EquipLvl();
        Console.WriteLine(lvl.UpgradeSimulation(0));
        
    }
}