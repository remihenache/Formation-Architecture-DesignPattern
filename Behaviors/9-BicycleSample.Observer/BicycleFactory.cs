namespace BicycleSample.Observer;

public class BicycleFactory
{
    private readonly List<Bicycle> bicycles = new();
  

    public void ProduceBicycle(Bicycle bike)
    {
        bicycles.Add(bike);
        // Actuellement, aucune notification n'est envoyée
        Console.WriteLine($"Produced {bicycles.Count} bicycles.");
    }

    // La méthode pour notifier les observateurs n'est pas encore implémentée
}