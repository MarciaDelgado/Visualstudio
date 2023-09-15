using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {           
            int zahl1 = 5;
            int zahl2 = 10;
            Console.WriteLine("Wählen ein Zeichnen aus");
            string zeichnen=Console.ReadLine();
            switch(zeichnen)
            {            
                case "+":
                    Addition(zahl1, zahl2);
                    break;

                case "-":
                    Substract(zahl1 ,zahl2);
                    break;

                case "/":
                    Division(zahl1 ,zahl2);
                    break;

                case "*":
                    Multiplication(zahl1 , zahl2);
                    break;   

                default:
                    Console.WriteLine("Ich kenne diesen Operator nicht ");
                    break;
           }
        }
        
        static void  Addition(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1+zahl2);
        }
          
         static void Substract(int zahl1, int zahl2) 
         {
            Console.WriteLine(zahl1-zahl2);
         }
         
          static void Division(int zahl1, int zahl2) 
         {
            Console.WriteLine(zahl1/zahl2);
         }
         

          static void Multiplication(int zahl1, int zahl2) 
         {
            Console.WriteLine(zahl1*zahl2);
         }


        }
    }
