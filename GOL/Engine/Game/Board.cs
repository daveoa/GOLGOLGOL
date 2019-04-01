namespace GOL
{
    public class Board
    {
        private bool[,] _Grid;

        public Board()
        {
            _Grid = new bool[(int)ConfigSettings.DimensionValues.BoardWidth, (int)ConfigSettings.DimensionValues.BoardHeight];
            //Iteration = 0;
            //CellCount = 0;
        }

        public bool GetValue(int x, int y)
        {
            return _Grid[x, y];
        }

        public void SetValue(int x, int y, bool value = true)
        {
            _Grid[x, y] = value;
        }
    }
}
