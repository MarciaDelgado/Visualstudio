using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Schreiben Sie einen Text");
            string text= Console.ReadLine();

            string newtext1= text.Replace('U', 'G');
            string newtext2= newtext1.Replace('u','g');
             

            Console.WriteLine(newtext2);

           }

           
           

          
        }
    
        
    }
