using GOL.Engine.BoardDisplayer;
using GOL.Engine.Config;
using GOL.Engine.GameMechanics;
using GOL.Engine.Menu;
using GOL.Engine.Menu.KeyPressTriggers;
using GOL.Engine.SaveManagers;
using GOL.Engine.SaveManagers.Models;
using System.Threading;

namespace GOL.Engine
{
    public class GOLEngine
    {
        private ConsoleMenu _menu;
        private Displayer _display;
        private BoardGame _gameBoard;
        private SaveWriter _saveW;
        private SaveLoader _saveL;

        public GOLEngine()
        {
            _display = new Displayer();
            _gameBoard = new BoardGame();
            _menu = new ConsoleMenu();
            _saveW = new SaveWriter();
            _saveL = new SaveLoader();
        }

        public void Start()
        {
            bool isSuccess = this.LoadProcedure();
            if (!isSuccess)
            {
                _gameBoard = this.NewBoardSetup();
            }
            this.DisplayBoardInfo(); 
            _gameBoard = this.Update();
            this.SaveProcedure();
        }

        private BoardGame NewBoardSetup()
        {
            //user sets width and height
            var sizes = _menu.FieldDimensonSetup();
            //returns a randomly generated board of width * height
            return _gameBoard.CreateNewBoard(sizes.Width, sizes.Height);
        }

        private BoardGame Update()
        {
            while (EscapeKeyPress.EscIsNotPressed())
            {
                _gameBoard.NextIteration();
                this.DisplayBoardInfo();
                Thread.Sleep(ConfigSettings.Delay);
            }
            return _gameBoard;
        }

        private void DisplayBoardInfo()
        {
            _display.DisplayBoard(_gameBoard);
            _display.DisplayBoardStats(_gameBoard);
        }

        private bool SaveProcedure()
        {
            if (_menu.WantsToSaveGame())
            {
                var filename = _menu.GetFilenameFromInput(ConfigSettings.SaveNameInquiry);
                if (_saveW.SaveToFile(filename, _gameBoard))
                {
                    return true;
                }
            }
            return false;
        }

        private bool LoadProcedure()
        {
            if (_menu.WantsToLoadGame())
            {
                var loadResult = new FileLoadResult();
                var filename = _menu.GetFilenameFromInput(ConfigSettings.LoadNameInquiry);
                loadResult = _saveL.LoadFromFile(filename);
                if (loadResult.isLoadSuccessful)
                {
                    _gameBoard = loadResult.gameFromSave;
                    return true;
                }
            }
            return false;
        }
    }
}
