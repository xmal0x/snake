using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.DOWN)
            {
                this.y = y + offset;
            }
            if(direction == Direction.TOP)
            {
                this.y = y - offset;
            }
            if(direction == Direction.LEFT)
            {
                this.x = x - offset;
            }
            if(direction == Direction.RIGHT)
            {
                this.x = x + offset;
            }
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        internal bool IsHit(Point p)
        {
            return this.x == p.x && this.y == p.y;
        }
    }
}
