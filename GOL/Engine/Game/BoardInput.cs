namespace GOL.Game
{
    class BoardInput
    {
        public void AddNewAliveCell(int x, int y, Board grid)
        {
            grid.SetValue(x, y);
        }

        public void AddNewDeadCell(int x, int y, Board grid)
        {
            grid.SetValue(x, y, false);
        }
    }
}
