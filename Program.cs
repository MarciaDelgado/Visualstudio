using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Schreibe eine Zahl zwischen 1 bis 100");
            string zahl=Console.ReadLine();
            int zahlValue = Convert.ToInt32(zahl);
            Random random = new Random();
            int numberToGuess = random.Next(1,101);
            while(zahlValue != numberToGuess) {
                 if(zahlValue<numberToGuess)
                {
                    Console.WriteLine("Die Zahl wuerde nicht getroffen . Tipp : Die  geheime Zahl st kleiner.");
                }

                else if(zahlValue>numberToGuess)
                {
                    Console.WriteLine("Die Zahl wuerde nicht getroffen . Tipp : Die geheime Zahl ist großer.");
                }
                Console.WriteLine("Deine zahl ist falsch, gebe eine neue ein");
                zahlValue = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Die Zahl wurde getroffen :)");
            
        }
    }
}
