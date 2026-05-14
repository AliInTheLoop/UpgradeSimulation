namespace EquipmentCalculator.SimulationSystem.ItemsToUpgrade.ForASaverEnchant;

public static class Materials
{
    // Akhram adds to the current level the corresponded rate  50%, 100%
    internal static double AkhramProphecy50 { get; set; } = 0.5;
    internal static double AkhramProphecy100 { get; set; } = 1.0;
    internal static int PrestineBlackCrystals { get; set; } = 1;    // Item required to upgrade the equipment
    // if it fails it has a 50%(assumption because there is no information in the game about it) chance not losing a level
    internal static double RestorationRollsPerTry { get; set; } = 0.5;
    
    
}