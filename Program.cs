using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welche ist die erste Zahl ?");
            string numero1 = Console.ReadLine();

            Console.WriteLine("Welche ist die zweite Zahl? ");
            string numero2 = Console.ReadLine();

            int nmr1 = Convert.ToInt16(numero1);
            int nmr2 = Convert.ToInt16(numero2);
            int ergebnis = nmr1+nmr2;

            Console.WriteLine($"Das Ergenis aus {nmr1} + {nmr2} = {ergebnis}");

           }

           
           

          
        }
    
        
    }
