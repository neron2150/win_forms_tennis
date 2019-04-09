using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis
{
    class Painter 
    {
        private static Graphics g,gg;
        private static Bitmap buffer;
        private static Thread t;
        public static void Init(Graphics g,Form1 f)
        {
            buffer = new Bitmap(f.Size.Width, f.Size.Height);
            Painter.g = Graphics.FromImage(buffer);
            gg = g;
            t = new Thread(Painter.paint);
            t.Start();
        }

        internal static void paint()
        {try
            {
                while (true)
                {
                    g.Clear(Color.Azure);
                    g.FillRectangle(Brushes.OrangeRed, Info.FrameX - 20, 0, 20, 20);
                    g.DrawRectangle(Pens.Black, Coords.PrcX - 50, Coords.PrcY, 100, 20);
                    g.DrawRectangle(Pens.Black, Coords.CrcX - 50, Coords.CrcY, 100, 20);
                    g.DrawEllipse(Pens.Black, Coords.BcX - 10, Coords.BcY - 10, 20, 20);
                    Font drawFont = new Font("Arial", 16);
                    SolidBrush drawBrush = new SolidBrush(Color.Black);
                    g.DrawString("Игрок: " + Info.PCount + "\n" + "Компьютер: " + Info.CCount, drawFont, drawBrush, 0, 0);
                    gg.DrawImage(buffer, 0, 0);
                    Thread.Sleep(Info.Speed);
                }
            }
            catch
            {
               t.Abort();
            }
           
            
        }
    }
}
