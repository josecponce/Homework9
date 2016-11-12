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

namespace Homework9 {
    public partial class MainForm : Form
    {

        private SnakeGame Game;
        private Rectangle dragBoxFromMouseDown;

        public MainForm()
        {
            InitializeComponent();
            Game = new SnakeGame();
            this.notifyIcon.Icon = Properties.Resources.snakeIcon;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameProgressControl.StartProgress(Game, this);
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

            if (open == true)
            {
                this.Hide();
                open = false;
            }
            else
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                open = true;
            }

        }

        private void printScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Printer p = new Printer(gameProgressControl.Chart);
            p.ShowDialog();
        }

        private void GraphDragSource_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            GameProgressControl gpc = (GameProgressControl)sender;
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
    }
}
