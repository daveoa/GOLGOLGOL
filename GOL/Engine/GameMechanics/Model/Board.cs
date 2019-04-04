using System;

namespace GOL.Engine.GameMechanics.Model
{
    public class Board
    {
        public bool[,] Grid { get; set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; } 
        public int Iteration { get; protected set; } 
        public int CellCount { get; protected set; } 
    }
}
