namespace EquipmentCalculator.SimulationSystem.UpgradeSystem;

public static class CurLevelAndSucRates
{
    // Each level and there corresponded rates they need to level up
    internal static Dictionary<int, double> CurLevelAndSuccessRate = new Dictionary<int, double>()
    {
        { 0, 70.00 }, { 1, 60.00 }, 
        { 2, 40.00 }, { 3, 20.00 },
        { 4, 10.00 }, { 5, 7.00 }, 
        { 6, 5.00 }, { 7, 3.00 },
        { 8, 1.00 }, { 9, 0.50 }
    };
}