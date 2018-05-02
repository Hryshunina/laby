using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction direction) // конструктор
        {
            pList = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail); // точка, копия хвостовой точки tail
                p.Move(i, direction); // сдвигаем эту точку на i по направлению direction
                pList.Add(p); // добавить эту точку в список
            }
        }
    }
}
