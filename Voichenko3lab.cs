using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://github.com/K4chur/LabsCSharp

namespace Lab3CS //1`st 
{
    public class Rectangle
    {
        protected int a { get; set; }
        protected int b { get; set; }
        protected string color { get; }

        public Rectangle(int a_, int b_, string color_)
        {
            if (a_ > 0)
            {
                a = a_;
            }
            if (b_ > 0)
            {
                b = b_;
            }
            color = color_;
        }

        public void GetSides()
        {
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
        }

        public void GetPerimeter()
        {
            int perimeter = (2 * a) + (2 * b);
            Console.WriteLine($"Perimeter equal: {perimeter}");
        }

        public void GetArea()
        {
            int area = a * b;
            Console.WriteLine($"Area equal: {area}");
        }

        public void IsSquare()
        {
            if (a == b)
            {
                Console.WriteLine("Rectangle is SQUARE");
            }
            if (a != b)
            {
                Console.WriteLine("Rectangle is NOT SQUARE");
            }
        }
    }
}

namespace Lab3CS//2`nd
{
    public class Kadr
    {
        protected string viddil { get; set;}

        public Kadr(string viddil)
        {
            this.viddil = viddil;
        }

        public void Show()
        {
            Console.WriteLine("Show Kadr:");
            Console.WriteLine($"Viddil: {viddil}");
        }
    }

    public class Robitnik : Kadr
    {
        protected string name { get; set; }
        protected string surname { get; set; }

        public Robitnik(string viddil,string name, string surname) : base(viddil)
        {
            this.viddil =viddil;
            this.name = name;
            this.surname = surname;
        }

        public void Show()
        {
            Console.WriteLine("Show Robitnik:");
            Console.WriteLine($"Viddil: {this.viddil}");
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Surname: {this.surname}");
        }
    }

    public class Ingener : Robitnik
    {
        protected int category { get; set; }

        public Ingener(string viddil, string name, string surname, int category) : base(viddil, name, surname)
        {
            this.category = category;
            this.viddil = viddil;
            this.name = name;
            this.surname = surname;
        }

        public void Show()
        {
            Console.WriteLine("Show Robitnik:");
            Console.WriteLine($"Viddil: {this.viddil}");
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Surname: {this.surname}");
            Console.WriteLine($"Category: {this.category}");
        }
    }
    
    public class Administration : Robitnik
    {
        protected string posada { get; set; }

        public Administration(string viddil, string name, string surname, string posada) : base(viddil, name, surname)
        {
            this.posada = posada;
            this.viddil = viddil;
            this.name = name;
            this.surname = surname;
        }

        public void Show()
        {
            Console.WriteLine("Show Robitnik:");
            Console.WriteLine($"Viddil: {this.viddil}");
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Surname: {this.surname}");
            Console.WriteLine($"Posada: {this.posada}");
        }
    }
}

namespace Lab3CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose = 0;
            do
            {
                Console.Write("Which excersice you want to test? (1 or 2): ");
                choose = int.Parse(Console.ReadLine());
            } while (choose != 1 && choose != 2);

            switch (choose)
            {
                case 1:
                    Console.WriteLine("1.");
                    {
                        Console.Write("Input A side: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Input B side: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.Write("Input color of rectangle (string): ");
                        string color = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Method of printing sides:");
                        Rectangle A = new Rectangle(a, b, color);
                        A.GetSides();
                        Console.WriteLine();

                        Console.WriteLine("Method of printing perimeter:");
                        A.GetPerimeter();
                        Console.WriteLine();

                        Console.WriteLine("Method of printing area:");
                        A.GetArea();
                        Console.WriteLine();

                        Console.WriteLine("Method of checking for a square:");
                        A.IsSquare();
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("2.");
                    {
                        Kadr kadr = new Kadr("Машинотехнiки");
                        kadr.Show();
                        Console.WriteLine();

                        Robitnik robitnik = new Robitnik("Танкобудування", "Юрiй", "Буруняк");
                        robitnik.Show();
                        Console.WriteLine();

                        Ingener ingener = new Ingener("Вiдновлювання", "Денис", "Юлiйович", 3);
                        ingener.Show();
                        Console.WriteLine();

                        Administration admin = new Administration("Перевiрки", "Юлiй", "Цезар", "Головнокомандувач");
                        admin.Show();
                        Console.WriteLine();
                    }
                    break;
                default: Console.WriteLine("Something went wrong!");
                    break;
            }
        }
    }
}


