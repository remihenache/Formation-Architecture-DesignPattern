using BicycleSample.AbstractFactory.Frames;
using BicycleSample.AbstractFactory.HandleBars;

namespace BicycleSample.AbstractFactory;

public static class BicycleComponentFactory
{
    public static object CreateBicycleComponent(string type)
    {
        switch (type)
        {
            case "RoadBikeFrame":
                return new RoadBikeFrame();
            case "MountainBikeFrame":
                return new MountainBikeFrame();
            case "RoadBikeHandlebars":
                return new RoadBikeHandlebars();
            case "MountainBikeHandlebars":
                return new MountainBikeHandlebars();
            default:
                throw new InvalidOperationException("Invalid component type");
        }
    }
}