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
            engine.Create();
            engine.Running();
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
