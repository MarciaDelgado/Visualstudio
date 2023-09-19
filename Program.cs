using System.ComponentModel;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie schnell fährt das Auto?");
            int nmr=Convert.ToInt32(Console.ReadLine());

            string ergebnis=Fahren(nmr);
            Console.WriteLine($"Das Auto {ergebnis}");
        }

        static string Fahren(int geschwindigkeit)
        {
       
            if(geschwindigkeit==0)
            {
                return " steht";
            }

            else if (geschwindigkeit>0&&geschwindigkeit<=10)
            {
              return   "schleicht" ;
            
            }    

            else if(geschwindigkeit>10&&geschwindigkeit<=50)
            {
                return "fährt langsam";
            }
            
            else if(geschwindigkeit>50&&geschwindigkeit<=100)
            {
                return "fährt schnell";
            }

            else if(geschwindigkeit>100)
            {
                return  "rast";
            }

            else
            { 
                return "Error";
            }

        }
    }
}