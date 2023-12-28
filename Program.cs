using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia("+55081985588333", "Nokia C12", "555444-01-010000-0", 128);
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Whatsapp");
        nokia.Ligar();

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone("+55081955884422", "14 Pro", "666333-01-100000-0", 512);
        iphone.Ligar();
        iphone.InstalarAplicativo("Telegram");
        iphone.ReceberLigacao();
    }
}