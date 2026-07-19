namespace EquipmentCalculator.SimulationSystem.UpgradeSystem.FailStackManager;

public class AddStacks
{
    private readonly Dictionary<int, int> _countAnvil = [];

    internal bool AddFails(int currentLevel)
    {
        int stackNeeded = Anvil.MaxAttemptsToLvlUp[currentLevel]; // store the rules of the dictionary MaxAttempts

        _countAnvil.TryAdd(currentLevel, 0);
        Console.WriteLine($"[Added Rule: Level {currentLevel}]");

        if (_countAnvil[currentLevel] < stackNeeded)
        {
            _countAnvil[currentLevel]++;
            Console.WriteLine($"[Stack Counter] Level:{currentLevel} " +
                              $"| Stack: {_countAnvil[currentLevel]}/{stackNeeded}");
            return false;
        }

        _countAnvil[currentLevel] = 0;
        return true;
    }
}
