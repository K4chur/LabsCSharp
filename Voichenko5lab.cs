using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://github.com/K4chur/LabsCSharp

namespace Lab5CS//1`st
{
    public class Kadr
    {
        protected string viddil { get; set; }

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

        public Robitnik(string viddil, string name, string surname) : base(viddil)
        {
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

namespace Lab5CS//2`nd
{
    public class Kadr2
    {
        protected string viddil { get; set; }
        ~Kadr2()
        {
            Console.WriteLine("Destruction///");
        }
        public Kadr2(string viddil)
        {
            this.viddil = viddil;
        }

        public Kadr2()
        {
            this.viddil = "none";
        }

        public Kadr2(int a)
        {
            this.viddil = a.ToString();
        }

        public void Show()
        {
            Console.WriteLine("Show Kadr:");
            Console.WriteLine($"Viddil: {viddil}");
        }
    }

    public class Robitnik2 : Kadr2
    {
        protected string name { get; set; }
        protected string surname { get; set; }
        ~Robitnik2()
        {
            Console.WriteLine("Destruction///");
        }
        public Robitnik2(string viddil, string name, string surname) : base(viddil)
        {
            this.viddil = viddil;
            this.name = name;
            this.surname = surname;
        }

        public Robitnik2(string viddil) : base(viddil)
        {
            this.viddil = viddil;
            this.name = "none";
            this.name = "none";
        }

        public Robitnik2(string name, string surname)
        {
            this.viddil = "none";
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

    public class Ingener2 : Robitnik2
    {
        protected int category { get; set; }
        ~Ingener2()
        {
            Console.WriteLine("Destruction///");
        }
        public Ingener2(string viddil, string name, string surname, int category) : base(viddil, name, surname)
        {
            this.category = category;
            this.viddil = viddil;
            this.name = name;
            this.surname = surname;
        }

        public Ingener2(string viddil): base(viddil)
        {
            this.viddil = viddil;
            this.category = -1;
            this.name = "none";
            this.surname = "none";
        }

        public Ingener2(string name, string surname) : base(name, surname)
        {
            this.viddil = "none";
            this.name = name;
            this.surname = surname;
            this.category = -1;
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

    public class Administration2 : Robitnik2
    {
        protected string posada { get; set; }

        ~Administration2()
        {
            Console.WriteLine("Destruction///");
        }
        public Administration2(string viddil, string name, string surname, string posada) : base(viddil, name, surname)
        {
            this.posada = posada;
            this.viddil = viddil;
            this.name = name;
            this.surname = surname;
        }
        public Administration2(string viddil) : base(viddil)
        {
            this.viddil = viddil;
            this.posada = "none";
            this.name = "none";
            this.surname = "none";
        }

        public Administration2(string name, string surname) : base(name, surname)
        {
            this.viddil = "none";
            this.name = name;
            this.surname = surname;
            this.posada = "none";
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

namespace Lab5CS
{
    abstract class Edition
    {
        public string NameOfPublication;
        public string LastNameOfAuthor;
        public Edition(string nameofpublic, string lastname)
        {
            NameOfPublication = nameofpublic;
            LastNameOfAuthor = lastname;
        }
        public abstract void GetInformation();
    }
    class Book : Edition
    {
        public string YearOfPublication;
        public string NameOfEdition;
        public Book(string nameofpublic, string lastname, string yearofpublic, string nameofedition) : base(nameofpublic, lastname)
        {
            YearOfPublication = yearofpublic;
            NameOfEdition = nameofedition;
        }
        public override void GetInformation()
        {
            Console.WriteLine("Information : {0},{1},{2},{3}", NameOfPublication, LastNameOfAuthor, YearOfPublication, NameOfEdition);
        }
    }
    class Article : Edition
    {
        public string NameOfMagazine;
        public int Number;
        public string YearOfPublicat;
        public Article(string nameofpublic, string lastname, string yearofpublic, string nameofmagazine, int number) : base(nameofpublic, lastname)
        {
            NameOfMagazine = nameofmagazine;
            Number = number;
            YearOfPublicat = yearofpublic;
        }
        public override void GetInformation()
        {
            Console.WriteLine("Information:{0},{1},{2},{3},{4}", NameOfPublication, LastNameOfAuthor, NameOfMagazine, Number, YearOfPublicat);
        }
    }
    class InterntEdition : Edition
    {
        public string Link;
        public string Annotation;
        public InterntEdition(string nameofpublic, string lastname, string link, string annotation) : base(nameofpublic, lastname)
        {
            Link = link;
            Annotation = annotation;
        }
        public override void GetInformation()
        {
            Console.WriteLine("Information:{0},{1},{2},{3}", NameOfPublication, LastNameOfAuthor, Link, Annotation);
        }
    }
    class Catalog
    {
        public List<Edition> list = new List<Edition>();
        public void AddEdition(Edition edit)
        {
            list.Add(edit);
        }
        public void FindEdition(string lastname)
        {
            foreach (var p in list.FindAll(p => p.LastNameOfAuthor == lastname))
                p.GetInformation();
        }
    }
}

namespace Lab5CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose = 0;
            do
            {
                Console.Write("Which excersice you want to test? (1 or 2 or 3): ");
                choose = int.Parse(Console.ReadLine());
            } while (choose != 1 && choose != 2 && choose != 3);

            switch (choose)
            {
                case 1:
                    Console.WriteLine("1.");
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
                case 2:
                    Console.WriteLine("2.");
                    {   
                        Kadr2 kadr1 = new Kadr2("Машинотехнiки");
                        kadr1.Show();
                        Console.WriteLine();
                        Kadr2 kadr2 = new Kadr2();
                        kadr2.Show();
                        Console.WriteLine();
                        Kadr2 kadr3 = new Kadr2(131);
                        kadr3.Show();
                        Console.WriteLine();

                        Robitnik2 robitnik1 = new Robitnik2("Танкобудування", "Юрiй", "Буруняк");
                        robitnik1.Show();
                        Console.WriteLine();
                        Robitnik2 robitnik2 = new Robitnik2("Машинобудування");
                        robitnik2.Show();
                        Console.WriteLine();
                        Robitnik2 robitnik3 = new Robitnik2("Петро","Моставчук");
                        robitnik3.Show();
                        Console.WriteLine();

                        Ingener2 ingener1 = new Ingener2("Вiдновлювання", "Денис", "Юлiйович", 3);
                        ingener1.Show();
                        Console.WriteLine();
                        Ingener2 ingener2 = new Ingener2("Будування");
                        ingener2.Show();
                        Console.WriteLine();
                        Ingener2 ingener3 = new Ingener2("Олег","Папироса");
                        ingener3.Show();
                        Console.WriteLine();

                        Administration2 admin1 = new Administration2("Перевiрки", "Юлiй", "Цезар", "Головнокомандувач");
                        admin1.Show();
                        Console.WriteLine();
                        Administration2 admin2 = new Administration2("Постування");
                        admin2.Show();
                        Console.WriteLine();
                        Administration2 admin3 = new Administration2("Денис","Буруря");
                        admin3.Show();
                        Console.WriteLine();

                    }
                    break;
                case 3:
                    Console.WriteLine("3.");
                    {
                        Catalog c = new Catalog();
                        c.AddEdition(new Book("Book", "Test", "2005", "Star"));
                        c.AddEdition(new Article("Article", "Test", "2012", "Super", 12));
                        c.AddEdition(new InterntEdition("Internet", "Test", "http", "Annotation"));
                        foreach (var p in c.list)
                        {
                            p.GetInformation();
                        }
                        c.FindEdition("Test");
                        Console.ReadLine();
                    }
                    break;
                default:
                    Console.WriteLine("Something went wrong!");
                    break;
            }
        }
    }
}


