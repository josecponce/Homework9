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
               
        Up,
        Right,
        Down,
        Left
    }
    public class Snake
    {
        public int Length { get;  set; }
        public List<Point> Location { get;  set; }
        
        public Direction Direction { get; set; }
        private Point Position;

        public Snake(Point startingPosition, Direction startingDirection)
        {
            Position = startingPosition;
            Direction = startingDirection;
            Location = new List<Point>();
           
            Length = 1;
        }
    }
}
