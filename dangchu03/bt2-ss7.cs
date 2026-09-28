using System;
using System.Collections.Generic;
using System.Text;

namespace dangchu03.ss07
{
    internal class bt2_ss7
    {
        static void Main()
        {
            //Yêu cầu người dùng nhập 10 số nguyên và sắp xếp chúng bằng thuật toán sắp xếp bubble sort.
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Yêu cầu người dùng nhập 10 số nguyên và sắp xếp Bubble sort ");
            int[] so = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhập số thứ {i + 1}: ");
                so[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Mảng người dùng nhập 10 số nguyên: " + string.Join(", ", so));
            for (int i = 0; i < so.Length - 1; i++)
            {
                for (int j = 0; j < so.Length - 1 - i; j++)
                {
                    if (so[j] > so[j + 1])
                    {
                        int temp = so[j];
                        so[j] = so[j + 1];
                        so[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Mảng sau khi sắp xếp: " + string.Join(", ", so));



            //Yêu cầu người dùng nhập một câu, sau đó yêu cầu nhập một từ. Tìm kiếm xem từ đó có xuất hiện trong câu hay không bằng linear search
            static bool LinearSearch(string text, string word)
            {
                if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(word))
                    return false;
                string[] words = text.Split(new[] { ' ', '\t', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                for (int index = 0; index < words.Length; index++)
                {
                    if (string.Equals(words[index], word, StringComparison.CurrentCultureIgnoreCase))
                    {
                        return true;
                    }
                }
                return false;
            }
            Console.Write("Bạn hãy nhập một câu ! : ");
            string cau = Console.ReadLine();
            Console.WriteLine("Nhập từ cần tìm : ");
            string tu = Console.ReadLine();
            bool timthaytu = LinearSearch(cau, tu);
            {
                if (timthaytu)
                {
                    Console.WriteLine($"Từ {tu} có xuất hiện trong câu");
                }
                else
                {
                    Console.WriteLine($"Từ {tu} không xuất hiện trong câu");
                }
            }

        }
    }
}
