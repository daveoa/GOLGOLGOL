﻿using GOL.Engine.GameMechanics;
using GOL.Engine.GameMechanics.Models;
using GOL.Engine.SaveManagers.Builders;
using GOL.Engine.SaveManagers.Converters;
using System;
using System.IO;

namespace GOL.Engine.SaveManagers
{
    public class SaveWriter
    {
        private FromGridToList _converter = new FromGridToList();
        private PathBuilder _pathBuild = new PathBuilder();

        public bool SaveToFile(string filename, BoardGame game)
        {
            var path = _pathBuild.Build(filename);
            var AliveCellList = _converter.ConvertToList(game);

            try
            {
                using (var writer = new StreamWriter(path))
                {
                    foreach (Coordinates coord in AliveCellList)
                    {
                        writer.Write($"{coord.X},{coord.Y} ");
                    }
                    writer.Write(Environment.NewLine);
                    writer.WriteLine(game.Width);
                    writer.WriteLine(game.Height);
                    writer.WriteLine(game.Iteration);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}