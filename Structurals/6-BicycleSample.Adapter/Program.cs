namespace BicycleSample.Adapter;

internal class Program
{
    private static void Main()
    {
        // Votre tâche est de créer un adaptateur qui permet au OrderManagementSystem
        // de fonctionner avec le NewPaymentSystem sans changer son code.
        // Utilisation de l'adaptateur pour permettre au système de gestion des commandes de fonctionner avec le nouveau système de paiement

        var orderSystem = new OrderManagementSystem(new NewPaymentSystem());
        orderSystem.ProcessOrder("Order1", "PaymentDetails1");
    }
}