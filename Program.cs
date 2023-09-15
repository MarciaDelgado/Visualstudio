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
            Console.WriteLine("Geben Sie eine Zahl ein ");
            int zahl1=Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Geben Sie noch eine Zahl ein ");
            int zahl2=Convert.ToInt16(Console.ReadLine());

            int ergebnis=zahl1%zahl2;
            Console.WriteLine($"Die Division von {zahl1} und {zahl2} erzeugt den Rest {ergebnis} " );
            
        }
    }
}
