using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    class Coords
    {
        //prc - Player Rocket Coords
        //crc - Computer Rocket Coords
        //Bc - Ball Coords
        public static void Init()
        {
            Coords.CrcX = Info.FrameX / 2;
            Coords.CrcY = 40;
            Coords.PrcX = Info.FrameX / 2;
            Coords.PrcY = Info.FrameY - 30;
            Coords.BcX = Info.FrameX / 2;
            Coords.BcY = Info.FrameY / 2;
        }
        public static int CrcX
        { get; set; }
        public static int CrcY
        { get; set; }
        public static int PrcX
        { get; set; }
        public static int PrcY
        { get; set; }
        public static int BcX
        { get; set; }
        public static int BcY
        { get; set; }
    }
}
