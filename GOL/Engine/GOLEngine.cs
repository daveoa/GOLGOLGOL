using GOL.Engine.BoardDisplayer;
using GOL.Engine.Config;
using GOL.Engine.GameMechanics;
using GOL.Engine.Menu;
using GOL.Engine.Menu.KeyPressTrigger;
using GOL.GameMechanics;
using System;
using System.Threading;

namespace GOL.Engine
{
    public class GOLEngine
    {
        private ConsoleMenu _menu;
        private Displayer _display;
        private BoardGame _gameBoard; 
        private NextLifecycle _gridUpdate;

        public GOLEngine()
        {
            _display = new Displayer();
            _gameBoard = new BoardGame();
            _gridUpdate = new NextLifecycle();
            _menu = new ConsoleMenu();
        }

        public void Start()
        {
            _gameBoard = NewBoardSetup(_gameBoard);
            _display.DisplayBoard(_gameBoard);
            Run();
        }

        private BoardGame NewBoardSetup(BoardGame game)
        {
            Tuple<int, int> dimensions;
            dimensions = _menu.FieldDimensonSetup();
            return game.CreateNewBoard(dimensions.Item1, dimensions.Item2);
        }

        private void Run()
        {
            while (EscapeKeyPress.ReadEscapeKeyPress())
            {
                _gameBoard.Grid = _gridUpdate.NewBoardCreation(_gameBoard);
                _display.DisplayBoard(_gameBoard);
                Thread.Sleep(ConfigSettings.Delay);
            }
        }
    }
}
