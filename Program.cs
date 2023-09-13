using System.Runtime;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Was ist die erste Zahl?");
             string zahl1 = Console.ReadLine();

            Console.WriteLine("Was ist die zweite Zahl?");
            string zahl2 = Console.ReadLine();

            int zahleins = Convert.ToInt16(zahl1);
            int zahlzwei = Convert.ToInt16(zahl2);

            int zahl1PlusZahl2 = zahleins + zahlzwei ;

            Console.WriteLine($"Das Ergebnis aus {zahl1} +{zahl2} =  {zahl1PlusZahl2}" ) ;
        }
    }
}