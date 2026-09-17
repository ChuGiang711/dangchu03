using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace dangchu03.ss04
{
    internal class bt
    {
        static void Main(string[] args)
        {
            //bt6();
            //bt7();
            //btgamexingau();
            btgame();
        }



        static void bt6()

        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào một số n : ");
            double n = double.Parse(Console.ReadLine());

            double tong = 0;
            Console.Write("Chuỗi Harmonic : ");
            for (int i = 1; i <= n; i++)
            {
                if (i < n)
                {
                    Console.Write($"i/{i} + ");
                }
                else
                {
                    Console.Write($"i/{i} ");

                }
                tong += 1.0 / i;

            }
            Console.WriteLine($"Tổng của chuỗi {n} là : {tong}");
        }

        static void bt7()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số bắt đầu : ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Nhập số kết thúc : ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($" Các số hoàn hảo trong khoảng từ {start} đến {end} là : ");

            for (int so = start; so <= end; so++)
            {
                if (so <= 1) continue;
                int tổng = 0;

                for (int i = 1; i <= so / 2; i++)
                {
                    if (so % i == 0)
                    {
                        tổng += i;
                    }
                }
                if (tổng == so)
                {
                    Console.Write(so + " ");
                }
            }
            Console.WriteLine();


        }
        static void btgamexingau()
        {
            Console.OutputEncoding = Encoding.UTF8;
            game();
        }

        public static void game()
        {
            long tienco = 1000000; 

            int solanchoi = 0; 
            int solanthua = 0;
            int solandacbiet = 0; 
            bool continueplaying = true;
            do
            {
                solanchoi++;
                Console.Write($"Bạn có {tienco} đồng. Bạn đặt bao nhiêu? ");
               
                long tiencuoc = 0;
                do
                {
                    bool ok = long.TryParse(Console.ReadLine(), out long kq);
                    if (ok && kq <= tienco && kq > 1000)
                    {
                        tiencuoc = kq;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Vui lòng nhập số tiền đặt cược hợp lệ !!" +
                            $"Tiền cược không được vượt quá số tiền hiện có {tienco}. Số tiền bạn nhập phải trên 1000 đồng");
                        Console.Write("Bạn đặt bao nhiêu? ");
                    }
                } while (true);

               
                Random rand = new Random();
                int xx1 = rand.Next(1, 7); 
                int xx2 = rand.Next(1, 7);
                int tong = xx1 + xx2;
                
                string guess;
                do
                {
                    Console.Write("Bạn đoán tài (T), xỉu (X) hay lục (L)? ");
                    guess = Console.ReadLine().ToLower();
                    if (guess != "t" && guess != "x" && guess != "l")
                    {
                        Console.WriteLine("Vui lòng nhập T, X hoặc L.");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

               
                bool thang = false; 
                bool dacbiet = false; 
                if (guess == "t" && tong > 6)
                {
                   thang = true;
                }
                else if (guess == "x" && tong < 6)
                {
                    thang = true;
                }
                else if (guess == "l" && tong == 6)
                {
                    thang = true;
                    dacbiet = true;
                }
                Console.WriteLine($"Kết quả gieo súc sắc là: {xx1} + {xx2} = {tong}");
                if (thang)
                {
                    if (dacbiet)
                    {
                        solandacbiet++;
                        tienco += tiencuoc * 3;
                        Console.WriteLine($"Bạn thắng đặc biệt! Tổng số tiền hiện tại là : {tienco} đồng.");
                    }
                    else
                    {
                        tienco += tiencuoc;
                        Console.WriteLine($"Bạn thắng ! Tổng số tiền hiện tại là : {tienco} đồng.");
                    }
                }
                else
                {
                    tienco -= tiencuoc;
                    solanthua++;
                    Console.WriteLine($" Bạn thua ! Tổng số tiền hiện tại là : {tienco} đồng.");
                }

                
                Console.Write("\nBạn có muốn chơi tiếp không ? (C / K): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "k")
                {
                    continueplaying = false;
                }
            } while (continueplaying);
           
            Console.WriteLine($"Trò chơi kết thúc!");
            Console.WriteLine($"Tổng số lần chơi: {solanchoi}");
            Console.WriteLine($"Tổng số lần thắng: {solanchoi - solanthua - solandacbiet}");
            Console.WriteLine($"Tổng số lần thua: {solanthua}");
            Console.WriteLine($"Tổng số lần thắng đặc biệt: {solandacbiet}");
        }

        void test(long tien)
        {
            
        }

        static void btgame()
        {
            Console.OutputEncoding = Encoding.UTF8;

            double tongtienco = 100000;
            Random random = new Random();

            while (tongtienco > 0)
            {
                Console.WriteLine($"Tổng số tiền bạn hiện có là {tongtienco} đồng .");
                Console.WriteLine(" Bạn có muốn chơi không ( C / K ) ? ");
                string luachon = Console.ReadLine().Trim().ToUpper();

                if ( luachon != "C")
                {
                    Console.WriteLine("... END GAME ...");break;
                }

                double tiencuoc = 0;
                while (true)
                {
                    Console.WriteLine("Nhập số tiền bạn muốn cược : ");
                    if (double.TryParse(Console.ReadLine(), out tiencuoc) && tiencuoc > 0 && tiencuoc <= tongtienco)
                    {
                        break;
                    }
                    Console.WriteLine("Số tiền bạn cược hiện không hợp lệ !");
                }

                int solanchoitoida = 0;
                double hesonhanthuong = 0;

                Console.WriteLine("Chọn cấp độ chơi ");
                Console.WriteLine(" 1 - Dễ : Bạn sẽ có 9 lần đoán và nếu thắng sẽ nhận 0.5 lần tiền cược ");
                Console.WriteLine(" 2 - Trung Bình : Bạn sẽ có 6 lần đoán và nếu thắng sẽ nhận 1 lần tiền cược ");
                Console.WriteLine(" 3 - Khó : Bạn sẽ có 4 lần đoán và nếu thắng sẽ nhận 3 lần tiền cược ");

                while (true)
                {
                    Console.Write("Nhập cấp độ bạn chọn ( 1 / 2/ 3) : ");
                    string capdo = Console.ReadLine();
                    {
                        if ( capdo == "1")
                        {
                            solanchoitoida = 9;
                            hesonhanthuong = 0.5;
                            break;
                        }
                        else if ( capdo == "2")
                        {
                            solanchoitoida = 6;
                            hesonhanthuong = 1;
                            break;
                        }
                        else if (capdo == "3")
                        {
                            solanchoitoida = 4;
                            hesonhanthuong = 3;
                            break;
                        }

                        Console.WriteLine("Lựa chọn không hợp lệ . Vui lòng chọn lại cấp độ !!");


                    }

                }

                int sodung = random.Next(1, 101);
                bool thang = false;

                Console.WriteLine($" Bạn có {solanchoitoida} lượt đoán!");

                for (int turn = 1; turn <= solanchoitoida; turn++)
                {
                    Console.Write($"Lượt {turn}/{solanchoitoida} - Nhập số bạn đoán: ");
                    if (int.TryParse(Console.ReadLine(), out int guess))
                    {
                        Console.WriteLine("Vui lòng nhập một số nguyên!");
                        turn--; 
                        continue;
                    }

                    if (guess == sodung)
                    {
                        thang = true;
                        break;
                    }
                    else if (guess != sodung)
                    {
                        Console.WriteLine(" Số bạn đoán chưa đúng .");
                    }
                   
                }

               
                if (thang)
                {
                    double Tienthang = hesonhanthuong * tiencuoc;
                    tongtienco += Tienthang;
                    Console.WriteLine($"\n[CHÚC MỪNG] Bạn đã đoán đúng số {sodung}!");
                    Console.WriteLine($"Số tiền hiện có là : {tongtienco} VNĐ");
                }
                else
                {
                    tongtienco -= tiencuoc;
                    Console.WriteLine($"\n[RẤT TIẾC] Bạn đã hết lượt đoán! Số đúng là: {sodung}");
                    Console.WriteLine($"Số tiền hiện có là : {tongtienco} VNĐ");
                }
            }

            if (tongtienco <= 0)
            {
                Console.WriteLine("\nBạn đã hết tiền! Trò chơi kết thúc.");
            }


        }

    }
}
