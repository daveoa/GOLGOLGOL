using GOL.Engine.BoardDisplayer;
using GOL.Engine.Config;
using GOL.Engine.GameMechanics;
using GOL.Engine.Menu;
using GOL.Engine.Menu.KeyPressTriggers;
using GOL.Engine.SaveManagers;
using System.Threading;

namespace GOL.Engine
{
    public class GOLEngine
    {
        private ConsoleMenu _menu;
        private Displayer _display;
        private BoardGame _gameBoard;
        private SaveWriter _saveW;

        public GOLEngine()
        {
            _display = new Displayer();
            _gameBoard = new BoardGame();
            _menu = new ConsoleMenu();
            _saveW = new SaveWriter();
        }

        public void Start()
        {
            _gameBoard = NewBoardSetup(_gameBoard);
            DisplayBoardInfo(_gameBoard); 

            _gameBoard = Update(_gameBoard);

            SaveProcedure(_gameBoard);
        }

        private BoardGame NewBoardSetup(BoardGame game)
        {
            //user sets width and height
            var sizes = _menu.FieldDimensonSetup();
            //returns a randomly generated board of width * height
            return game.CreateNewBoard(sizes.Width, sizes.Height);
        }

        private BoardGame Update(BoardGame game)
        {
            while (EscapeKeyPress.EscIsNotPressed())
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

        private bool SaveProcedure(BoardGame game)
        {
            if (_menu.WantsToSaveGame())
            {
                var filename = _menu.GetFilenameFromInput();
                if (_saveW.SaveToFile(filename, game))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
