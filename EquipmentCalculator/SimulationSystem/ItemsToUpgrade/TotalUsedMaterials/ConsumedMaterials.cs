namespace EquipmentCalculator.SimulationSystem.ItemsToUpgrade.TotalUsedMaterials;

public class ConsumedMaterials
{
    internal int TotalAttempts { get; set; }
    internal int TotalRegRolls { get; set; }
    internal int TotalPrestineCrystals { get; set; }
    internal int TotalRatesUsed { get; set; }
    internal int TotalSilverCost { get; set; }

    public override string ToString()
    {
        return "––– Consumed Materials\n" +
               $"Attempts: {TotalAttempts}\n" +
               $"Restoration Rolls: {TotalRegRolls}\n" +
               $"Crystals: {TotalPrestineCrystals}\n" +
               $"Valks: {TotalRatesUsed}\n" +
               $"Silver cost: {TotalSilverCost}\n";
    }
}