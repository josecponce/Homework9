using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework9.Domain;

namespace Homework9.UserControls
{
    public partial class GridGameProgressControl : UserControl
    {
        public BindingList<Score> values = new BindingList<Score>();
        public GridGameProgressControl()
        {
            InitializeComponent();
            gameProgressGrid.DataSource = values;
        }

        public void UpdateGraph(int x, int y)
        {
            values.Add(new Domain.Score { Time = x, Length = y });
        }
    }
}
