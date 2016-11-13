using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Homework9.Domain
{
    public class SnakeGame : IDisposable
    {
        public int Score => Snake.Length;
        public Direction SnakeDirection => Snake.Direction;

        private Snake Snake;
        private System.Timers.Timer MoveTimer;
        private System.Timers.Timer AppleTimer;
        private bool inGame;
        private Rectangle rectangleGraphic;
        private int DOTSIZE = 20;
        private Point apple;

        public SnakeGame()
        {
            Snake = new Snake(new Point(0, 0), Direction.Right);

            MoveTimer = new System.Timers.Timer();
            MoveTimer.Elapsed += MoveTimer_Elapsed;
            MoveTimer.Interval = 500;
            MoveTimer.Enabled = true;
            inGame = true;
            rectangleGraphic = new Rectangle(10, 10, DOTSIZE, DOTSIZE);
            apple = new Point(50, 50);

            AppleTimer = new System.Timers.Timer();

        }

        private void MoveTimer_Elapsed(object sender, ElapsedEventArgs e)
        {

        }

        public void EndGame()
        {
            MoveTimer.Enabled = false;
        }


        public void Dispose()
        {
            MoveTimer.Enabled = false;
            MoveTimer?.Dispose();
        }


        public void doDrawing(Graphics g)
        {
            //test:
            //Snake.location.Add(new Point(10, 10));
            //Snake.Length = 1;

            if (inGame)
            {

                //g.drawImage(apple, apple_x, apple_y, this);

                //draw fruit:
                g.DrawRectangle(new Pen(Color.Red), new Rectangle(apple.X, apple.Y, DOTSIZE, DOTSIZE));

                for (int z = 0; z < Snake.Length; z++)
                {
                    //location of where to draw:
                    rectangleGraphic = new Rectangle(Snake.location[z].X, Snake.location[z].Y, DOTSIZE, DOTSIZE);
                    //g.drawImage(head, x[z], y[z], this);

                    g.DrawRectangle(new Pen(Color.Black), rectangleGraphic);

                }

            }
            else
            {

                gameOver(g);
            }
        }


        private void gameOver(Graphics g)
        {
            MessageBox.Show("Game Over");

        }


        public void addApple()
        {
            Random rnd = new Random();
            apple.X = rnd.Next(0, 500);
            apple.Y = rnd.Next(0, 500);

        }

        public void setDirection(int i)
        {
            Snake.Direction = (Direction)i;

        }

        public void move()
        {

            var point = Snake.location[0];

            for (int z = Snake.Length -1; z > 0; z--)
            {
                //Snake.location.Add(new Point((z - 1), (z - 1)));
                //x[z] = x[(z - 1)];
                //y[z] = y[(z - 1)];
                Snake.location[z] = new Point(Snake.location[z - 1].X, Snake.location[z - 1].Y);


            }


            if (SnakeDirection == Direction.Left)
            {
                //Snake.location[0].X.Equals(point.X -= DOTSIZE);

                Snake.location[0] = new Point(point.X -= DOTSIZE, point.Y);

                //point.X -= DOTSIZE;
                //MessageBox.Show("e"+ Snake.location[0].X);

            }

            if (SnakeDirection == Direction.Right)
            {
                Snake.location[0] = new Point(point.X += DOTSIZE, point.Y);
            }

            if (SnakeDirection == Direction.Up)
            {
                Snake.location[0] = new Point(point.X , point.Y -= DOTSIZE);
                
            }

            if (SnakeDirection == Direction.Down)
            {
                Snake.location[0] = new Point(point.X, point.Y += DOTSIZE);
            }

        }


        //draws at the start
        public void initGame()
        {

            Snake.Length = 3;

            for (int z = 0; z < Snake.Length; z++)
            {

                Snake.location.Add(new Point(50 - z * 10, 50));
                //= 50 - z * 10;            
                //y[z] = 50;
            }



        }


    }
}
