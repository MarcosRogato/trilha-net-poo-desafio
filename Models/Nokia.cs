namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
        
        public override void InstalarAplicativo(string aplicativo)
        {
            
            Console.WriteLine($"Installing {aplicativo} on Nokia");
        }
    }
}