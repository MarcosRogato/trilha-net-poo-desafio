namespace DesafioPOO.Models
{
    // Inheriting from the class "Smartphone"
    public class Iphone : Smartphone
    {
        // Overriding the method "InstalarAplicativo"
        public override void InstalarAplicativo(string aplicativo)
        {
            // TODO: Add your implementation here
            Console.WriteLine($"Installing {aplicativo} on iPhone");
        }
    }
}
