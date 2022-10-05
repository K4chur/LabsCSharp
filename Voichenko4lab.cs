using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://github.com/K4chur/LabsCSharp

namespace Lab4CS //1`st 
{
    public class Rectangle
    {
        protected int a { get; set; }
        protected int b { get; set; }
        protected string color { get; }

        public string this[int i]
        {
            get
            {
                if (i == 0) { 
                    string a1 = a.ToString();
                    return a1; }
                else if (i == 1) {
                    string b1 = b.ToString();
                    return b1; }
                else if (i == 2) { return color; }
                else { throw new Exception("something went wrong"); }
            }
        }

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

        public static Rectangle operator ++(Rectangle A)
        {
            A.a++;
            A.b++;
            return A;
        }

        public static Rectangle operator --(Rectangle A)
        {
            A.a--;
            A.b--;
            return A;
        }

        public static Rectangle operator *(Rectangle A,int B)
        {
            A.a = A.a * B;
            A.b = A.b * B;
            return A;
        }

        public static bool operator true(Rectangle A)
        {
            if(A.a == A.b)
            {
                return true;
            }
            return false;
        }
        public static bool operator false(Rectangle A)
        {
            if (A.a != A.b)
            {
                return false;
            }
            return true;
        }

        public static implicit operator Rectangle(string A)
        {
            string[] words = A.Split("\n\t ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(words[0]);
            int b = int.Parse(words[1]);
            string color = words[2];

            Rectangle B = new Rectangle(a,b,color);
            return B;
        }

        public static implicit operator string(Rectangle A)
        {
            return $"{A.a} {A.b} {A.color}";
        }
    }
}

namespace Lab4CS
{
    public class VectorShort
    {
        short[] ShortArray { get; set; }
        uint n { get; }
        uint codeError { get; set; }
        static uint num_v { get; set; }

        public short this[uint i]
        {
            get
            {
                if (i > n)
                {
                    codeError = 10;
                    return 0;
                }
                return ShortArray[i];
            }
            set
            {
                if (i > n)
                {
                    codeError = 10;
                }
                else
                {
                    ShortArray[i] = value;
                }
            }
        }

        public VectorShort()
        {
            n = 1;
            ShortArray = new short[n];
            ShortArray[0] = 0;
            num_v++;
        }

        public VectorShort(uint n_)
        {
            n = n_;
            ShortArray = new short[n];
            for (int i = 0; i < n; i++)
            {
                ShortArray[i] = 0;
            }
            num_v++;
        }

        public VectorShort(uint n_, short a)
        {
            n = n_;
            ShortArray = new short[n];
            for (int i = 0; i < n; i++)
            {
                ShortArray[i] = a;
            }
            num_v++;
        }

        ~VectorShort()
        {
            Console.WriteLine("Destructed///");
            num_v--;
        }

        public void Input()
        {
            for(int i = 0; i < this.n; i++)
            {
                Console.WriteLine($"Input A[{i}] = ");
                this.ShortArray[i] = short.Parse(Console.ReadLine());
            }
        }

        public void Output()
        {
            for (int i = 0; i < this.n; i++)
            {
                Console.WriteLine($"Array[{i}] = {this.ShortArray[i]}");
            }
        }

        public void SetVec(short A)
        {
            for (int i = 0; i < this.n; i++)
            {
                this.ShortArray[i] = A;
            }
        }

        public void SetVec(uint w,short A)
        {
            if (w < 0 || w > n) { Console.WriteLine("Error!"); }
            else
            {
                this.ShortArray[w] = A;
                
            } 
        }
        public static VectorShort operator ++(VectorShort A)
        {
            for (int i = 0; i < A.n; i++)
            {
                A.ShortArray[i]++;
            }

            return A;
        }

        public static VectorShort operator --(VectorShort A)
        {
            for (int i = 0; i < A.n; i++)
            {
                A.ShortArray[i]--;
            }

            return A;
        }

        public static VectorShort operator +(VectorShort A, short B)
        {
            for (int i = 0; i < A.n; i++)
            {
                A.ShortArray[i] += B;
            }

            return A;
        }

        public static VectorShort operator -(VectorShort A, short B)
        {
            for (int i = 0; i < A.n; i++)
            {
                A.ShortArray[i] -= B;
            }

            return A;
        }

