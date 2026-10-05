
using System;
using System.Collections.Generic;
using System.Text;

namespace dangchu03.ss08
{
    internal class btap08
    {
        static void Main()
        {
            ///bt1();
            bt2();
        }
        static void bt1()
        {
            int[][] Mang = new int[4][];
            Mang[0] = new int[] { 1, 1, 1, 1, 1, 1 };
            Mang[1] = new int[] { 2, 2 };
            Mang[2] = new int[] { 3, 3, 3, 3 };
            Mang[3] = new int[] { 4, 4 };

            Console.WriteLine(" Cac phan tu trong mang rang cua : ");
            for (int i = 0; i < Mang.Length; i++)
            {
                for (int j = 0; j < Mang[i].Length; j++)
                {
                    Console.Write(Mang[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void bt2()
        {

            Console.Write("Nhap so hang cua mang: ");
            int rows = int.Parse(Console.ReadLine());

            int[][] Mang1 = new int[rows][];
            Random rand = new Random();

           
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Nhap so cot cho hang {i + 1}: ");
                int cot = int.Parse(Console.ReadLine());
                Mang1[i] = new int[cot];

                for (int j = 0; j < cot; j++)
                {
                    Mang1[i][j] = rand.Next(1, 100); 
                }
            }

            
            Console.WriteLine(" Mang 1 la :");
            PrintArray(Mang1);


            Giatrilonnhat(Mang1);

           
            SortEachRow(Mang1);
            Console.WriteLine("Mang sau khi sap xep tang dan tung hang");
            PrintArray(Mang1);

            
            insonguyentotrongmang(Mang1);

            Console.Write("Nhap so can tim kiem: ");
            int socantim = int.Parse(Console.ReadLine());
            Searchvalue(Mang1,socantim);


          
            static void PrintArray(int[][] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write(arr[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }

           
            static void Giatrilonnhat(int[][] arr)
            {
                Console.WriteLine("Gia tri lon nhat la : ");
                int Max = int.MinValue;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length == 0) continue;

                    int rowmax = arr[i][0];
                    for (int j = 1; j < arr[i].Length; j++)
                    {
                        if (arr[i][j] > rowmax)
                            rowmax = arr[i][j];
                    }

                    Console.WriteLine($"So lon nhat hang {i + 1} la: {rowmax}");

                    if (rowmax > Max)
                        Max = rowmax;
                }

                Console.WriteLine($" So lon nhat toan mang la: {Max}");
            }

            
            static void SortEachRow(int[][] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Array.Sort(arr[i]);
                }
            }

            
            static bool IsPrime(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }

            
            static void insonguyentotrongmang(int[][] arr)
            {
                Console.WriteLine("Cac so nguyen to trong mang la : ");
                bool hasprime = false;

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        if (IsPrime(arr[i][j]))
                        {
                            Console.WriteLine($"So {arr[i][j]} tai vi tri {i} va {j}");
                            hasprime = true;
                        }
                    }
                }

                if (!hasprime)
                    Console.WriteLine("Khong co so nguyen to nao trong mang.");
            }

            
            static void Searchvalue(int[][] arr, int value)
            {
                Console.WriteLine($" Vi tri cua {value} trong mang la : ");
                bool found = false;

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        if (arr[i][j] == value)
                        {
                            Console.WriteLine($"Hang {i + 1}, Cot {j + 1} ");
                            found = true;
                        }
                    }
                }

                if (!found)
                    Console.WriteLine($"Khong tim thay so {value} trong mang.");
            }
        }
    }
}
