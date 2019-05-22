using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Transport //класс Транспортное средство 
        {
            public string name; // название
            public double var;  // стоимость

            public Transport() // конструктор Транспортное средство
            {
                int d = (int)DateTime.Now.Ticks;
                Random rnd = new Random(d);
                int r = rnd.Next(1, 10);
                switch (r)
                {
                    case 1: { name = "Самолет"; break; }
                    case 2: { name = "Корабль"; break; }
                    case 3: { name = "Поезд"; break; }
                    case 4: { name = "Велосипед"; break; }
                    case 5: { name = "Автомобиль"; break; }
                    case 6: { name = "Пароход"; break; }
                    case 7: { name = "Лодка"; break; }
                    case 8: { name = "Вертолет"; break; }
                    case 9: { name = "Метро"; break; }
                    case 10: { name = "Троллейбус"; break; }
                }
                var = rnd.Next(1, 25);
            }
            public Transport(string n)
            {
                name = n;
            }
            public virtual void Print(DataGridView dg) 
            {
                dg.Rows.Add("Название name", name.ToString());
                dg.Rows.Add("Стоимость var", var.ToString());
            }

            public virtual double s() 
            {
                return 0;
            }

        } 
        class Plane : Transport // класс Самолет
        {
            private double h, v; // высота  - h, скорость - v

            public Plane() // конструктор з параметрами
            {
                int d = (int)DateTime.Now.Ticks;
                Random rnd = new Random(d);
                h = rnd.Next(1, 10);
                v = rnd.Next(1, 20);
                name = "Самолет";
            }

            public Plane(double hh, double vv) // конструктор з параметрами
            {
                h = hh;
                v = vv;
                name = "Самолет";
            }

            public override double s() // метод возвращает 
            {
                double s;
                s = 100 * h * v;
                return s;
            }

            public override void Print(DataGridView dg) // метод возвращает 
            {
                var = s();
                base.Print(dg);
                dg.Rows.Add("Высота h", h.ToString());
                dg.Rows.Add("Скорость v", v.ToString());
            }
        }

        class Ship : Transport // класс Корабль
        {
            private double k;
            private string port; 
            public Ship()
            {
                int d = (int)DateTime.Now.Ticks;
                Random rnd = new Random(d);
                k = rnd.Next(1, 100);
                
                int p = rnd.Next(1, 5);
                switch (p)
                {
                    case 1: { port = "порт1"; break; }
                    case 2: { port = "порт2"; break; }
                    case 3: { port = "порт3"; break; }
                    case 4: { port = "порт4"; break; }
                    case 5: { port = "порт5"; break; }
                }
                
                name = "Корабль";
            }

            public Ship(double kk) 
            {
                k = kk;
                name = "Корабль";
            }

            override public double s() 
            {
                double s;
                s = 5 * Math.Pow(k,2);
                return s;
            }

            public override void Print(DataGridView dg) 
            {
                var = s();
                base.Print(dg);
                dg.Rows.Add("Количество пассажиров k", k.ToString());
                dg.Rows.Add("Порт приписки port", port.ToString());
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(textBox1.Text);
            // создаем контейнер ссылок на объекты базового класса
            Transport[] a = new Transport[n*3];
            for (int i = 0; i < 3 * n; i = i + 3)
            {
                a[i] = new Transport(); // создаем объект класса Transport
                a[i+1] = new Plane(); // создаем объект класса Plane
                a[i+2] = new Ship(); // создаем объект класса Ship
            }
            dg.Rows.Clear();
            // выводим поля объектов массива
            foreach (Transport el in a)
                el.Print(dg);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
