using GOL.Engine.BoardDisplayer.Builder;
using GOL.Engine.GameMechanics;
using System;

namespace GOL.Engine.BoardDisplayer
{
    public class Displayer
    {
        public void DisplayBoard(BoardGame grid)
        {
            BoardToStringBuilder stringdBoard = new BoardToStringBuilder();
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write(stringdBoard.ConvertToString(grid));
        }
    }
}
