using System;

namespace GOL.Engine.GameMechanics.Models
{
    public class Board
    {
        public bool[,] Grid { get; set; }
        public int Width { get; set; }
        public int Height { get; set; } 
        public int Iteration { get; set; } 
        public int CellCount { get; set; } 
    }
}
