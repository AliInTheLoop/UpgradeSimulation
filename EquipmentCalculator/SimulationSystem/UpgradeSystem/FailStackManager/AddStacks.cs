namespace EquipmentCalculator.SimulationSystem.UpgradeSystem.FailStackManager;


public class AddStacks
{
    private readonly Dictionary<int, int> _countAnvil = new();

    internal bool AddFails(int currentLevel)
    {
        int stackNeeded = Anvil.MaxAttemptsToLvlUp[currentLevel]; // store the rules of the dictionary MaxAttempts 

        if(!_countAnvil.ContainsKey(currentLevel))
        {
            _countAnvil[currentLevel] = 0;
            Console.WriteLine($"Add rule for Level {currentLevel}");
        }
        else
        {
            _countAnvil[currentLevel]++;
            Console.WriteLine($"Current stack for level {currentLevel}: {_countAnvil[currentLevel]}/{stackNeeded}");
            
            if(_countAnvil[currentLevel] >= stackNeeded)
            {
                _countAnvil[currentLevel] = 0;
                return true;
            }
        }
        return false;
    }
}