using GOL.Engine.Display;
using System.Threading;

namespace GOL.Engine
{
    public class GOLEngine
    {
        ConsoleWindow console;
        Displayer display;
        Board grid; // 'Game' 

        public GOLEngine()
        {
            console = new ConsoleWindow();
            display = new Displayer();
            grid = new Board(); //substitute with 'Game' later
        }

        public void Start()
        {
            console.ConfigureConsole();
            //display.DisplayBoard(grid);
            //display.DisplayCellCreation(grid);
            //display.DisplayNewGameIteration(grid);
        }
        public void Create()
        {
            display.DisplayBoard(grid);
            display.DisplayCellCreation(grid);
        }

        public void Running()
        {
            display.DisplayNewGameIteration(grid);
        }
    }
}
