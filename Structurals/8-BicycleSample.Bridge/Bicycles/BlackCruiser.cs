namespace BicycleSample.Bridge.Bicycles;

public class BlackCruiser : Bicycle
{
    public BlackCruiser()
    {
        ModelName = "Galveston Cruiser";
        Suspension = SuspensionTypes.Hardtail;
        Color = BicyclePaintColors.Black;
        Geometry = BicycleGeometries.Upright;
    }
}