using GOL.Engine.BoardDisplayer;
using GOL.Engine.Config;
using GOL.Engine.GameMechanics;
using GOL.Engine.Menu;
using GOL.Engine.Menu.KeyPressTrigger;
using System;
using System.Threading;

namespace GOL.Engine
{
    public class GOLEngine
    {
        private ConsoleMenu _menu;
        private Displayer _display;
        private BoardGame _gameBoard; 
        //private NextLifecycle _gridUpdate; //BoardGame in iteration #2

        public GOLEngine()
        {
            _display = new Displayer();
            _gameBoard = new BoardGame();
            //_gridUpdate = new NextLifecycle();
            _menu = new ConsoleMenu();
        }

        public void Start()
        {
            _gameBoard = NewBoardSetup(_gameBoard);
            DisplayBoardInfo(_gameBoard);

            _gameBoard = Update(_gameBoard);
        }

        private BoardGame NewBoardSetup(BoardGame game)
        {
            Tuple<int, int> dimensions;
            //user sets width and height
            dimensions = _menu.FieldDimensonSetup();
            //returns a randomly generated board of width * height
            return game.CreateNewBoard(dimensions.Item1, dimensions.Item2);
        }

        private BoardGame Update(BoardGame game)
        {
            while (EscapeKeyPress.ReadEscapeKeyPress())
            {
                game = game.NextIteration(game);
                DisplayBoardInfo(game);
                Thread.Sleep(ConfigSettings.Delay);
            }
            return game;
        }

        private void DisplayBoardInfo(BoardGame game)
        {
            _display.DisplayBoard(game);
            _display.DisplayBoardStats(game);
        }
    }
}
