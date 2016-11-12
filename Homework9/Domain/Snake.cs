using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9.Domain
{
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }
    public class Snake
    {
        public int Length { get; private set; }
        private List<Point> Turns;
        private Direction Direction;
        private Point Position;

        public Snake(Point startingPosition, Direction startingDirection)
        {
            Position = startingPosition;
            Direction = startingDirection;
            Turns = new List<Point>();
            Length = 1;
        }


    }
}
