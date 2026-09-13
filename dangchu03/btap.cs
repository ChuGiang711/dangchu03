using System.Runtime;

public class Class1
{


    static void Main(string[] args)
    {
            //bt1();
            //bt2();
            //bt3();
            //bt4();
            //bt5();
            //bt6();
            // bt7();
            //bt8();
            //bt9();
            //bt10();
           
    }

    static void bt1()
    {
        Console.Write("Nhap so tuoi cua ban : ");
        int tuoi = int.Parse(Console.ReadLine());
        Console.Write("Gio chieu phim : ");
        int gio = int.Parse(Console.ReadLine());
        if (tuoi > 60 || tuoi < 12)
        {
            Console.WriteLine("Gia ve cua ban la : 50.000VND");
        }
        else if (gio < 17)
        {
            Console.WriteLine("Gia ve cua ban la : 80.000VND");
        }
        else if (gio >= 17)
        {
            Console.WriteLine("Gia ve cua ban la : 110.000VND");
        }

    }
    static void bt2()
    {
        Console.Write("Nhap vai tro nguoi dung : ");
        string vaitro = Console.ReadLine();
        switch (vaitro)
        {
            case "ADMIN": Console.WriteLine("Toan quyen he thong."); break;
            case "MANAGER": Console.WriteLine("Quyen quan ly nhan su va xem bao cao."); break;
            case "EMPLOYEE": Console.WriteLine("Quyen tao va chinh sua ho so ca nhan."); break;
            case "GUEST": Console.WriteLine("Chi co quyen xem thong tin cong khai."); break;
            default:
                Console.WriteLine("Ma vai tro khong hop le"); break;
        }
    }

    static void bt3()
    {
        Console.Write("Nhap so du tai khoan : ");
        double sodu = double.Parse(Console.ReadLine());
        Console.Write("Nhap so tien can rut : ");
        double sotienrut = double.Parse(Console.ReadLine());
        if (sotienrut <= 0)
        {
            Console.WriteLine("So tien rut khong duoc nho hon hoac bang 0 ");
        }
        else if (sotienrut % 50000 != 0)
        {
            Console.WriteLine("So tien rut phai la boi so cua 50000 ");
        }
        else if (sotienrut > sodu)
        {
            Console.WriteLine("So du hien tai khong du de rut tien");
        }
        else if (sotienrut > 5000000)
        {
            Console.WriteLine("So tien rut khong duoc vuot qua 5000000 / lan rut ");
        }
        else
        {
            Console.WriteLine("Giao dich thanh cong .So du con lai : " + (sodu - sotienrut) + "VND");
        }

    }
    static void bt4()
    {
        Console.Write("Khách hàng bấm phím từ 0 đến 4 : ");
        string sophim = Console.ReadLine();
        switch (sophim)
        {
            case "0": Console.WriteLine("[Tổng Đài] : Yêu cầu Quay lại menu chính đã được ghi nhận.."); break;
            case "1": Console.WriteLine("[Tổng Đài] : Yêu cầu Gặp tổng đài viên tư vấn thẻ đã được ghi nhận.."); break;
            case "2": Console.WriteLine("[Tổng Đài] : Yêu cầu Tra cứu số dư tài khoản đã được ghi nhận.."); break;
            case "3": Console.WriteLine("[Tổng Đài] : Yêu cầu khóa thẻ khẩn cấp đã được ghi nhận.."); break;
            case "4": Console.WriteLine("[Tổng Đài] : Yêu cầu Tra cứu tỷ giá ngoại tệ đã được ghi nhận.."); break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ .Vui lòng thử lại!"); break;
        }
    }
    static void bt5()
    {
            Console.Write("Nhap quang duong di chuyen (km) : ");
            double km = double.Parse(Console.ReadLine());

            double Tongtientruocgiam = 0;
        if (km <= 1)
        {
            Tongtientruocgiam = 15000;
        }
        else if (km <= 10)
        {
            Tongtientruocgiam = 15000 + (km - 1) * 12000;
        }
        else
            {
           Tongtientruocgiam = 15000 + 9 * 12000 + (km - 10) * 10000;
            }

        double KhuyenMai = 0;
        if (km > 30)
        {
            KhuyenMai = - Tongtientruocgiam * 0.1;
        }

        double ThanhTien = Tongtientruocgiam - KhuyenMai;
        Console.WriteLine($"Tong tien truoc giam gia :{Tongtientruocgiam} VND");
        Console.WriteLine($"Khuyen mai (10%) :{KhuyenMai} VND");
        Console.WriteLine($"ThanhTien :{ThanhTien} VND");

    }
    static void bt6()
    {
        Console.Write("Trang thai : ");
        string trangthai = Console.ReadLine();
        switch (trangthai)
        {
            case "1" : Console.WriteLine("[Trang thai] : Cho xac nhan thanh toan.");break;
            case "2" : Console.WriteLine("[Trang thai] : Dang dong goi va ban giao don vi van chuyen.");break;
            case "3" : Console.WriteLine("[Trang thai] : Don hang dang tren duong giao den ban.");break;
            case "4" : Console.WriteLine("[Trang thai] : Don hang da hoan thanh . Cam on ban!");break;
            case "5" : Console.WriteLine("[Trang thai] : Don hang da huy.Xuat phieu hoan tien.");break;

            default: Console.WriteLine("Trang thai don hang khong hop le .");break;

        }

        
    }
    static void bt7()
        /* Nhập chiều cao (m) và cân nặng (kg). 
         Tính BMI = Cân nặng / (Chiều cao ^ 2).
         BMI < 18.5: "Thầy gầy - Nên bổ sung dinh dưỡng." 
         18.5 <= BMI < 25: "Cân đối - Tiếp tục duy trì."
         25 <= BMI < 30: "Thừa cân - Nên tăng cường luyện tập."
         BMI >= 30: "Béo phì - Cần sự tư vấn từ bác sĩ." */

