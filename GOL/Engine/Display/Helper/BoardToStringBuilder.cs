using GOL.Engine.Config;
using GOL.Engine.Game;
using System.Text;

namespace GOL.Engine.Display.Helper
{
    public class BoardToStringBuilder
    {
        public string ConvertToString(Board grid)
        {
            var boardString = new StringBuilder();
            for (int y = 0; y < grid.Height; y++)
            {
                for (int x = 0; x < grid.Width; x++)
                {
                    char c = grid.Grid[x, y] ? ConfigSettings.FullBlock : ConfigSettings.EmptyBlock;
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
