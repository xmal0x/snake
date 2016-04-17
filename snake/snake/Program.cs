using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            HorizontalLine topHLine = new HorizontalLine(0, 118, 0, '*');
            HorizontalLine downHLine = new HorizontalLine(0, 118, 29, '*');
            VerticalLine leftVLine = new VerticalLine(0, 0, 29, '*');
            VerticalLine rightVLine = new VerticalLine(118, 0, 29, '*');

            topHLine.Draw();
            downHLine.Draw();
            leftVLine.Draw();
            rightVLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadKey();
        }

    }
}
