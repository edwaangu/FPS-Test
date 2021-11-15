using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPS_Test
{
    public partial class Form1 : Form
    {

        // Framerate related variables
        int framesSinceLastSecond = 0;
        int accurateSec = -1;
        int lastSec = -1;
        int fps = 0;

        Random randGen = new Random();
        List<Square> squares = new List<Square>();

        int mode = 0;
        int counter = 0;
        int timesNot60;


        public Form1()
        {
            InitializeComponent();
        }

        private void updateTick_Tick(object sender, EventArgs e)
        {
            // Framerate
            framesSinceLastSecond++;
            accurateSec = DateTime.Now.Second;
            if (lastSec != accurateSec)
            {
                lastSec = accurateSec;
                fps = framesSinceLastSecond;
                framesSinceLastSecond = 0;
            }

            if(fps >= 60) {
                for (int i = 0; i < 5; i++)
                {
                    counter++;
                    squares.Add(new Square(randGen.Next(0, 850), randGen.Next(0, 450), randGen.Next(2, 50)));
                }
            }
            else
            {
                times
            }

            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            foreach(Square square in squares)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), square.x, square.y, square.size, square.size);
            }


            e.Graphics.DrawString($"FPS: {fps}\nCOUNTER: {counter}", new Font("Segoe UI", 20, FontStyle.Bold), new SolidBrush(Color.White), 10, 10);
        }
    }
}
