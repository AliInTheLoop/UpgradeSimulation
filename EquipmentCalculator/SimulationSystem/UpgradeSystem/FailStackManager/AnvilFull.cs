namespace EquipmentCalculator.SimulationSystem.UpgradeSystem.FailStackManager;
using UpgradeSystem;

public class AnvilFull
{
    internal AnvilSystem IsFull = new();
    internal double Chance;
    
    internal string IsAnvilFull(int level)
    {
        if (IsFull.MaxAttemptsToLvlUp.TryGetValue(level, out int maxFailsNeeded))
        {
            if (IsFull.MaxAttemptsToLvlUp[level] == maxFailsNeeded)
            {
                Chance = 100.00;
                level++;
            }
        }

        return $"{level}";
    }
}