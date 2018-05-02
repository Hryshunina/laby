using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class Snake : Figure
    {
        Direction direction_1;

        public Snake(Point tail, int lenght, Direction direction) // конструктор
        {
            direction_1 = direction;

            pList = new List<Point>();

            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail); // точка, копия хвостовой точки tail
                p.Move(i, direction); // сдвигаем эту точку на i по направлению direction
                pList.Add(p); // добавить эту точку в список
            }

        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint() // метод  передает новое (новую точку) положение головы змейки
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction_1);
            return nextPoint;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }

        public bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction_1 = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction_1 = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction_1 = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction_1 = Direction.UP;
        }
    }
}