    {
        Console.Write("Nhap chieu cao cua ban (m) : ");
        double m = double.Parse(Console.ReadLine());

        Console.Write("Nhap can năng cua ban (kg) : ");
        double kg = double.Parse(Console.ReadLine());

        double BMI = kg / Math.Pow(m, 2);
        if (BMI < 18.5)
        {
            Console.WriteLine($"BMI : {BMI} - Danh gia : Thay gay - Nen bo sung dinh duong");
        }
        else if (BMI >= 18.5 && BMI < 25)
        {
            Console.WriteLine($"BMI : {BMI} - Danh gia : Can doi - Tiep tuc duy tri");
        }
        else if (BMI >= 25 && BMI < 30)
        {
            Console.WriteLine($"BMI : {BMI} - Danh gia : Thua can - Nen tang cuong luyen tap");
        }
        else if (BMI > 30)
        {
            Console.WriteLine($"BMI : {BMI} - Danh gia : Beo phi - Can su tu van tu bac si");
        }
       
    }
    static void bt8()
    {
        Console.Write("Nhap loai xe :");
        string loaixe = Console.ReadLine();

        Console.Write("Thoi gian ( 1 - Ngay; 2 - Dem) :");
        string thoigian = Console.ReadLine();

        if (loaixe == "CAR")
        {
            if (thoigian == "2")
            {
                Console.WriteLine(" Phi gui xe CAR - Ban dem : 60.000 VND");
            }
            else if (thoigian == "1")
            {
                Console.WriteLine("Phi gui xe CAR - Ban ngay : 30.000 VND");
            }
        }
            
        if (loaixe == "BIKE")
        {
            if (thoigian == "2")
            {
                Console.WriteLine("Phi gui xe BIKE - Ban dem: 10.000 VND");
            }
            else
            {
                Console.WriteLine("Phi gui xe BIKE - Ban ngay : 5.000 VND");
            }
        }
    }


    static void bt9()
    {
        Console.Write("Nhap diem trung binh tich luy : ");
        double GPA = double.Parse(Console.ReadLine());

        Console.Write("Nhap diem ren luyen : ");
        double DRL = double.Parse(Console.ReadLine());

        if (GPA >= 3.6 && DRL >= 90)
        {
            Console.WriteLine("Ket Qua : Hoc Bong Xuat Sac - 100%");
        }
        else if ( GPA >= 3.2 && DRL >= 80 )
        {
            Console.WriteLine("Ket Qua : Hoc Bong Kha / Gioi - 50% ( DRL < 90 )");
        }
        else 
        {
            Console.WriteLine("Ket Qua : Khong duoc hoc bong");
        }
        

    } 
    static void bt10()
    {
        Console.Write("Nhap so tien VND : ");
        double VND = double.Parse(Console.ReadLine());

        Console.Write("Nhap ma ngoai te ( 'USD' , 'EUR' , 'JPY' ) : ");
        string Ma = Console.ReadLine();

        switch ( Ma )
        {
            case "USD": Console.WriteLine("So tien sau quy doi : " + (VND / 25400)  +  "USD"); break;
            case "EUR": Console.WriteLine("So tien sau quy doi : " + (VND / 27200)  +  "EUR"); break;
            case "JPY": Console.WriteLine("So tien sau quy doi : " + (VND / 165)  +  "JPY"); break;
            default: Console.WriteLine(" Ma ngoai te khong hop le . Vui long nhap ma ngoai te hop le ! "); break;
        }            

    }
    
}