using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class HorisontalLine
    {
        List<Point> pList;

        public HorisontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>(); // создаем пустой список
            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

            /* Point p1 = new Point(4, 4, '*');
            Point p2 = new Point(5, 4, '*');
            Point p3 = new Point(6, 4, '*');
            // заполняем список точками
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            */
        }

        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
