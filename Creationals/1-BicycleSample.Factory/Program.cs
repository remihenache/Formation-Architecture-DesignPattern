﻿using System;
using BicycleSample.Factory.Bicycles;

namespace BicycleSample.Factory;

public class Program
{
    const string errorText = "You must pass in mountainbike, cruiser, recumbent, or roadbike"; 
    public static void Main(string[] args)
    {
        if(args.Length > 0)
        { 
            var bicycleType = args[0].Trim().ToLower();
            Bicycle bikeToBuild; 
            switch (bicycleType)
            {
                case "mountainbike":
                    bikeToBuild = new MountainBike();
                    break;
                case "cruiser":
                    bikeToBuild = new Cruiser();
                    break;
                case "recumbent":
                    bikeToBuild = new Recumbent();
                    break;
                case "roadbike":
                    bikeToBuild = new RoadBike();
                    break;
                default:
                    Console.WriteLine(errorText);
                    throw new Exception("Unknown bicycle type: " +
                                        bicycleType);
            }
   
            bikeToBuild.Build();
        }  
        else
        {
            Console.WriteLine(errorText);
        }
    }
}