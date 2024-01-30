namespace BicycleSample.Builder;

// Une factory simple pour construire un vélo
internal class Program
{
    static void Main(string[] args)
    {
        var roadBike = BicycleFactory.BuildBicycle("RoadBike");
        roadBike.DisplaySpecifications();

        var mountainBike = BicycleFactory.BuildBicycle("MountainBike");
        mountainBike.DisplaySpecifications();
    }
}