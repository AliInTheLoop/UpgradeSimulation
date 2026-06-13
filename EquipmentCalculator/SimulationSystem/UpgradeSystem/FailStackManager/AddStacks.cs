namespace EquipmentCalculator.SimulationSystem.UpgradeSystem.FailStackManager;

public class AddStacks : Anvil
{
    private readonly Dictionary<int, int> _countAnvil = new();

    internal void StackCounter()
    {
        
        int stackNeeded = MaxAttemptsToLvlUp[CurrentLevel];

        // if there is no level in the dictionary 
        if (!_countAnvil.ContainsKey(CurrentLevel))
        {
            _countAnvil[CurrentLevel] = 0;
            Console.WriteLine($"Added Level {CurrentLevel} to the stack Dictionary");
        }
        else
        {
            // Add one stack if it is less or equal then the current level in the dictionary
            if (_countAnvil[CurrentLevel] <= stackNeeded)
            {
                _countAnvil[CurrentLevel]++;
                Console.WriteLine($"current stack: {_countAnvil[CurrentLevel]}/{stackNeeded}");
            }
            else
            {
                CurrentLevel++;

                // set the stack to 0 after Level up.
                _countAnvil[CurrentLevel] = 0;
            }
        }
    }
}