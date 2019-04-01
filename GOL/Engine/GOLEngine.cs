using GOL.Engine.Display;
using System.Threading;

namespace GOL.Engine
{
    public class GOLEngine
    {
        public void Start()
        {
            ConsoleWindow console = new ConsoleWindow();
            Displayer display = new Displayer();
            Board grid = new Board();

            console.ConfigureConsole();
            display.DisplayBoard(grid);
            display.DisplayCellCreation(grid);
            display.DisplayNewGameIteration(grid);
        }
    }
}
