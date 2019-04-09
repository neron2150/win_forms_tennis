using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Info.Init(this);
            Coords.Init();
             new Game();
            Painter.Init(this.CreateGraphics(),this);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Coords.PrcX = e.X;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.X>this.Width-20&& e.Y <  20)
            {
                Process.GetCurrentProcess().Kill();
            }
            if (!Info.Started)
            {
                Info.BallVectorX = 0;
                Info.BallVectorY = 1;
                Info.Started = true;
            }
            
        }
    }
}
