using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("     (問卜)今日大樂透號碼     ");
            Random rand = new Random();

            int S = 0;
            while (true)
            {
                int r1 = rand.Next(1, 42);
                int r2 = rand.Next(1, 42);
                int r3 = rand.Next(1, 42);
                int r4 = rand.Next(1, 42);
                int r5 = rand.Next(1, 42);
                int r6 = rand.Next(1, 42);

                Console.WriteLine(" ╔════════════╗ ");
                Console.WriteLine(" ║                        ║ ");
                Console.WriteLine(" ║      大樂透號碼 :      ║ ");
                Console.WriteLine(" ║                        ║ ");
                Console.WriteLine(" ║   {0:00} {1:00} {2:00} {3:00} {4:00} {5:00}    ║ ", r1, r2, r3, r4, r5, r6);
                Console.WriteLine(" ║                        ║ ");
                Console.WriteLine(" ╚════════════╝ ");

                S = S + 1;
                Console.ReadLine();

            }
            Console.ReadLine();
        }
    }
}
