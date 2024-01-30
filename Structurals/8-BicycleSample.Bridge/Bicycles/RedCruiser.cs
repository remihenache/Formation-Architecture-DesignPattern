namespace BicycleSample.Bridge.Bicycles;

public class RedCruiser : Bicycle
{
    public RedCruiser()
    {
        ModelName = "Galveston Cruiser";
        Suspension = SuspensionTypes.Hardtail;
        Color = BicyclePaintColors.Red;
        Geometry = BicycleGeometries.Upright;
    }
}