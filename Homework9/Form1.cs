using Homework9.Domain;
using Homework9.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework9 {
    public partial class MainForm : Form
    {

        private SnakeGame Game;
        private GameProgressWatcher Watcher;
        private System.Timers.Timer timer;
        private Rectangle dragBoxFromMouseDown;

        public MainForm()
        {
            InitializeComponent();
            Game = new SnakeGame();
            this.notifyIcon.Icon = Properties.Resources.snakeIcon;
            Game = new SnakeGame();
            Game.addApple();
            Game.initGame();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Watcher = new GameProgressWatcher(Game, this);
            Watcher.NewData += graphGameProgressControl.UpdateGraph;
            Watcher.NewData += gridGameProgressControl.UpdateGraph;
            Watcher.Start();
        }

        bool open = true;
        private void Form_Resize(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                open = false;
            }
        }


        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {     
                this.Show();
                this.WindowState = FormWindowState.Normal;
                open = true;
        }

        private void gridGameProgressControl_Load(object sender, EventArgs e)
        {

        }

        private delegate void Mydel();
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Game.move();
            this.Invoke(new Mydel(Del));
        }
        public void Del()
        {
            this.Invalidate();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Game.doDrawing(e.Graphics);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
                Game.setDirection(0);

            if (e.KeyCode == Keys.Right)
                Game.setDirection(1);

            if (e.KeyCode == Keys.Down)
                Game.setDirection(2);

            if (e.KeyCode == Keys.Left)
                Game.setDirection(3);

            Game.move();
            this.Refresh();
            //MessageBox.Show(game.SnakeDirection+" ");

        }

        private void printScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Homework9.Printer p = new Homework9.Printer(graphGameProgressControl.Chart);
            p.ShowDialog();
        }

        private void GraphDragSource_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            GraphGameProgressControl gpc = (GraphGameProgressControl)sender;
            Bitmap bmp = new Bitmap(gpc.Chart.Width, gpc.Chart.Height);
            gpc.DrawToBitmap(bmp, new Rectangle(0, 0, gpc.Chart.Width, gpc.Chart.Height));
            gpc.DoDragDrop(bmp, DragDropEffects.Copy);
            


            // Remember the point where the mouse down occurred. The DragSize indicates
            // the size that the mouse can move before a drag event should be started.                
            Size dragSize = SystemInformation.DragSize;           

        }

        private void GraphDragSource_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void highScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScore.UserInfo uf = new HighScore.UserInfo();
            uf.Show();
        }
    }
}