        public static VectorShort operator *(VectorShort A, short B)
        {
            for (int i = 0; i < A.n; i++)
            {
                A.ShortArray[i] *= B;
            }

            return A;
        }
        public static VectorShort operator /(VectorShort A, short B)
        {
            for (int i = 0; i < A.n; i++)
            {
                A.ShortArray[i] /= B;
            }

            return A;
        }

        public static VectorShort operator %(VectorShort A, short B)
        {
            for (int i = 0; i < A.n; i++)
            {
                A.ShortArray[i] %= B;
            }

            return A;
        }
        public void ShowNum()
        {
            Console.WriteLine($"Number of vectors is {num_v}");
        }

    }
}

namespace Lab4CS
{
    internal class MatrixShort
    {
        short[,] ShortArrays { get; set; }
        uint n { get; set; }
        uint m { get; set; }
        uint codeError { get; set; }
        static uint num_m { get; set; }

        public short this[uint i, uint j]
        {
            get
            {
                if (i > n && j > n)
                {
                    codeError = 10;
                    return 0;
                }
                return ShortArrays[i,j];
            }
            set
            {
                if (i > n && j > n)
                {
                    codeError = 10;
                }
                else
                {
                    ShortArrays[i,j] = value;
                }
            }
        }

        public short this[uint index]
        {
            get
            {
                if (index < n * m - 1)
                {

                    return ShortArrays[index / m,(uint)(index % m)];
                }
                else
                {
                    codeError = 10;
                    return 0;
                }
            }
            set
            {
                if (index < n * m - 1)
                {
                    ShortArrays[index / m,(int)(index % m)] = value;
                }
                else
                {
                    codeError = 10;
                }
            }
        }

        public MatrixShort()
        {
            n = 1;
            m = 1;
            ShortArrays = new short[n,m];
            ShortArrays[0, 0] = 0;
            num_m++;
        }

        public MatrixShort(uint n_, uint m_)
        {
            n = n_;
            m = m_;
            ShortArrays = new short[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ShortArrays[i, j] = 0;
                }
            }
            num_m++;
        }

        public MatrixShort(uint n_, uint m_, short a)
        {
            n = n_;
            m = m_;
            ShortArrays = new short[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ShortArrays[i, j] = a;
                }
            }
            num_m++;
        }

        ~MatrixShort()
        {
            Console.WriteLine("Destructing///");
        }

        public void Input()
        {
            for (int i = 0; i < this.n; i++)
            {   for (int j = 0; j < this.m; j++)
                {
                    Console.WriteLine($"Input A[{i}][{j}] = ");
                    this.ShortArrays[i,j] = short.Parse(Console.ReadLine());
                }
            }
        }

        public void Output()
        {
            for (int i = 0; i < this.n; i++)
            {
                for (int j = 0; j < this.m; j++)
                {
                    Console.Write($"Array[{i}][{j}] = {this.ShortArrays[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        public void SetVec(short A)
        {
            for (int i = 0; i < this.n; i++)
            {   for(int j = 0; j < this.m; j++)
                {
                    this.ShortArrays[i,j] = A;
                }
            }
        }

        public void SetVec(uint n_, uint m_, short A)
        {
            if (n_ < 0 || n_ > n || m_ < 0 || m_ > m) { Console.WriteLine("Error!"); }
            else
            {
                this.ShortArrays[n_,m_] = A;

            }
        }
        public static MatrixShort operator ++(MatrixShort A)
        {
            for (int i = 0; i < A.n; i++)
            { for (int j = 0; j < A.m; j++)
                {
                    A.ShortArrays[i,j]++;
                }
            }

            return A;
        }

        public static MatrixShort operator --(MatrixShort A)
        {
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.m; j++)
                {
                    A.ShortArrays[i, j]--;
                }
            }

            return A;
        }

        public static MatrixShort operator +(MatrixShort A, short B)
        {
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.m; j++)
                {
                    A.ShortArrays[i, j]+= B;
                }
            }

            return A;
        }

