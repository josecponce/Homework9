using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Homework9.Domain
{
    public class SnakeGame : IDisposable
    {
        public int Score { get; set; }
        private Snake Snake;
        private Timer MoveTimer;
        private Timer AppleTimer;

        public SnakeGame()
        {
            Snake = new Snake(new Point(0, 0), Direction.Right);

            MoveTimer = new Timer();
            
            MoveTimer.Interval = 500;
            MoveTimer.Enabled = true;

            AppleTimer = new Timer();
            
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
            MoveTimer?.Dispose();
        }

        
    }
}
