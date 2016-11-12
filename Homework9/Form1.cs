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
    public partial class MainForm : Form {

        private SnakeGame Game;

        public MainForm() {
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
            else {
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
    }
}
