namespace BicycleSample.Strategy;

public class BicycleNavigationSystem
{
    private string terrainType;

    public BicycleNavigationSystem(string terrain)
    {
        terrainType = terrain;
    }

    public string CalculateRoute()
    {
        if (terrainType == "road")
        {
            return "Calculating route on paved roads.";
        }
        else if (terrainType == "gravel")
        {
            return "Calculating route on gravel paths.";
        }
        else if (terrainType == "mountain")
        {
            return "Calculating route on mountain trails.";
        }
        else
        {
            return "Terrain type not recognized.";
        }
    }
}