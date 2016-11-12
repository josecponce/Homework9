using Homework9.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework9
{
    public partial class Form1 : Form
    {


        private System.Timers.Timer timer;
        private SnakeGame game;
        public Form1()
        {

            InitializeComponent();
            game = new SnakeGame();
            game.addApple();
            game.initGame();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        private delegate void Mydel();
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            game.move();
            this.Invoke(new Mydel(Del));
        }
        public void Del()
        {
            this.Invalidate();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            game.doDrawing(e.Graphics);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
                game.setDirection(0);

            if (e.KeyCode == Keys.Right)
                game.setDirection(1);

            if (e.KeyCode == Keys.Down)
                game.setDirection(2);

            if (e.KeyCode == Keys.Left)
                game.setDirection(3);

            game.move();
            this.Refresh();
            //MessageBox.Show(game.SnakeDirection+" ");

        }
    }
}
