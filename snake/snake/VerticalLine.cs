﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yLeft, int yRight, char sym)
        {
            pList = new List<Point>();
            for(int y = yLeft; y <= yRight; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public void Draw()
        {
            foreach (Point point in pList)
            {
                point.Draw();
            }
        }

    }
}
