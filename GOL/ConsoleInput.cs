using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    public class ConsoleInput
    {
        public static void CreateCells(Board grid)
        {
            Console.WriteLine("\nCreate live cells");
            char confirm;
            do
            {
                try
                {
                    Console.WriteLine("Enter x (0 to 15):");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter y (0 to 15):");
                    int y = Convert.ToInt32(Console.ReadLine());
                    grid.SetValue(x , y);
                }
                catch (Exception)
                {
                    Console.WriteLine("You did an oopsie, try doing it again correctly");
                }
                finally
                {
                    Console.Clear();
                    ConsoleOutput.DisplayBoard(grid);
                    Console.WriteLine("Make another cell? (y/n)");
                    confirm = Console.ReadKey().KeyChar;
                    Console.Clear();
                    ConsoleOutput.DisplayBoard(grid);
                }
            } while (confirm == 'y');
        }
    }
}
