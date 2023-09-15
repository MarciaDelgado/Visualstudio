using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {           
            string zahl1 = Console.ReadLine();
            string zahl2 = Console.ReadLine();
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
         

        static int AdditionWithReturn(string zahl1, string zahl2)
        {
            int numero1=Convert.ToInt32(zahl1);
            int numero2=Convert.ToInt32(zahl2);
            return numero1 + numero2;
        }
        static void Addition(string zahl1, string zahl2)
        {
            int numero1=Convert.ToInt32(zahl1);
            int numero2=Convert.ToInt32(zahl2);
            Console.WriteLine(numero1+numero2);
        }

        static void Addition(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1+zahl2);
        }
          

         static void  Substract(string zahl1, string zahl2)
        {
            int numero1=Convert.ToInt32(zahl1);
            int numero2=Convert.ToInt32(zahl2);
            Console.WriteLine(numero1-numero2);
        } 
         static void Substract(int zahl1, int zahl2) 
         {
            Console.WriteLine(zahl1-zahl2);
         }
         

         static void  Division(string zahl1, string zahl2)
        {
            int numero1=Convert.ToInt32(zahl1);
            int numero2=Convert.ToInt32(zahl2);
            Console.WriteLine(numero1/numero2);
        }
          static void Division(int zahl1, int zahl2) 
         {
            Console.WriteLine(zahl1/zahl2);
         }
         
         

        static void  Multiplication(string zahl1, string zahl2)
        {
            int numero1=Convert.ToInt32(zahl1);
            int numero2=Convert.ToInt32(zahl2);
            Console.WriteLine(numero1*numero2);
        }
        static void Multiplication(int zahl1, int zahl2) 
        {
            Console.WriteLine(zahl1*zahl2);
        }
    }
}
