namespace BicycleSample.Bridge.Bicycles;

public class BlackMountainBike : Bicycle
{
    public BlackMountainBike()
    {
        ModelName = "Palo Duro Canyon Ranger";
        Suspension = SuspensionTypes.Full;
        Color = BicyclePaintColors.Black;
        Geometry = BicycleGeometries.Upright;
    }
   
}