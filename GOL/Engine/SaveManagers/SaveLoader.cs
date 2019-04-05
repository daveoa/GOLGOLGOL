using GOL.Engine.GameMechanics;
using GOL.Engine.SaveManagers.Builders;
using GOL.Engine.SaveManagers.Converters;
using GOL.Engine.SaveManagers.Models;
using System;
using System.IO;

namespace GOL.Engine.SaveManagers
{
    public class SaveLoader
    {
        private PathBuilder _pathBuild = new PathBuilder();
        private FileStringToGrid _toGrid = new FileStringToGrid();

        public FileLoadResult LoadFromFile(string filename)
        {
            var result = new FileLoadResult();
            var path = _pathBuild.Build(filename);

            if (!File.Exists(path))
            {
                result.isLoadSuccessful = false;
                return result;
            }
            try
            {
                using (var reader = new StreamReader(path))
                {
                    var game = new BoardGame();
                    var coordinates = reader.ReadLine();
                    game.Width = Convert.ToInt32(reader.ReadLine());
                    game.Height = Convert.ToInt32(reader.ReadLine());
                    game.Grid = _toGrid.Transform(game.Width, game.Height, coordinates);
                    game.Iteration = Convert.ToInt32(reader.ReadLine());

                    result.isLoadSuccessful = true;
                    result.gameFromSave = game;
                    return result;
                }
            }
            catch (Exception)
            {
                result.isLoadSuccessful = false;
                return result;
            }
        }
    }
}
