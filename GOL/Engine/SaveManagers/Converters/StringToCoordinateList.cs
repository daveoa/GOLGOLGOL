using GOL.Engine.GameMechanics.Models;
using System;
using System.Collections.Generic;

namespace GOL.Engine.SaveManagers.Converters
{
    public class StringToCoordinateList
    {
        public List<Coordinates> Transform(string s)
        {
            int x;
            int y;
            int index;
            var coordList = new List<Coordinates>();

            string[] stringPairs = s.Split(' ');
            foreach (string pair in stringPairs)
            {
                index = pair.IndexOf(',');
                if (index == -1) break;
                x = Convert.ToInt32(pair.Substring(0, index));
                y = Convert.ToInt32(pair.Substring(++index));
                coordList.Add(new Coordinates(x, y));
            }
            return coordList;
        }
    }
}
