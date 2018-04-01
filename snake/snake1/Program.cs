using System;
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

            List<int> numList = new List<int>(); // список
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList) // пробежаться по всем элементам
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0); // удалить элемент

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadLine();
        }
    }
}
