using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Domain
{
    public class Score : INotifyPropertyChanged
    {
        private int time;
        public int Time { get { return time; }  set { time = value; OnChanged(nameof(Time)); } }
        private int length;
        public int Length { get { return length; } set { length = value; OnChanged(nameof(Length)); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
