using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://github.com/K4chur/LabsCSharp

namespace Lab2
{
    internal class Program
    {
        static void main1()
        {
            int d = 0;
            while( d > 2 || d < 1 )
            {
                Console.Write("Input 1 or 2 for dimensions of array: ");
                d = int.Parse(Console.ReadLine());
            }

            switch (d)
            {
                case 1:
                    {
                        Console.Write("Input size of an array: ");
                        int n = int.Parse(Console.ReadLine());
                        int[] a = new int[n];

                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Input A[{0}]: ", i);
                            a[i] = int.Parse(Console.ReadLine());
                        }

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("A[{0}]: {1}", i, a[i]);
                        }

                        for (int i = 0; i < n; i++)
                        {
                            if (a[i] < 0 && a[i] % 2 != 0)
                            {
                                a[i] = Math.Abs(a[i]);
                            }
                        }

                        Console.WriteLine();

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("A[{0}]: {1}", i, a[i]);
                        }
                    }

                    break;
                
                case 2:
                    {
                        Console.Write("Input 1`st size of an array: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.Write("Input 2`nd size of an array: ");
                        int m = int.Parse(Console.ReadLine());

                        int[,] a = new int[n,m];

                        for (int i = 0; i < n; i++)
                        {   for(int j = 0; j < m; j++)
                            {
                                Console.Write("Input A[{0},{1}]: ", i, j);
                                a[i,j] = int.Parse(Console.ReadLine());
                            }
                        }

                        for (int i = 0; i < n; i++)
                        {   for (int j = 0; j < m; j++)
                            {
                                Console.Write("A[{0},{1}]: {2}   ", i, j, a[i,j]);
                            }
                            Console.WriteLine();
                        }

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                if (a[i,j] < 0 && a[i,j] % 2 != 0)
                                {
                                    a[i,j] = Math.Abs(a[i,j]);
                                }
                            }
                        }

                        Console.WriteLine();

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write("A[{0},{1}]: {2}   ", i, j, a[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                
                default: Console.WriteLine("Something gone wrong");
                    break;
            }
        }


        static void main2()
        {
            Console.Write("Input size of an array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Input A[{0}]: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("A[{0}]: {1}", i, a[i]);
            }


            int tempmin = a[0];
            for (int i = 0; i < n; i++)
            {
                if (tempmin > a[i])
                {
                    tempmin = a[i];
                }
            }

            for(int i = 0; i < n; i++)
            {
                if (a[i] == tempmin)
                {
                    a[i] = a[i] * (-1);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("A[{0}]: {1}", i, a[i]);
            }
        }
    
        static void main3()
        {
            Console.Write("Input size of an array: ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Input A[{0},{1}]: ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("A[{0},{1}]: {2}   ", i, j, a[i, j]);
                }
                Console.WriteLine();
            }

            
            int x = n-1;
            int sum = 0;
            int count = 0;
            
            for (int i = 0; i < n && x > -1; i++, x--){
                for (int j = 0; j < x+1; j++)
                {
                    if (a[i, j] != 0)
                    {
                        sum += a[i, j];
                        count++;
                    }
                }
                
            }

            double result = sum / count;
            Console.WriteLine("Result is: " + result);
            Console.ReadLine();
        }

        static void main4()
        {
            Console.Write("Input size of an array: ");
            int n = int.Parse(Console.ReadLine());
            int[][] myArr = new int[n][];
            
            for(int i = 0; i < n; i++)
                for(int j = 0; j < i+1; j++)
                {
                    {
                        myArr[j] = new int[j+1];
                    }
                }
            for(int i = 0; i < n; i++)
                for (int j = 0; j < i+1; j++)
                {
                    {
                        Console.WriteLine("A[{0},{1}]: ",i,j);
                        myArr[i][j] = int.Parse(Console.ReadLine());
                    }
                }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write("A[{0},{1}]: {2}  ", i, j, myArr[i][j]);               
                    }
                    Console.WriteLine();
                }

            int[] sum = new int[n];
            for (int i = 0; i < n; i++)
            {
                sum[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    if (myArr[i][j] < 0)
                    {
                        sum[j] += myArr[i][j];
                    } 
                }
                
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("S[{0}]= {1}   ", i, sum[i]);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.");
            main1();
            Console.WriteLine("2.");
            main2();
            Console.WriteLine("3.");
            main3();
            Console.WriteLine("4.");
            main4();
        }
    }
}

