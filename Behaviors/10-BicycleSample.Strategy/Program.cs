namespace BicycleSample.Strategy;

public class Program
{
    public static void Main(string[] args)
    {
        BicycleNavigationSystem navigationSystem = new BicycleNavigationSystem("road");
        Console.WriteLine(navigationSystem.CalculateRoute());

        // Testez avec différents types de terrain
    }
}