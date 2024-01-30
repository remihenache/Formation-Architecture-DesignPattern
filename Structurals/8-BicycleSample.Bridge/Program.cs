using BicycleSample.Bridge.Bicycles;

namespace BicycleSample.Bridge;

internal class Program
{
    private static void Main()
    {
        // Utilisation
        var bicycle1 = new RedCruiser();
        bicycle1.Build();
    }
}