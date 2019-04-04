using GOL.Engine.BoardDisplayer.Builders;
using GOL.Engine.Config;
using GOL.Engine.GameMechanics;
using System;

namespace GOL.Engine.BoardDisplayer
{
    public class Displayer
    {
        private BoardToStringBuilder _stringdBoard = new BoardToStringBuilder();

        public void DisplayBoard(BoardGame table)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write(_stringdBoard.ConvertToString(table));
        }

        public void DisplayBoardStats(BoardGame table)
        {
            Console.Write(ConfigSettings.CellCount, table.CellCount);
            Console.Write("\n");
            Console.Write(ConfigSettings.Iteration, table.Iteration);
        }
    }
}
