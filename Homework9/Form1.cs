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
    public partial class MainForm : Form {

        private SnakeGame Game;
        private GameProgressWatcher Watcher;

        public MainForm() {
            InitializeComponent();
            Game = new SnakeGame();
            this.notifyIcon.Icon = Properties.Resources.snakeIcon;
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

            if (open == true)
            {
                this.Hide();
                open = false;
            }
            else {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                open = true;
            }

           
          
        }

        private void gridGameProgressControl_Load(object sender, EventArgs e)
        {

        }

        private void printScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Homework9.Printer p = new Homework9.Printer(graphGameProgressControl.Chart);
            p.ShowDialog();
        }
    }
}
