

namespace EquipmentCalculator.SimulationSystem.UpgradeSystem.FailStackManager;
using EquipmentSystem;

/*
    The point of the Anvil system is that, if a certain level has reached max fail attempts, the next attempt will be
    guaranteed to level up. It will remove then the accumulated fail stack for the corresponded level only.
    This principal will hold for all levels.
*/
public class Anvil
{
    internal int CurrentLevel { get; set; }
    private readonly Random _roll = new ();
    private readonly AddStacks _counter = new();

    internal static readonly Dictionary<int, int> MaxAttemptsToLvlUp = new()
    {
        // current level | attempts needed for guaranteed level up 
        {0,0}, {1,0},{ 2, 2 }, { 3, 3 }, { 4, 5 }, { 5, 8 }, { 6, 10 }, { 7, 17 }, { 8, 50 }, { 9, 100 }
    };

    internal bool GetRandomNumber()
    {
        if (LevelSuccessRates.UpgradeInformation.TryGetValue(CurrentLevel, out double chance))
        {
            double rand = _roll.NextDouble() * 100;

            Console.WriteLine($"Current Level: {CurrentLevel}\nRandom number : {rand:F2} | Chance needed: {chance}\n");
            if (rand < chance)
            {     
                Console.WriteLine($"Success! Current Level: {++CurrentLevel}\n");
            }
            else
            {
                if (CurrentLevel == 0)
                {
                    CurrentLevel = 0; //  to make sure it will not drop below 0.
                    Console.WriteLine($"Current Level 0! Show: {CurrentLevel}");
                }
                else
                {
                    Console.WriteLine(!_counter.AddFails(CurrentLevel)
                        ? $"Stack up: Level down {--CurrentLevel}"
                        : $"Stack full! Level up {++CurrentLevel}");
                }
            }
        }
        return true;
    }
}