using System;

namespace calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chose the operation(+,-,*,/,%)");
            string chose = Console.ReadLine();
            string addition = "+";
            string soustraction = "-";
            string multiplication = "*";
            string division = "/";
            string rest = "%";

            if (chose == addition)
            {
                Console.WriteLine("chose the first number");
                string paramOne = Console.ReadLine();
                double paraOne = Convert.ToDouble(paramOne);
                Console.WriteLine("chose the second number");
                String paramTwo = Console.ReadLine();
                double paraTwo = Convert.ToDouble(paramTwo);
                double result = paraOne + paraTwo;
                Console.WriteLine("result is" + result);

            }else if (chose == soustraction)
                {
                Console.WriteLine("chose the first number");
                string paramOne = Console.ReadLine();
                int paraOne = Int32.Parse(paramOne);
                Console.WriteLine("chose the second number");
                String paramTwo = Console.ReadLine();
                int paraTwo = Int32.Parse(paramTwo);
                int result = paraOne - paraTwo;
                Console.WriteLine("result is" + " " + result);
            }else if (chose == multiplication)
               {
                Console.WriteLine("chose the first number");
                string paramOne = Console.ReadLine();
                int paraOne = Int32.Parse(paramOne);
                Console.WriteLine("chose the second number");
                String paramTwo = Console.ReadLine();
                int paraTwo = Int32.Parse(paramTwo);
                int result = paraOne * paraTwo;
                Console.WriteLine("result is" + " " + result);
            } else if (chose == division)
              {
                Console.WriteLine("chose the first number");
                string paramOne = Console.ReadLine();
                int paraOne = Int32.Parse(paramOne);
                Console.WriteLine("chose the second number");
                String paramTwo = Console.ReadLine();
                int paraTwo = Int32.Parse(paramTwo);
                int result = paraOne / paraTwo;
                Console.WriteLine("result is" + " " + result);
            }
            else if (chose == rest)
            {
                Console.WriteLine("chose the first number");
                string paramOne = Console.ReadLine();
                int paraOne = Int32.Parse(paramOne);
                Console.WriteLine("chose the second number");
                String paramTwo = Console.ReadLine();
                int paraTwo = Int32.Parse(paramTwo);
                int result = paraOne % paraTwo;
                Console.WriteLine("result is" + " " + result);
                
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
