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
using Homework9.UserControls;

namespace Homework9
{
    public partial class GraphGameProgressControl : UserControl
    {
        public Chart Chart => GameProgressChart;
        public GraphGameProgressControl()
        {
            InitializeComponent();
        }
        public void UpdateGraph(int x, int y)
        {
            GameProgressChart.Series[0].Points.AddXY(x, y);
        }
    }
}
