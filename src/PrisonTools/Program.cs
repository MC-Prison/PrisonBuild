using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonTools
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Prison Tools for Prison 3");
            Console.WriteLine("=========================");
            int writeStart = Console.CursorTop;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("  1: Build Prison 3");
            Console.WriteLine("  2: Create a module project structure");
            Console.WriteLine("Type the number of your option below:");
            Console.Write("= ");
            char o = Console.ReadLine()[0];
            Clear(writeStart,Console.CursorTop);
            if (o == '1')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("WARNING! If there are any official releases on out Spigot or Bukkit pages, please download Prison 3 from there. This build tool clones the repository that we use for development. If you want to continue, press ENTER otherwise exit the program (using CTRL+C or platform equivalent).");
                Console.ReadLine();
                Clear(writeStart, Console.CursorTop);
                Console.Write("Creating a work directory...");
            }
            else if (o == '2')
            {

            }
            else
            {
                Console.WriteLine("Invalid option");
            }
            Console.WriteLine("Press ENTER to quit");
            Console.ReadLine();
        }
        public static void Clear(int stopAt, int currentLine)
        {
            int line = currentLine;
            while (line >= stopAt)
            {
                Console.SetCursorPosition(0, line);
                Console.Write(new string(' ', Console.WindowWidth));
                line--;
            }
            Console.SetCursorPosition(0, stopAt);
        }
    }
}
