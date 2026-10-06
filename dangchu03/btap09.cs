using System;
using System.Collections.Generic;
using System.Text;

namespace dangchu03.ss09
{
    internal class btap09
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //bt1();
            //bt2();
            //bt3();
            //bt4();
            //bt5();
            bt6();
            //bt7();
            //bt8();
            //bt9();
            //bt10();
            //bt11();

        }
        static void bt1()

        {
            Console.WriteLine("Nhập chuỗi bạn muốn : ");
            string str = Console.ReadLine();

            Console.WriteLine($"Chuỗi vừa nhập là : {str}");

        }
        static void bt2()
        {
            Console.Write("Nhập chuỗi bạn muốn : ");
            string str = Console.ReadLine();

            int length = 0;
            foreach (char c in str)
            {
                length++;
            }

            Console.WriteLine($"Độ dài của chuỗi là : {length}");
        }

        static void bt3()

        {
            Console.Write("Nhập chuỗi bạn muốn : ");
            string str = Console.ReadLine();

            Console.Write("Các ký tự trong chuỗi là  ");
            foreach (char kitu in str)
            {
                Console.Write(kitu + " ; ");
            }
            Console.WriteLine();
        }

        static void bt4()
        {
            Console.Write("Nhập chuỗi bạn muốn : ");
            string str = Console.ReadLine();

            
            int length = 0;
            foreach (char c in str) length++;

            Console.Write("Chuỗi đảo ngược là : ");
            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }

        static void bt5()
        {
            Console.Write("Nhập chuỗi bạn muốn : ");
            string str = Console.ReadLine();

            int sotu = 0;
            bool inword = false;

            foreach (char c in str)
            {
                if (c != ' ' && c != ' ' && c != ' ')
                {
                    if (!inword)
                    {
                        sotu++;
                        inword = true;
                    }
                }
                else
                {
                    inword = false;
                }
            }

            Console.WriteLine($"So tu trong chuoi: {sotu}");
        }

        static void bt7()
        {
            Console.Write("Nhập chuỗi bạn muốn : ");
            string str = Console.ReadLine();

            int chucai = 0, so = 0, kitudacbiet = 0;

            foreach (char c in str)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    chucai++;
                else if (c >= '0' && c <= '9')
                    so++;
                else
                    kitudacbiet++;
            }

            Console.WriteLine($"Số chữ cái: {chucai}");
            Console.WriteLine($"Số chữ số: {so}");
            Console.WriteLine($"Số kí tự đặc biệt: {kitudacbiet}");
        }


        static void bt8()
        {
            Console.Write("Nhập chuỗi bạn muốn : ");
            string str = Console.ReadLine();

            int nguyenam = 0, phuam = 0;

            foreach (char ch in str)
            {
               
                char c = char.ToLower(ch);

                if (c >= 'a' && c <= 'z')
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                        nguyenam++;
                    else
                       phuam++;
                }
            }

            Console.WriteLine($"Số nguyên âm: {nguyenam}");
            Console.WriteLine($"Số phụ âm: {phuam}");
        }

        static void bt11()
        {
            Console.Write("Nhập 1 ký tự : ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (c >= 'A' && c <= 'Z')
            {
                Console.WriteLine($"Chữ '{c}' là Chữ Hoa.");
            }
            else if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine($"Chữ '{c}' là Chữ Thường.");
            }
            else
            {
                Console.WriteLine($"'{c}'không là chữ cái .");
            }
        }

        static void bt6()
        {
            Console.Write("Nhập chuỗi thứ 1 : ");
            string str1 = Console.ReadLine();
            Console.Write("Nhập chuỗi thứ 2 :  ");
            string str2 = Console.ReadLine();

            
            int len1 = 0, len2 = 0;
            foreach (char c in str1) len1++;
            foreach (char c in str2) len2++;

            bool isEqual = true;

            if (len1 != len2)
            {
                isEqual = false;
            }
            else
            {
                for (int i = 0; i < len1; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        isEqual = false;
                        break;
                    }
                }
            }

            if (isEqual)
                Console.WriteLine("Hai chuỗi GIỐNG nhau ");
            else
                Console.WriteLine("Hai chuỗi KHÁC nhau.");

        }

    }
}
