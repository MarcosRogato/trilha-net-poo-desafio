namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public override void InstalarAplicativo(string aplicativo)
        {
          
            Console.WriteLine($"Installing {aplicativo} on iPhone");
        }
    }
}
