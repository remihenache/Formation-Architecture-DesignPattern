namespace BicycleSample.Builder;

public static class BicycleFactory
{
    public static Bicycle BuildBicycle(string type)
    {
        var bicycle = new Bicycle();

        if (type == "RoadBike")
        {
            bicycle.Frame = "Road Frame";
            bicycle.Handlebars = "Road Handlebars";
            bicycle.Brakes = "Standard Brakes";
            bicycle.Suspension = "Standard Suspension";
        }
        else if (type == "MountainBike")
        {
            bicycle.Frame = "Mountain Frame";
            bicycle.Handlebars = "Mountain Handlebars";
            bicycle.Brakes = "Mountain Brakes";
            bicycle.Suspension = "Advanced Suspension";
        }

        return bicycle;
    }
}