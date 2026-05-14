namespace EquipmentCalculator.SimulationSystem.EquipmentSystem;
using ItemsToUpgrade.TotalUsedMaterials;
using UpgradeSystem;
using UpgradeSystem.FailStackManager;



public class EquipLvl
{
    private int CurrentLevel { get; set; }
    private readonly Random _rand = new ();
    ConsumedMaterials _sum = new ();
    AnvilFull _fail = new();

    private EquipLvl(int currentLevel)
    {
        CurrentLevel = currentLevel;
    }

    internal EquipLvl() : this(0)
    {
        
    }
    
    internal ConsumedMaterials UpgradeSimulation(int currentLevel)
    {
        CurrentLevel = currentLevel;
        
        while (CurrentLevel < 10)
        {
            double roll = _rand.NextDouble() * 100;
            // each attempt cost 200 rolls and 500 silver
            _sum.ConsumedResources(200,500);
            
            Console.WriteLine($"Attempt: {_sum.TotalAttempts} | Current Level: {CurrentLevel}");
            
            if (LevelSuccessRates.UpgradeInformation.TryGetValue(CurrentLevel, out  double currentChance))
            {
                Console.WriteLine($"Random roll: {roll:F2} | Chance: {currentChance}");
                if (_fail.IsFull.MaxAttemptsToLvlUp.TryGetValue(CurrentLevel, out int toSee))
                {
                    Console.WriteLine(toSee);
                }
                if (roll < currentChance)
                {
                    ++CurrentLevel;
                    Console.WriteLine($"Level after try: {CurrentLevel}\n");
                }
                else
                {
                    if (CurrentLevel < 1)
                    {
                        CurrentLevel = 0;
                        Console.WriteLine($"Level after try: {CurrentLevel}\n");
                    }
                    else
                    {
                        --CurrentLevel;
                        Console.WriteLine($"Level after try: {CurrentLevel}\n");
                    }
                    // TODO: Remove this limit for real simulation or increase the number 
                    if (_sum.TotalAttempts > 9)
                    {
                        break;
                    }
                }
            }
        }
        // return the accumulated materials ( Consumed.Materials.ToString handles the formatting)
        return _sum;
    }
}