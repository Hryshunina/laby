﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point() // конструктор (функция), метод
        {
          
        }

        public Point(int _x, int _y, char _sym) // конструктор2
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p) // конструктор 3
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction) // метод сдвигания точки
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool IsHit(Point p) // есть ли пересечение змейки с едой
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw() // метод рисования точки
        { 
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }

    
}
