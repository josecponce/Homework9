using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Homework9.Domain {
    public class SnakeGame : IDisposable {
        public delegate void SimplestDelegate();
        public event SimplestDelegate GameChanged;
        public int Score => Snake.Length;
        public Direction SnakeDirection => Snake.Direction;

        private Snake Snake;
        private System.Timers.Timer MoveTimer;
        private System.Timers.Timer AppleTimer;
        private bool inGame;
        private Rectangle rectangleGraphic;
        private int DOTSIZE = 20;
        private List<Point> Apples = new List<Point>();
        private Size BoardSize;

        public SnakeGame(Size boardSize) {
            BoardSize = boardSize;
            Snake = new Snake(new Point(0, 0), Direction.Right);

            MoveTimer = new System.Timers.Timer();
            MoveTimer.Elapsed += MoveTimer_Elapsed;
            MoveTimer.Interval = 500;

            AppleTimer = new System.Timers.Timer();
            AppleTimer.Elapsed += AppleTimer_Elapsed;
            AppleTimer.Interval = 5000;

            inGame = true;
            rectangleGraphic = new Rectangle(10, 10, DOTSIZE, DOTSIZE);
        }

        private void AppleTimer_Elapsed(object sender, ElapsedEventArgs e) {
            addApple();
        }

        private void MoveTimer_Elapsed(object sender, ElapsedEventArgs e) {
            Move();
        }

        public bool Paused { get; private set; }
        public void Pause() {
            MoveTimer.Enabled = false;
            AppleTimer.Enabled = false;
            Paused = true;
        }
        public void Resume() {
            Paused = false;
            MoveTimer.Enabled = true;
            AppleTimer.Enabled = true;
        }
        public void EndGame() {
            MoveTimer.Enabled = false;
            AppleTimer.Enabled = false;
        }

        public void Dispose() {
            MoveTimer.Elapsed -= MoveTimer_Elapsed;
            MoveTimer.Enabled = false;
            MoveTimer?.Dispose();

            AppleTimer.Elapsed -= AppleTimer_Elapsed;
            AppleTimer.Enabled = false;
            AppleTimer?.Dispose();
        }

        public void doDrawing(Graphics g) {
            if (inGame) {
                //draw fruits
                foreach (var apple in Apples) {
                    g.DrawRectangle(new Pen(Color.Red), new Rectangle(apple.X, apple.Y, DOTSIZE, DOTSIZE));
                }

                for (int z = 0; z < Snake.Length; z++) {
                    //location of where to draw:
                    rectangleGraphic = new Rectangle(Snake.Location[z].X, Snake.Location[z].Y, DOTSIZE, DOTSIZE);
                    g.DrawRectangle(new Pen(Color.Black), rectangleGraphic);
                }
            } else {
                gameOver(g);
            }
        }

        private void gameOver(Graphics g) {
            MessageBox.Show("Game Over");
            MoveTimer.Enabled = false;
            AppleTimer.Enabled = false;
        }

        public void addApple() {
            Random rnd = new Random();
            Point apple = new Point();
            apple.X = rnd.Next(0, (BoardSize.Width - DOTSIZE) / DOTSIZE);
            apple.X = (DOTSIZE / 2) + (apple.X * DOTSIZE);
            apple.Y = rnd.Next(0, (BoardSize.Height - DOTSIZE) / DOTSIZE);
            apple.Y = (DOTSIZE / 2) + (apple.Y * DOTSIZE);
            Apples.Add(apple);
            GameChanged?.Invoke();
        }

        public void setDirection(int i) {
            Snake.Direction = (Direction)i;
        }

        public void Move() {

            var point = Snake.Location[0];

            for (int z = Snake.Length - 1; z > 0; z--) {
                //Snake.location.Add(new Point((z - 1), (z - 1)));
                //x[z] = x[(z - 1)];
                //y[z] = y[(z - 1)];
                Snake.Location[z] = new Point(Snake.Location[z - 1].X, Snake.Location[z - 1].Y);


            }

            if (SnakeDirection == Direction.Left) {
                Snake.Location[0] = new Point(point.X -= DOTSIZE, point.Y);
            } else if (SnakeDirection == Direction.Right) {
                Snake.Location[0] = new Point(point.X += DOTSIZE, point.Y);
            } else if (SnakeDirection == Direction.Up) {
                Snake.Location[0] = new Point(point.X, point.Y -= DOTSIZE);
            } else if (SnakeDirection == Direction.Down) {
                Snake.Location[0] = new Point(point.X, point.Y += DOTSIZE);
            }

            GameChanged?.Invoke();
        }

        //draws at the start
        public void initGame() {
            addApple();
            Snake.Length = 3;
            for (int z = 0; z < Snake.Length; z++) {
                Snake.Location.Add(new Point(50 - z * DOTSIZE, 50));
            }
            MoveTimer.Enabled = true;
            AppleTimer.Enabled = true;
        }
    }
}
