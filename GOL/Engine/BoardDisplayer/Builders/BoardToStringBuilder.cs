using GOL.Engine.Config;
using GOL.Engine.GameMechanics;
using System.Text;

namespace GOL.Engine.BoardDisplayer.Builders
{
    public class BoardToStringBuilder
    {
        public string ConvertToString(BoardGame table)
        {
            var BoardString = new StringBuilder();

            for (int y = 0; y < table.Height; y++)
            {
                for (int x = 0; x < table.Width; x++)
                {
                    char c = table.Grid[x, y] ? ConfigSettings.FullBlock : ConfigSettings.EmptyBlock;
                    string squareBlock = $"{c}" + $"{c}";
                    BoardString.Append(squareBlock);
                }
                BoardString.Append("\n");
            }
            return BoardString.ToString();
        }
    }
}
