using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {          
            int zahl1=10;
            int zahl2=2;
           
           Console.WriteLine("Wählen ein Zeichnen aus");
           string zeichnen=Console.ReadLine();

           switch(zeichnen)
           {
            case "+":
             Console.WriteLine(zahl1 + zahl2);
             break;

            case "-":
             Console.WriteLine(zahl1 - zahl2);
             break;

            case "/":
             Console.WriteLine(zahl1 / zahl2);
             break;

            case "*":
             Console.WriteLine(zahl1 * zahl2);
             break;   

            default:
            Console.WriteLine("Ich kenne diesen Operator nicht ");
            break;

           }
           
           }
        }
    }
}