using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class FoodCreator
    {
        private int maxWidth;
        private int maxHeight;
        private char sym;

        Random random = new Random();

        public FoodCreator(int maxWidth, int maxHeight, char sym)
        {
            this.maxWidth = maxWidth;
            this.maxHeight = maxHeight;
            this.sym = sym;
        }

        internal Point CreateFood()
        {
            int x = random.Next(2, maxWidth - 2);
            int y = random.Next(2, maxHeight - 2);

            Point point = new Point(x, y, sym);
            return point;
        }
    }
}
