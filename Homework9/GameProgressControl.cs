using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Homework9.Domain;
using System.Windows.Forms.DataVisualization.Charting;

namespace Homework9
{
    public partial class GameProgressControl : UserControl
    {
        private SnakeGame Game;
        private System.Timers.Timer Timer;
        private int time = 1;
        private List<Point> Data;
        private Form Owner;


        public GameProgressControl()
        {
            InitializeComponent();
        }

        public void StartProgress(SnakeGame game, Form owner)
        {
            Owner = owner;
            Game = game;
            Data = new List<Point>();
            Data.Add(new Point(time, game.Score));
            GameProgressChart.Series[0].Points.AddXY(time, game.Score);
            
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
            Owner.Invoke(new UpdateGraphDel(UpdateGraph), new object[] { currentTime, score });
        }

        private delegate void UpdateGraphDel(int x, int y);
        private void UpdateGraph(int x, int y)
        {
            GameProgressChart.Series[0].Points.AddXY(x, y);
        }

        public new void Dispose()
        {
            base.Dispose();
            Timer?.Dispose();
            Game?.Dispose();
        }
    }
}
