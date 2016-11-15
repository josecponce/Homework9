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

/*
 * -pause the game
 * -high scores should actually have the scores(store in the filesystem)
 * -apples placed at the right coordinates
 * -apples placed automatically
 * -check that snake doesnt go out of bounds(lose)
 * -drag and drop
 */
namespace Homework9 {
    public partial class MainForm : Form {

        private SnakeGame Game;
        private GameProgressWatcher Watcher;        
        private Rectangle dragBoxFromMouseDown;

        public MainForm() {
            InitializeComponent();
            Game = new SnakeGame();
            this.notifyIcon.Icon = Properties.Resources.snakeIcon;
            Game = new SnakeGame();
            Game.GameChanged += Game_GameChanged;
            Game.addApple();
            Game.initGame();

            gamePanel.Paint += GamePanel_Paint;
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e) {
            Game.doDrawing(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e) {
            ((Control)pictureBox).AllowDrop = true;
            Watcher = new GameProgressWatcher(Game, this);
            Watcher.NewData += graphGameProgressControl.UpdateGraph;
            Watcher.NewData += gridGameProgressControl.UpdateGraph;
            Watcher.Start();
        }

        private void switchViewToolStripMenuItem_Click(object sender, EventArgs e) {
            gridGameProgressControl.Visible = (gridGameProgressControl.Visible) ? false : true;
            graphGameProgressControl.Visible = (graphGameProgressControl.Visible) ? false : true;
        }

        bool open = true;
        private void Form_Resize(object sender, MouseEventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                this.Hide();
                open = false;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e) {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            open = true;
        }

        private delegate void SimplestDelegate();

        private void Game_GameChanged() {//this is called in a separate thread
            if (!this.IsDisposed) {
                this.Invoke(new SimplestDelegate(Del));
            }            
        }
        public void Del() {
            this.Invalidate(true);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            switch (keyData) {
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Left:
                    ProcessKeyDown(keyData);
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void ProcessKeyDown(Keys key) {
            if (key == Keys.Up)
                Game.setDirection(0);
            else if (key == Keys.Right)
                Game.setDirection(1);
            else if (key == Keys.Down)
                Game.setDirection(2);
            else if (key == Keys.Left)
                Game.setDirection(3);

            this.Invalidate(true);
        }

        private void printScoreToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Homework9.Printer p = new Homework9.Printer(graphGameProgressControl.Chart)) {
                p.ShowDialog();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {            
            Watcher.NewData -= graphGameProgressControl.UpdateGraph;
            Watcher.NewData -= gridGameProgressControl.UpdateGraph;
            Watcher.Dispose();
            Game.Dispose();
        }

        private void pictureBox_DragDrop(object sender, DragEventArgs e) {
            try {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string file = files[0];
                // Insert the item.
                pictureBox.Image = Image.FromFile(file);

            } catch (Exception) {
                MessageBox.Show("The image selected is not supported. \r\nSelect another picture", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void pictureBox_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
        private void pictureBox_MouseHover(object sender, EventArgs e) {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox, "Drag and Drop a picture!");
        }

        private void highScoreToolStripMenuItem_Click(object sender, EventArgs e) {
            HighScore.UserInfo uf = new HighScore.UserInfo();
            uf.Show();
        }

        private void pauseGameToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!Game.Paused) {
                Watcher.Pause();
                Game.Pause();                
                pauseGameToolStripMenuItem.Text = "Resume Game";
            } else if (Game.Paused) {                
                Game.Resume();
                Watcher.Resume();
                pauseGameToolStripMenuItem.Text = "Pause Game";
            }

        }
    }
}
