using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace dangchu03.ss06
{
    internal class btap_ss06
    {
        /* Bài tập 1 
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int KetQua = TinhTong(6, 9);
            Console.WriteLine("Tồng Là : " + KetQua);
        }
        */





        /*Bài tập 2 
         static bool kiemtrasochan(int so)
        {
            if (so % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập một số cần kiểm tra có phải là số chẵn hay không : ");
            int so = int.Parse(Console.ReadLine());
            bool Ketqua = kiemtrasochan(so);
            if (Ketqua)
                Console.WriteLine($"Số bạn nhập là : {so} ; số  {so} Là số chẵn ");
            else 
                Console.WriteLine($"Số bạn nhập là : {so} ; số {so} Không là số chẵn ");
        }
        */







        /*Bài tập 3 
        static int TimMax(int a, int b, int c)
             {
            int so = a;
            if (b > so)
            {
                so = b;
            }
            if (c > so)
            {
                so = c;
            }
            return so;
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(" Nhập số cần kiểm tra thứ 1 : ");
            int sothunhat = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhập số cần kiểm tra thứ 2 : ");
            int sothuhai = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhập số cần kiểm tra thứ 3 : ");
            int sothuba = int.Parse(Console.ReadLine());

            int solonnhat = TimMax(sothunhat, sothuhai, sothuba);
            Console.WriteLine($" Số lớn nhất trong ba số {sothunhat} ; {sothuhai} ; {sothuba} là : {solonnhat} ");
        }
        */





        /* Bài tập số 4 
        static long Giaithua(int n)
        {
            long KetQua = 1;
            for (int i = 1; i <= n; i++)
            {
                KetQua *= i;
            }
            return KetQua;
        }


        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số mà bạn muốn tính giai thừa : ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine(" Số bạn nhập phải là số nguyên dương ! .");
            }
            else
            {
                long sonhap = Giaithua(n);
                Console.WriteLine($"{n}! = {sonhap}");
            }
        } */



        /*Bài Tập 06

        static bool KiemTraSoNguyenTo(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;

        }

        static void Main()
        { 
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(" Nhập số cần kiểm tra : ");
            int n = int.Parse(Console.ReadLine());
            bool Ketqua = KiemTraSoNguyenTo(n);
            if (Ketqua)
            {
                Console.WriteLine($"Số {n} Là số nguyên tố .");
            }
            else
            {
                Console.WriteLine($"Số {n} Là số nguyên tố .");
            }

        }*/



        /* Bài tập 07
        static void InFibonacci(int n)
        {
            if (n <= 0) return;

            long f0 = 0, f1 = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(f0 + " ");

                long fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());

            InFibonacci(n);
        } */




        /* Bài tập 09

        static double TinhLuyThua(double x, int y)
        {
            double KQ = 1.0;
            int luythua = y < 0 ? -y : y;

            for (int i = 0; i < luythua; i++)
            {
                KQ *= x;
            }

            if (y < 0)
            {
                return 1.0 / KQ;
            }

            return KQ;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập cơ số x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhập số mũ y: ");
            int y = int.Parse(Console.ReadLine());

            double KQua = TinhLuyThua(x, y);
            Console.WriteLine($"{x} lũy thừa {y} = {KQua}");
        } */




        /* Bài tập 12 
        static double chuyendo(double x)
        {
            return (x * 9.0 / 5.0) + 32;
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập độ C : ");
            double x = double.Parse(Console.ReadLine());

            double f = chuyendo(x);
            Console.WriteLine($"{x} độ C = {f} độ F ");
        } */




        /*Bài 13
        static int TimMin(int[] arr)
        {
            
              

            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = {2,3,4 };

            int kq = TimMin(arr);
            Console.WriteLine($"Số Min là : {kq}");
        }*/

    }
}


