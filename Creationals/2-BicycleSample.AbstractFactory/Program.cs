// See https://aka.ms/new-console-template for more information

using BicycleSample.AbstractFactory.Frames;
using BicycleSample.AbstractFactory.HandleBars;

namespace BicycleSample.AbstractFactory;

internal class Program
{
    static void Main(string[] args)
    {
        // Exemple d'utilisation de la factory
        var roadBikeFrame = (RoadBikeFrame)BicycleComponentFactory.CreateBicycleComponent("RoadBikeFrame");
        var mountainBikeHandlebars = (MountainBikeHandlebars)BicycleComponentFactory.CreateBicycleComponent("MountainBikeHandlebars");

        Console.WriteLine(roadBikeFrame.FrameType);
        Console.WriteLine(mountainBikeHandlebars.HandlebarsType);
    }
}