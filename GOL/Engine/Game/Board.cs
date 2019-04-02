using System;

namespace GOL.Engine.Game
{
    public class Board
    {
        public bool[,] Grid { get; set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public void CreateNewBoard(int x, int y)
        {
            Width = x;
            Height = y;
            Grid = new bool[Width, Height];
            FillBoard();
        }

        private void FillBoard()
        {
            var random = new Random();
            for (var i = 0; i < Height; i++)
            {
                for (var j = 0; j < Width; j++)
                {
                    Grid[j, i] = random.Next(2) == 0;
                }
            }
        }
    }
}
