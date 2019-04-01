using GOL.Engine;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GOL
{
    class Program
    {
        static void Main(string[] args)
        {
            GOLEngine engine = new GOLEngine();
            engine.Start();

            //Board grid = new Board();
            //ConsoleOutput.DisplayBoard(grid);
            //ConsoleInput.CreateCells(grid);


            //Console.WriteLine("\nPress Esc anytime to stop");
            //Thread.Sleep(ConfigSettings.Delay);

            //while (!Console.KeyAvailable || Console.ReadKey(true).Key != ConsoleKey.Escape)
            //{
            //    BoardGame.NewBoardCalcuation(grid);
            //    ConsoleOutput.DisplayBoard(grid);
            //    Thread.Sleep(ConfigSettings.Delay);
            //}
            //Console.WriteLine("Save current iteration? (y/n)");
            //if (Console.ReadKey().KeyChar == 'y')
            //{
            //    Console.WriteLine("\nWhat will be the name of this board?");
            //    string s = Console.ReadLine();
            //    Grid.BoardWriteFileAsync(s);
            //}
            Console.ReadKey();
        }
    }
}
