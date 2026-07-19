using EquipmentCalculator.SimulationSystem.EquipmentSystem;

namespace EquipmentCalculator.SimulationSystem.ItemsToUpgrade.ForASaverEnchant;

public static class Materials
{
    // Akhram adds to the current level the corresponded rate  50%, 100%
    internal static double AkhramProphecy50 { get; set; } = 1.5;
    internal static double AkhramProphecy100 { get; set; } = 2.0;
    internal static int PrestineBlackCrystals { get; set; } = 1;    // Item required to upgrade the equipment
    // if it fails it has a 50%(assumption because there is no information in the game about it) chance not losing a level
    internal static double RestorationRollsPerTry { get; set; } = 1.5;

    internal static double SuccessBooster(int getUserChoose)
    {
        double akhram;
        if (getUserChoose == 1)
        {
            akhram = AkhramProphecy50;

        }
        else
        {
            akhram = AkhramProphecy100;
        }

        return akhram;
    }
}
