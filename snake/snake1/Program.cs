﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*'); // обращение к классу Point (точка) - экземмпляр класс
            p1.Draw(); // рисуем точку

            Point p2 = new Point(4, 5, '#'); 
            p2.Draw();

            HorisontalLine line = new HorisontalLine(5, 10, 8, '+');
            line.Draw();

            VerticalLine line2 = new VerticalLine(7, 11, 8, '-');
            line2.Draw();


            Console.ReadLine();
        }
    }
}
