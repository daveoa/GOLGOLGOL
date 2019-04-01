using System.Text;

namespace GOL
{
    public class BoardToStringBuilder
    {
        public string ConvertToString(Board grid)
        {
            var boardString = new StringBuilder();
            for (int y = 0; y < (int)ConfigSettings.DimensionValues.BoardHeight; y++)
            {
                for (int x = 0; x < (int)ConfigSettings.DimensionValues.BoardHeight; x++)
                {
                    char c = grid.GetValue(x, y) ? ConfigSettings.FullBlock : ConfigSettings.EmptyBlock;
                    // 2 appends because that will make a nice square
                    boardString.Append(c);
                    boardString.Append(c);
                }
                boardString.Append("\n");
            }
            return boardString.ToString();
        }
    }
}
