namespace EquipmentCalculator.MaterialsToLevelUp;

public class PrestineCrystals
{
    internal int Crystal { get; set; }

    internal void ConsumedCrystal()
    {
        Crystal++;
    }
}