using System;

namespace boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int number = 4;
           
            for (i = 1; i <= 30; i++)
            {
                int mult = i * number;
                Console.WriteLine(mult);
                
            }
            double ex;
            for (ex = 1; ex <= 10; ex += 0.5)
            {
                
                Console.WriteLine(ex);
            }
            int arrive;
            for (arrive = 1; arrive <= 15; arrive++)
            {
                Console.WriteLine(arrive);
                Console.WriteLine("On y arrive presque");
            }
            int enfin;
            for (enfin = 200; enfin >= 0; enfin -= 12)
            {
                Console.WriteLine(enfin);
                Console.WriteLine("enfin!!!");
            }
        }
    }
}
