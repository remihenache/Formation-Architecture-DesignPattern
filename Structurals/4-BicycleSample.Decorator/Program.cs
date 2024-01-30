namespace BicycleSample.Decorator;

internal class Program
{
    private static void Main()
    {
        IBicycle roadBike = new RoadBike();
        roadBike.Build();

        IBicycle mountainBike = new MountainBike();
        mountainBike.Build();
    }
}