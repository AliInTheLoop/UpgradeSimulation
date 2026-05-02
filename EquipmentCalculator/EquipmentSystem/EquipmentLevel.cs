using EquipmentCalculator.Anvil;

namespace EquipmentCalculator.EquipmentSystem;

public class EquipmentLevel : AnvilSystem
{
    private  int _currentLevel;
    private  double _chance; 
    private  int _maxEqiupmentLevel = 10;
    private int _equipCount = 0;
    private Random number = new Random(); 

    private List<int> _level =
    [
        0, 1, 2, 3, 4, 5,
        6, 7, 8, 9, 10
    ];

    private readonly Dictionary<int, double> _succesRate = new()
    {
        { 0, 70.00 }, { 1, 60.00 },
        { 2, 40.00 }, { 3, 20.00 }, 
        { 4, 10.00 }, { 5, 7.00 },
        { 6, 5.00 }, { 7, 3.00 },
        { 8, 1.00 }, { 9, 0.50 }
    };

    internal void EquipmentLeveling()
    {
        while (_level[0] < _maxEqiupmentLevel)
        {
            if (_succesRate.ContainsKey(_currentLevel))
            {
                _chance = _succesRate[_currentLevel];

                if (_chance > 0.0)
                {
                    _currentLevel++;
                }
            }
        }
    }
}