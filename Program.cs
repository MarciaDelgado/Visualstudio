using System.Runtime;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Das ist ein Text ";
            Console.WriteLine(text);

            int zahl = 21;
            Console.WriteLine(zahl);

            double kommazahl =21.3 ;
            Console.WriteLine(kommazahl);

            float weiterFliesKommazahl = 26.333333673F;
            Console.WriteLine(weiterFliesKommazahl);

            decimal fliesKomma = 26.5M;
            Console.WriteLine(fliesKomma);


            bool wahrheitswert = true ;
            Console.WriteLine(wahrheitswert);
            bool anders = false ;
            Console.WriteLine(anders);

            char buchstabe =(char)48 ;
            Console.WriteLine(buchstabe);
            
            long langezahl = 123456789123456789;
            Console.WriteLine(langezahl);

            uint positiveZahlen = 123;
            Console.WriteLine(positiveZahlen);

            string[] myArray = new string [10];
            myArray[0] = "erster Wert";
            myArray[9] = "letzer Wert";

            List<string> myList = new List<string>();
            myList.Add("Marcia");
            myList.Add("Benjamin");
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);

        }
    }
}