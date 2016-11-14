using Homework9.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Homework9.UserControls
{
    public class GameProgressWatcher : IDisposable
    {
        public delegate void UpdateGraphDel(int time, int score);
        public event UpdateGraphDel NewData;

        private SnakeGame Game;
        private System.Timers.Timer Timer;
        private int time = 0;
        private List<Point> Data;
        private Form Owner;

        public GameProgressWatcher(SnakeGame game, Form owner)
        {
            Owner = owner;
            Game = game;
            Data = new List<Point>();            
        }

        public void Start()
        {
            Timer = new System.Timers.Timer();
            Timer.Interval = 1000;
            Timer.Elapsed += RefreshData;
            Timer.Enabled = true;
        }

        private void RefreshData(object sender, ElapsedEventArgs e)
        {
            time++;
            int score = Game.Score;
            int currentTime = time;
            Data.Add(new Point(time, score));
            Owner?.Invoke(new UpdateGraphDel(Update), new object[] { currentTime, score });
        }

        public void Update(int time, int score)
        {
            NewData?.Invoke(time, score);
        }

        public void Dispose()
        {
            Timer.Elapsed -= RefreshData;
            Timer.Enabled = false;
            Timer?.Dispose();
        }
    }
}
