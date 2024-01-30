namespace BicycleSample.Bridge.Bicycles;

public class BleuMountainBike : Bicycle
{
    public BleuMountainBike()
    {
        ModelName = "Palo Duro Canyon Ranger";
        Suspension = SuspensionTypes.Full;
        Color = BicyclePaintColors.Blue;
        Geometry = BicycleGeometries.Upright;
    }
   
}