        public static MatrixShort operator -(MatrixShort A, short B)
        {
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.m; j++)
                {
                    A.ShortArrays[i, j] -= B;
                }
            }

            return A;
        }

        public static MatrixShort operator *(MatrixShort A, short B)
        {
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.m; j++)
                {
                    A.ShortArrays[i, j] *= B;
                }
            }

            return A;
        }
        public static MatrixShort operator /(MatrixShort A, short B)
        {
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.m; j++)
                {
                    A.ShortArrays[i, j] /= B;
                }
            }

            return A;
        }

        public static MatrixShort operator %(MatrixShort A, short B)
        {
            for (int i = 0; i < A.n; i++)
            {
                for (int j = 0; j < A.m; j++)
                {
                    A.ShortArrays[i, j] %= B;
                }
            }

            return A;
        }
        public void ShowNum()
        {
            Console.WriteLine($"Number of vectors is {num_m}");
        }

    }
}

namespace Lab4CS
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
                        Console.Write("Input A side: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Input B side: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.Write("Input color of rectangle (string): ");
                        string color = Console.ReadLine();
                        Console.WriteLine();

                        Rectangle A = new Rectangle(a, b, color);
                        Console.WriteLine();

                        Console.Write("Input index: ");
                        int i = int.Parse(Console.ReadLine());

                        Console.WriteLine($"A[{i}] = {A[i]}");
                        
                        Console.WriteLine("Before++");
                        A.GetSides();
                        A++;
                        Console.WriteLine("After++");
                        A.GetSides();
                        A--;
                        Console.WriteLine("After--");
                        A.GetSides();
                        A = A * 3;
                        Console.WriteLine("After*3");
                        A.GetSides();

                        if (A)
                        {
                            Console.WriteLine("It IS square");
                        } else
                        {
                            Console.WriteLine("It is NOT square");
                        }

                        A = "4 5 green";
                        A.GetSides();
                    }
                    break;
                case 2:
                    Console.WriteLine("2.");
                    {

                        VectorShort A = new VectorShort();
                        A.Output();

                        Console.WriteLine();
                        Console.WriteLine("Input N for 2`nd: ");
                        uint n = uint.Parse(Console.ReadLine());
                        VectorShort B = new VectorShort(n);
                        B.Output();

                        Console.WriteLine();
                        Console.WriteLine("Input N for 3`d: ");
                        n = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Input Initiation for 3`d: ");
                        short a = short.Parse(Console.ReadLine());
                        VectorShort C = new VectorShort(n,a);
                        C.Output();

                        Console.WriteLine();
                        Console.WriteLine("Input Initiation for setter: ");
                        a = short.Parse(Console.ReadLine());
                        C.SetVec(a);
                        C.Output();

                        Console.WriteLine();
                        Console.WriteLine("Input Index for setter: ");
                        n = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Input Initiation for setter: ");
                        a = short.Parse(Console.ReadLine());
                        C.SetVec(n,a);
                        C.Output();

                        Console.WriteLine();
                        C.ShowNum();
                    }
                    break;
                case 3:
                    Console.WriteLine("3.");
                    {
                        MatrixShort A = new MatrixShort();
                        A.Output();

                        Console.WriteLine();
                        Console.WriteLine("Input N for 2`nd: ");
                        uint n = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Input M for 2`nd: ");
                        uint m = uint.Parse(Console.ReadLine());
                        MatrixShort B = new MatrixShort(n,m);
                        B.Output();

                        Console.WriteLine();
                        Console.WriteLine("Input N for 3`nd: ");
                        n = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Input M for 3`nd: ");
                        m = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Input Initiation for setter: ");
                        short a = short.Parse(Console.ReadLine());
                        MatrixShort C = new MatrixShort(n, m, a);
                        C.Output();

                        Console.WriteLine();
                        Console.WriteLine("Input Initiation for setter: ");
                        a = short.Parse(Console.ReadLine());
                        C.SetVec(a);
                        C.Output();

                        Console.WriteLine();
                        Console.WriteLine("Input N for setter: ");
                        n = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Input M for setter: ");
                        m = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Input Initiation for setter: ");
                        a = short.Parse(Console.ReadLine());
                        C.SetVec(n,m,a);
                        C.Output();

                        Console.WriteLine();
                        C.ShowNum();
                    }
                    break;
                default:
                    Console.WriteLine("Something went wrong!");
                    break;
            }
        }
    }
}


