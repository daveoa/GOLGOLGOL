using GOL.Engine.GameMechanics.Models;
using System.Collections.Generic;

namespace GOL.Engine.SaveManagers.Converters
{
    public class CoordinateListToGrid
    {
        public bool[,] Transform(int width, int height, List<Coordinates> coordinateList)
        {
            bool[,] tempBoard = new bool[width, height];
            foreach (var coord in coordinateList)
            {
                tempBoard[coord.X, coord.Y] = true;
            }
            return tempBoard;
        }
    }
}
