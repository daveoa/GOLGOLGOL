using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    public static class ConfigSettings
    {
        public static int Width => 16;
        public static int Height => 16;
        public static char FullBlock => '\u2588';
        public static char EmptyBlock => '_';
        public static int Delay => 1000; //1 second
    }
}
