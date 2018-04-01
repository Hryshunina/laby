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
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            // формируем рамку
            HorisontalLine upline = new HorisontalLine(0, 78, 0, '+');
            upline.Draw();

            HorisontalLine downline = new HorisontalLine(0, 78, 24, '+');
            downline.Draw();

            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            leftline.Draw();

            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            rightline.Draw();
             
            // рисуем точку
            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadLine();
            
        }
    }
}
