namespace EquipmentCalculator.MaterialsToLevelUp;

public class RegRolls
{
    internal int regRolls { get; set; } = 200;

    internal void ConsumedRegRolls()
    {
        regRolls++;
    }
}
