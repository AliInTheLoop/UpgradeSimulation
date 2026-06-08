namespace EquipmentCalculator.SimulationSystem.ItemsToUpgrade.TotalUsedMaterials;

public class ConsumedMaterials
{
    internal int TotalAttempts {  get; private set; }
    private int TotalRegRolls { get; set; }
    private int TotalPrestineCrystals { get; set; }
    private int TotalRatesUsed { get; set; }
    private int TotalSilverCost { get; set; }

    internal ConsumedMaterials(int attempts, int regRolls, int crystal, int ratesUsed, int silverCost)
    {
        TotalAttempts = attempts;
        TotalRegRolls = regRolls;
        TotalPrestineCrystals = crystal;
        TotalRatesUsed = ratesUsed;
        TotalSilverCost = silverCost;
    }
    
    internal ConsumedMaterials() : this(0,0,0,0,0)
    {
        
    }

    internal void ConsumedResources(int regRolls, int silverCost)
    {
        TotalAttempts++;
        TotalRegRolls += regRolls;
        TotalPrestineCrystals++;
        TotalRatesUsed++;
        TotalSilverCost += silverCost;
    } 
    
    public override string ToString()
    {
        return "––– Consumed Materials –––\n" +
               $"Attempts: {TotalAttempts}\n" +
               $"Restoration Rolls: {TotalRegRolls}\n" +
               $"Crystals: {TotalPrestineCrystals}\n" +
               $"Valks: {TotalRatesUsed}\n" +
               $"Silver cost: {TotalSilverCost}\n";
    }
}