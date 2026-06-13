namespace EquipmentCalculator.SimulationSystem.UpgradeSystem.FailStackManager;
using EquipmentSystem;
/*
    The point of the Anvil system is that, if a certain level has reached max fail attempts, the next attempt will be
    guaranteed to level up. It will remove then the accumulated fail stack for the corresponded level only.
    This principal will hold for all levels.
*/
public class Anvil
{
    private readonly Random _rand = new();
    internal int CurrentLevel { get; set; }

    internal readonly Dictionary<int, int> MaxAttemptsToLvlUp = new()
    {
        // current level | attempts needed for guaranteed level up 
        {0,0}, {1,0},{ 2, 2 }, { 3, 3 }, { 4, 5 }, { 5, 8 }, { 6, 10 }, { 7, 17 }, { 8, 50 }, { 9, 100 }
    };

    internal bool GetRandomNumber()
    {
        if (LevelSuccessRates.UpgradeInformation.TryGetValue(CurrentLevel, out double chance))
        {
            double roll = _rand.NextDouble() * 100;

            Console.WriteLine($"Random number : {roll:F2}\nChance needed: {chance}");
            if (roll < chance)
            {
                Console.WriteLine($"Level after success: {++CurrentLevel}");
            }
            else
            {
                if (CurrentLevel == 0) Console.WriteLine($"level 0 check: {CurrentLevel = 0}");
                else Console.WriteLine($"Level after fail: " + --CurrentLevel);

                return false;
            }
        }

        return true;
    }
}