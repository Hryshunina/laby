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
        abstract class Transport // Абстрактный класс Транспортное средство
        {
            public string name; // название
            public double var;  // стоимость
            public abstract void Print(DataGridView dg); 
            public abstract double s();
        }

        class Plane : Transport // Класс Самолет наследует класс Транспортное средство 
        {
            private double h, v; // высота  - h, скорость - v

            public Plane(int xn, int xk) // конструктор з параметрами 
            {
                Random rnd = new Random();
                h = rnd.Next(xn, xk);
                v = rnd.Next(xn + 5, xk + 10);
                name = "Самолет";
            }

            public Plane(double hh, double vv) // конструктор з параметрами
            {
                h = hh;
                v = vv;
                name = "Самолет";
            }

            public override double s() // переопределение метода
            {
                double s;
                s = 100 * h * v;
                return s;
            }

            public override void Print(DataGridView dg) // переопределение метода
            {
                var = s();
                dg.Rows.Add("Название name", name);
                dg.Rows[dg.Rows.Count-2].DefaultCellStyle.ForeColor = Color.Red;
                dg.Rows.Add("Высота h", h.ToString());
                dg.Rows.Add("Скорость v", v.ToString());
                dg.Rows.Add("Стоимость var", var.ToString());
            }
        }

        class Ship : Transport // класс Корабль наследует класс Транспортное средство
        {
            private double k;
            private string port;
            public Ship(int xn, int xk)
            {
                Random rnd = new Random();

                k = rnd.Next(xn + 5, xk + 10);

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
                s = 5 * Math.Pow(k, 2);
                return s;
            }

            public override void Print(DataGridView dg)
            {
                var = s();
                dg.Rows.Add("Название name", name);
                dg.Rows[dg.Rows.Count - 2].DefaultCellStyle.ForeColor = Color.Green ;
                dg.Rows.Add("Количество пассажиров k", k.ToString());
                dg.Rows.Add("Порт приписки port", port.ToString());

                dg.Rows.Add("Стоимость var", var.ToString());


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(textBox1.Text);
            
            // создаем контейнер ссылок на объекты базового класса

            Transport[] a = new Transport[n * 2];
            double sum1 = 0;
            double sum2 = 0;
            double srs = 0;
            double srk = 0;


            for (int i = 0; i < 2 * n; i = i + 2)
            {
                a[i] = new Plane(i, i + 15); // объект класса Plane
                a[i + 1] = new Ship(i + 2, i + 25); // объект класса Ship
            }
            dg.Rows.Clear();
            // выводим поля объектовмассива
            foreach (Transport el in a)
            {
                el.Print(dg);
                if (el.name == "Самолет")
                {
                    sum1 += el.var;
                }

                if (el.name == "Корабль")
                {
                    sum2 += el.var;
                }

                srs = sum1 / n;
                srk = sum2 / n;

            }
            label1.Text = "Средняя стоимость: Самолетов - " + srs.ToString() + ", Кораблей - " + srk.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
