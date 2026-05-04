namespace EquipmentCalculator.EquipmentSystem;
using MaterialsToLevelUp;
using System;

public class EquipmentLevel
{
    internal int CurrentLevel { get; set; }
    private Random rand = new();
    internal Materials _count;

    private Dictionary<int, double> _curLevelAndSuccessRate = new Dictionary<int, double>()
    {
        { 0, 70.00 }, { 1, 60.00 }, 
        { 2, 40.00 }, { 3, 20.00 },
        { 4, 10.00 }, { 5, 7.00 }, 
        { 6, 5.00 }, { 7, 3.00 },
        { 8, 1.00 }, { 9, 0.50 }
    };
    
    
    internal EquipmentLevel(int currentLevel)
    {
        CurrentLevel = currentLevel;
        _count = new Materials();
    }

    internal int UpgradeSimulation(int currentLevel)
    {
        CurrentLevel = currentLevel;
        double roll = rand.NextDouble();
        while (CurrentLevel < 10)
        {
            //Continue
        }
    }
}