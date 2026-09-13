namespace dangchu03
{
    internal class ex()
    {


        static void Main001()
        {
            //ex01();
            //ex02();
            //ex03();
            // ex04();


        }
        static void ex01()
        {
            Console.Write("Nhap so thu nhat : ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap phep toan ( +,-,*,/) : ");
            char pt = Convert.ToChar(Console.ReadLine());
            Console.Write("Nhap so thu hai : ");
            double s2 = Convert.ToDouble(Console.ReadLine());
            if (pt == '+')
            {
                Console.WriteLine($"{s1} + {s2} = {s1 + s2}");
            }
            else if (pt == '-')
            {
                Console.WriteLine($"{s1} - {s2} = {s1 - s2}");
            }
            else if (pt == '*')
            {
                Console.WriteLine($"{s1} * {s2} = {s1 * s2}");
            }

            else if (pt == '/')
            {
                if (s2 != 0)
                {
                    Console.WriteLine($"{s1} / {s2} = {s1 / s2}");
                }
                else
                {
                    Console.WriteLine("Khong the chia cho 0");
                }
            }
        }
        static void ex02()
        {
            Console.WriteLine("x=y^2 +2y + 1");
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y ={y} ;x = {x}");
            }
        }
        static void ex03()
        {
            Console.Write("Quang duong (km/h) : ");
            double qd = double.Parse(Console.ReadLine());

            Console.Write("Gio : ");
            int h = int.Parse(Console.ReadLine());

            Console.Write("Phut : ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Giay : ");
            int s = int.Parse(Console.ReadLine());
            double thoigian = h + p / 60.0 + s / 3600.0;
            double km = qd / s;
            double mile = km * 0.621371;
            Console.WriteLine("Van toc : " + km + "km/h");
            Console.WriteLine("Van toc : " + mile + "miles");
        }
        static void ex04()
        {
            Console.Write("Ban kinh cua hinh tron (r) : ");
            double r = double.Parse(Console.ReadLine());
            double dientichhinhtron = Math.PI * Math.Pow(r, 2);
            double thetichhinhtron = 4 / 3 * Math.Pow(r, 3) * Math.PI;
            Console.WriteLine("Dien tich hinh tron : " + dientichhinhtron);
            Console.WriteLine("The tich hinh tron : " + thetichhinhtron);

        }
    }
}