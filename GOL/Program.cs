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
