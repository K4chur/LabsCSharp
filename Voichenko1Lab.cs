using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ЩОБ ОБРАТИ ВІДПОВІДНУ ПРОГРАМУ ЗМІНІТЬ У НАЗВІ main НА Main !

namespace Lab11
{
    internal class Program
    {
        static void main(string[] args) 
        {
            Console.Write("Input X1: ");
            int X1 = int.Parse(Console.ReadLine());

            Console.Write("Input Y1: ");
            int Y1 = int.Parse(Console.ReadLine());

            Console.Write("Input X2: ");
            int X2 = int.Parse(Console.ReadLine());

            Console.Write("Input Y2: ");
            int Y2 = int.Parse(Console.ReadLine());

            double D = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Distance between dots is: " + D);

            Console.ReadLine();
        }
    }
}

namespace Lab12
{
    internal class Program
    {
        static void main(string[] args)
        {
            Console.Write("Input X: ");
            int X = int.Parse(Console.ReadLine());

            if ( X%2 == 0)
            {
                Console.Write("Number is EVEN");
            }   
            else
            {
                Console.Write("Number is ODD");
            }

            Console.ReadLine();
        }
    }
}

namespace Lab13
{
    internal class Program
    {
        static void main(string[] args)
        {
            Console.Write("Input X: ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Input Y: ");
            int Y = int.Parse(Console.ReadLine());

            int R = 10;
            int r = 5;

            if (Y < 0) 
            {
                Console.Write("Dot OUT the area");
                Console.ReadLine();
                return;
            }
            else
            if (Math.Pow(X, 2) + Math.Pow(Y, 2) == Math.Pow(R, 2) || Math.Pow(X,2) + Math.Pow(Y,2) == Math.Pow(r,2))
            {
                Console.Write("Dot on the LINE");
            }

            if (Math.Pow(X, 2) + Math.Pow(Y, 2) < Math.Pow(R, 2) && Math.Pow(X, 2) + Math.Pow(Y, 2) > Math.Pow(r, 2))
            {
                Console.Write("Dot IN the area");
            }

            if (Math.Pow(X, 2) + Math.Pow(Y, 2) > Math.Pow(R, 2) || Math.Pow(X, 2) + Math.Pow(Y, 2) < Math.Pow(r, 2))
            {
                Console.Write("Dot OUT the area");
            }
            

            Console.ReadLine();
        }
    }
}

namespace Lab14
{
    internal class Program
    {
        static void main(string[] args)
        {
            int m = 0;
            while (m < 1 || m > 4)
            {
                Console.WriteLine("Input m in a range of 1-4: ");
                m = int.Parse(Console.ReadLine());
            }

            switch (m) {
                case 1: Console.Write("m is - Pika.");
                    break;
                case 2: Console.Write("m is - Trefi");
                    break;
                case 3: Console.Write("m is - Bubni");
                    break;
                case 4: Console.Write("m is - Chirva");
                    break;
                default: Console.Write("Something gone wrong"); 
                    break;
            }

            Console.ReadLine();
        }
    }
}

namespace Lab15
{
    internal class Program
    {
        static int dobutok(int a, int b)
        {
            return a * b;

        }
        static void main(string[] args)
        {
            Console.Write("Input X: ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Input Y: ");
            int Y = int.Parse(Console.ReadLine());
            
            int result = dobutok(X, Y);

            Console.WriteLine("Result is: " + result);
            Console.ReadLine();
        }
    }
}

namespace Lab16
{
    internal class Program
    {
        static void main(string[] args)
        {
            Console.Write("Input N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Input M: ");
            int M = int.Parse(Console.ReadLine());

            double result = 0;
            result = ((N + 1) / (Math.Pow(N, 2) + Math.Pow(M, 2) + 1)) - ((1) / ((M+1)*(N+1)));
            Console.WriteLine("Result is: " + result);

            Console.ReadLine();
        }
    }
}