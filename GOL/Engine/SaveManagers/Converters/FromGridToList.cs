using GOL.Engine.GameMechanics;
using GOL.Engine.GameMechanics.Models;
using System.Collections.Generic;

namespace GOL.Engine.SaveManagers.Converters
{
    public class FromGridToList
    {
        public List<Coordinates> ConvertToList(BoardGame table)
        {
            var AliveCellList = new List<Coordinates>();

            for (int y = 0; y < table.Height; y++)
            {
                for (int x = 0; x < table.Width; x++)
                {
                    if (table.Grid[x, y])
                    {
                        AliveCellList.Add(new Coordinates(x, y));
                    }
                }
            }
            return AliveCellList;
        }
    }
}
