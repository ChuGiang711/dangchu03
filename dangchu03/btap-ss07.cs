using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Linq;
using System.Buffers;
using System.ComponentModel.Design;

namespace dangchu03.ss07
{
    internal class btap_ss07
    {
        static int LinearSearch(int[] so, int ItemToSearch)
        {
            for (int index = 0; index < so.Length; index++)
                if (so[index] == ItemToSearch)
                    return index;
            return -1;
        }
        static void Main01()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] mang = new int[3] { 5, 8, 5 };
            Console.WriteLine("Mảng ban đầu là :" + string.Join(",", mang));
            // 1. Tính giá trị trung bình của mảng 

            Console.WriteLine("1.Trung bình cộng của mảng = " + mang.Average());


            //2.Kiểm tra xem mảng có chứa 1 giá trị cụ thể hay không 
            {
                Console.WriteLine();
                Console.WriteLine("2.Kiểm tra xem mảng có chứa 1 giá trị cụ thể hay không ");
                int[] so = { 5, 9, 3, 2, 7 };
                int cantim = 9;
                int ketqua = LinearSearch(so, cantim);
                if (ketqua != -1)
                {
                    Console.WriteLine($"Tìm thấy số {cantim} tại vị trí index {ketqua}");
                }
                else
                {
                    Console.WriteLine($"Không tìm thấy số {cantim}");
                }
            }
            static int LinearSearch(int[] arr, int target)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == target)
                    {
                        return i;
                    }
                }
                return -1;
            }


            //3.Tìm chỉ số index của 1 phần tử trong mảng 
            Console.WriteLine();
            Console.WriteLine("3.Tìm chỉ số index của 1 phần tử trong mảng ");
            Console.WriteLine("Vị trí index 0 : " + mang[0]);
            Console.WriteLine("Vị trí index 1 : " + mang[1]);
            Console.WriteLine("Vị trí index 2 : " + mang[mang.Length - 1]);

            //5.Tìm giá trị max , min 
            int[] mang5 = { 2, 3, 4, 5, 6, 7, 8, 12 };
            int max = mang5[0], min = mang5[0];
            for (int i = 1; i < mang5.Length; i++)
            {
                if (mang5[i] > max) max = mang5[i];
                if (mang5[i] < min) min = mang5[i];
            }
            Console.WriteLine();
            Console.WriteLine("5.Tìm giá trị max , min ");
            Console.WriteLine($"Mảng có các phần tử sau :" + string.Join(",", mang5));
            Console.WriteLine($" Max = {max}, Min = {min}");

            // 6. Đảo ngược mảng 
            Console.WriteLine();
            Console.WriteLine("6.Đảo ngược mảng");
            int[] mangsonguyen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Mảng số nguyên trước khi đảo ngược là : " + string.Join(", ", mangsonguyen));
            Console.Write("Mảng số nguyên sau khi đảo ngược là : ");

            Array.Reverse(mangsonguyen);
            foreach (int i in mangsonguyen)
            {
                Console.Write(i + "," + " ");
            }

            //7. Tìm các giá trị trùng lặp trong mảng 

            int[] mang7 = { 5, 9, 3, 2, 7, 9, 5, 5, 1, 3 };
            Console.WriteLine();
            Console.WriteLine("7. Tìm các giá trị trùng lặp trong mảng ");
            Console.WriteLine("Mảng ban đầu: " + string.Join(", ", mang7));
            Console.WriteLine("Các giá trị bị trùng lặp:");

            TimGiaTriTrungLap(mang7);

            Console.ReadLine();
        }
        static void TimGiaTriTrungLap(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool Daco = false;
                for (int k = 0; k < i; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        Daco = true;
                        break;
                    }
                }


                if (!Daco)
                {

                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            Console.WriteLine($"- Số {arr[i]} bị trùng");
                            break;
                        }
                    }
                }

            }
        }
    }
}


            
        
