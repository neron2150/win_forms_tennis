using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tennis
{
    class Game
    {
       
        public Game()
        {
            Thread t = new Thread(Run);
            t.Start();
        }
        
        private void Run()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(Info.Speed * 2);
                    ReplaceRocket();
                    ReplaceBall();
                    CheckRockets();
                    CheckForWin();
                }
            }
            catch
            {
                
            }
           
        }

        private void CheckRockets()
        {
            bool a = Coords.BcX > Coords.CrcX - 50 && Coords.BcX < Coords.CrcX + 50;
            bool b = Coords.BcX > Coords.PrcX - 50 && Coords.BcX < Coords.PrcX + 50;
            bool c = Coords.BcY - Coords.CrcY - 30 < 0&& Coords.BcY - Coords.CrcY - 30 > -4;
            bool d = Coords.BcY - Coords.PrcY + 10 > 0&& Coords.BcY - Coords.PrcY + 10 < 4;
            if (a && c)
            {
                Info.BallVectorY = 2;
                Info.BallVectorX = Info.BallVectorX + (Coords.CrcX - Coords.BcX) / -20;
                Coords.BcY = 70;
            }
            if (b && d)
            {
                Info.BallVectorY = -2;
                Info.BallVectorX = Info.BallVectorX + (Coords.PrcX - Coords.BcX) / -20;
                Coords.BcY = Info.FrameY - 40;
            }
        }

        private void CheckForWin()
        {
            if (Coords.BcY < 0)
            {
                if (Info.Speed > 5)
                { Info.Speed--; }
                Info.PCount++;
                Coords.Init();
                Info.BallVectorX = 0;
                Info.BallVectorY = 0;
                Info.Started = false;
            }
            if (Coords.BcY > Info.FrameY)
            {
                if (Info.Speed > 5)
                { Info.Speed--; }
                Info.CCount++;
                Coords.Init();
                Info.BallVectorX = 0;
                Info.BallVectorY = 0;
                Info.Started = false;
            }
        }

        private void ReplaceBall()
        {
            Coords.BcX += Info.BallVectorX;
            Coords.BcY += Info.BallVectorY;
            if(Coords.BcX> Info.FrameX-10|| Coords.BcX<10)
            {
                Info.BallVectorX = Info.BallVectorX * -1;
            }

        }

        private void ReplaceRocket()
        {
            if (Coords.CrcX < Coords.BcX)
            { Coords.CrcX += 3; }
            if (Coords.CrcX > Coords.BcX)
            { Coords.CrcX -= 3; }
        }
    }
}
