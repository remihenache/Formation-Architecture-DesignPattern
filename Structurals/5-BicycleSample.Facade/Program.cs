namespace BicycleSample.Facade;

internal class Program
{
    private static void Main()
    {
        // Création directe des instances d'API
        WelderAPI welder = new WelderAPI();
        BufferAPI buffer = new BufferAPI();
        GripperAPI gripper = new GripperAPI();

        // Utilisation directe des APIs sans passer par une façade
        welder.WeldAtPosition(10, 20, 30);
        buffer.BuffAtPosition(15, 25);
        gripper.GripAtPosition(5, 10);
    }
}