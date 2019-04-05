namespace GOL.Engine.SaveManagers.Converters
{
    public class FileStringToGrid
    {
        private StringToCoordinateList _strToCoordList = new StringToCoordinateList();
        private CoordinateListToGrid _coordListToGrid = new CoordinateListToGrid();

        public bool[,] Transform(int width, int height, string s)
        {
            var coordList = _strToCoordList.Transform(s);
            return _coordListToGrid.Transform(width, height, coordList);
        }
    }
}
