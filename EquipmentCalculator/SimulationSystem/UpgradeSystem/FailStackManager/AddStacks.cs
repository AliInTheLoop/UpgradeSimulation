namespace EquipmentCalculator.SimulationSystem.UpgradeSystem.FailStackManager;

public class AddStacks : Anvil
{
    private readonly Dictionary<int, int> _countAnvil = new();

    internal void StackCounter()
    {
        if (!_countAnvil.ContainsKey(Level))
        {
            _countAnvil[Level] = 0;
        }
        _countAnvil[Level]++;
    }
}