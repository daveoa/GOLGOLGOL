using GOL.Engine.Config;
using GOL.Engine.Display;
using GOL.Engine.Display.Helper;
using GOL.Engine.Game;
using GOL.Game;
using System.Threading;

namespace GOL.Engine
{
    public class GOLEngine
    {
        Displayer Display;
        BoardGame GameBoard; 
        NextLifecycle GridUpdate;

        public GOLEngine()
        {
            Display = new Displayer();
            GameBoard = new BoardGame();
            GridUpdate = new NextLifecycle();
        }

        public void Start()
        {
            Create();
            Run();
        }

        private void Create()
        {
            Display.FieldCreation(GameBoard);
            Display.DisplayBoard(GameBoard);
        }

        private void Run()
        {
            while (EscapeKeyPress.ReadEscapeKeyPress())
            {
                GameBoard.Grid = GridUpdate.NewBoardCreation(GameBoard);
                Display.DisplayBoard(GameBoard);
                Thread.Sleep(ConfigSettings.Delay);
            }
        }
    }
}
