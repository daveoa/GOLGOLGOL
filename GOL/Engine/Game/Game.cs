using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL.Engine.Game
{
    public class BoardGame : Board
    {
        public int Iteration { get; protected set; }
        public int CellCount { get; protected set; }

    }
}
