using System;
namespace Uppgift_3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 2 tal");
            Console.WriteLine("Skriv tal 1 här under");
            float tal1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Skriv tal 2 här");
            float tal2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraktion");
            Console.WriteLine("3: Multiplikation");
            Console.WriteLine("4: Division");
            float val = float.Parse(Console.ReadLine());

            switch(val)
            {
                case 1: Console.WriteLine("Addition");
                 float Summa = tal1 + tal2;
                 Console.WriteLine("Summan är " + Summa);
                    break;

                case 2: Console.WriteLine("Subtraktion");
                    float Summa2 = tal1 - tal2;
                    Console.WriteLine("Summan är " + Summa2);
                    break;

                case 3: Console.WriteLine("Multiplikation");
                    float Summa3 = tal1 * tal2;
                    Console.WriteLine("Summan är " + Summa3);
                    break;
                case 4: Console.WriteLine("Division");
                    float Summa4 = tal1 / tal2;
                    Console.WriteLine("Summan är " + Summa4);
                    break;

            }

        }
    }
}

