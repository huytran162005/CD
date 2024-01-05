using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd
{
    class Program
    {
        static void menu()
        {
            QuanLyCD quanlyCD = new QuanLyCD();
            int chon = 0;
            do
            {
                Console.WriteLine("-------Chuong Trinh Quan Ly CD--------");
                Console.WriteLine("1. Them CD\n2. Tinh gia thanh TB\n3. Sap Xep Giam Dan Theo Gia Thanh\n4. Sap Xep Tang Dan Theo Tua CD\n5. Xuat danh sach CD\n0. Thoat Chuong Trinh");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        CD cd = new CD();
                        Console.Write("Nhap ma CD: ");
                        cd.MaCD = int.Parse(Console.ReadLine());

                        Console.Write("Nhap tua CD: ");
                        cd.TuaCD = Console.ReadLine();

                        Console.Write("Nhap Ten Ca Sy: ");
                        cd.Casy = Console.ReadLine();

                        Console.Write("Nhap so bai hat: ");
                        cd.SobaiHAt = int.Parse(Console.ReadLine());

                        Console.Write("Nhap gia: ");
                        cd.DonGia = double.Parse(Console.ReadLine());

                        quanlyCD.ThemCD(cd);
                        Console.WriteLine("Them thanh cong CD");
                        break;
                    case 2:
                        Console.WriteLine("Gia thanh trung binh la: {0}", quanlyCD.TinhGiaTB());
                        break;
                    case 3:
                        quanlyCD.SapXepGiamDanTheoGia();
                        Console.WriteLine("Da sap xep theo gia thanh giam dan!");
                        break;
                    case 4:
                        quanlyCD.SapXepTangDanTheoTua();
                        Console.WriteLine("Da sap xep theo ten tang dan!");
                        break;
                    case 5:
                        quanlyCD.Xuat();
                        break;
                    case 0:
                        Console.WriteLine("GOODBYE DONT SEE YOU AGAain");
                        Console.ReadLine();
                        break;
                }

            } while (chon != 0);

        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}
