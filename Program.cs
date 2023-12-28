using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia("+55081995588777", "G60", "001970-01-010000-0", 128);
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Whatsapp");
        nokia.Ligar();

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone("+55081955887788", "15 Pro Max", "001870-01-100000-0", 512);
        iphone.Ligar();
        iphone.InstalarAplicativo("Telegram");
        iphone.ReceberLigacao();
    }
}