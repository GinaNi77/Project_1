using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draft_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double len;
        abstract class Figure
        {
            public double Length { get; set; }
            protected double Area;
            protected double Perimeter;
            public Figure(double len)
            {
                this.Length = len;
                Area = area();
                Perimeter = perimeter();
            }
         
            public abstract double area();
            public abstract double perimeter();
        }

        class Triangle : Figure
        {
            public Triangle(double len) : base(len) { }
            public override double area()
            {
                Area = Length * Length * Math.Sqrt(3) / 4;
                return Area;
            }
            public override double perimeter()
            {
                Perimeter = 3 * Length;
                return Perimeter;
            }
        }

        class Square : Figure
        {
            public Square(double len) : base(len) { }
            public override double area()
            {
                Area = Length * Length;
                return Area;
            }
            public override double perimeter()
            {
                Perimeter = 4 * Length;
                return Perimeter;
            }
        }

        class Circle : Figure
        {
            public Circle(double len) : base(len) { }
            public override double area()
            {
                Area = Math.PI * Length * Length;
                return Area;
            }
            public override double perimeter()
            {
                Perimeter = 2 * Math.PI * Length;
                return Perimeter;
            }
        }
        class Hexagon : Figure
        {
            public Hexagon(double len) : base(len) { }
            public override double area()
            {
                Area = (3 * Math.Sqrt(3)*Math.Pow(Length,2))/2;
                return Area;
            }
            public override double perimeter()
            {
                Perimeter = 6* Length;
                return Perimeter;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Характерный размер фигуры = ";
             len = Convert.ToDouble(textBox2.Text);

             if (a==1)
            {
                Triangle t = new Triangle(len);
                textBox1.Text = "Треугольник: периметр = " + Math.Round(t.perimeter(),3).ToString() + ", площадь = " + Math.Round(t.area(),3).ToString();
            }
             else if(a==2)
            {
                Square q = new Square(len);

                textBox1.Text = "Квадрат: периметр = " + Math.Round(q.perimeter(), 3).ToString() + ", площадь = " + Math.Round(q.area(), 3).ToString();

            }
            else if (a==3)
            {
                Circle c = new Circle(len);
                textBox1.Text = "Круг : периметр = " + Math.Round(c.perimeter(), 3).ToString() + ", площадь = " + Math.Round(c.area(), 3).ToString();

            }
            else
            {
                Hexagon h = new Hexagon(len);
                textBox1.Text = "Шестиугольник : периметр = " + Math.Round(h.perimeter(), 3).ToString() + ", площадь = " + Math.Round(h.area(), 3).ToString();
            }

        }
        int a;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Треугольник")
            {
                a = 1;  
            }
            if (listBox1.SelectedItem.ToString() == "Квадрат")
            {
                a = 2;
            }
            if (listBox1.SelectedItem.ToString() == "Окружность")
            {
                a = 3;
            }
            if (listBox1.SelectedItem.ToString() == "Шестиугольник ")
            {
                a = 4;
            }

        }
    }
}
