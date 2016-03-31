using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            HorizontalLine hLine = new HorizontalLine(7, 12, 6, '+');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(10, 3, 10, '-');
            vLine.Draw();

            Console.ReadKey();
        }

    }
}
