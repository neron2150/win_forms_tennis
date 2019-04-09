using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public static class Info
    {
        public static bool Started { get; set; }
        public static int Speed { get; set; }
        public static int BallVectorX { get; set; }
        public static int BallVectorY { get; set; }
        public static int FrameX { get; set; }
        public static int PCount { get; set; }
        public static int CCount { get; set; }
        public static int FrameY { get; set; }

        internal static void Init(Form1 form1)
        {
            Speed = 10;
            FrameX = form1.Size.Width;
            FrameY = form1.Size.Height;
        }
    }
}
