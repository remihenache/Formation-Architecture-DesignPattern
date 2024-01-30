﻿namespace BicycleSample.Factory.Bicycles;

public class Cruiser : Bicycle
{
    public Cruiser()
    {
        ModelName = "Galveston Cruiser";
        Suspension = SuspensionTypes.Hardtail;
        Color = BicyclePaintColors.Red;
        Geometry = BicycleGeometries.Upright;
    }
}