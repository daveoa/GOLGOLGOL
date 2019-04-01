using GOL.Engine.Display;
using GOL.Engine.Display.UserInput;
using GOL.Game;
using System.Threading;

namespace GOL.Engine
{
    public class GOLEngine
    {
        ConsoleWindow console;
        Displayer display;
        Board grid; // 'Game' 
        BoardNextIterationCalculation gridUpdate; // 'Game' 

        public GOLEngine()
        {
            console = new ConsoleWindow();
            display = new Displayer();
            grid = new Board(); //substitute with 'Game' later
            gridUpdate = new BoardNextIterationCalculation(); //substitute with 'Game' later
        }

        public void Start()
        {
            console.ConfigureConsole();
        }

        public void Create()
        {
            display.DisplayBoard(grid);
            display.DisplayCellCreation(grid);
        }

        public void Running()
        {
            ConsoleInput esc = new ConsoleInput();
            while (esc.ReadEscapeKeyPress())
            {
                gridUpdate.NewBoardCreation(grid);
                display.DisplayBoard(grid);
                Sleep();
            }
        }

        private void Sleep()
        {
            Thread.Sleep(ConfigSettings.Delay);
        }
    }
}
