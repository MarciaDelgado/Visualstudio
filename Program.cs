using System.Runtime;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe mir deinen Namen");
             string name = Console.ReadLine();

            Console.WriteLine("Sage mir wie alt du bist");
            string age = Console.ReadLine();

            int alter = Convert.ToInt16(age);
            int alterInZehn = alter + 10;

            Console.WriteLine($"Hello, + {name} + Dein Alter ist + {age} + In zehn Jahren bist du + {alterInZehn}" ) ;
        }
    }
}