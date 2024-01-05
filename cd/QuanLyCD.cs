using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd
{
    class QuanLyCD
    {
        private CD[] ds;
        private int n;


        
        
        public QuanLyCD()
        {
            ds = new CD[100];
            n = 0;
        }
        public QuanLyCD(int sophantu)
        {
            ds = new CD[sophantu];
            n = 0;
        }
        public void ThemCD(CD cd)
        {
            if (n > ds.Length)
            {
                Console.WriteLine("Danh sach da day!");
            }
            else
            {
                if (!KiemTraTrungCD(cd.MaCD))
                    ds[n++] = cd;
                else
                {
                    Console.WriteLine("Trung ma CD");
                }
            }
        }
        public bool KiemTraTrungCD(int macd)
        {
            for (int i = 0; i < n; i++)
            {
                if (ds[i].MaCD == macd)
                {
                    return true;
                }
                
            }
            return false;
        }
        public double TinhGiaTB()
        {
            double tonggia = 0;
            for (int i = 0; i < n; i++)
            {
                tonggia+=ds[i].DonGia;
                    
            }
            return tonggia / n;
        }
        public void Xuat()
        {
            Console.WriteLine("{0, 10} {1,30} {2,30} {3,10} {4,15}", "MaCD", "Tua CD", "Ca Sy", "So Bai Hat", "Gia Thanh");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ds[i].ToString());        
            }
        }
        public void SapXepGiamDanTheoGia()
        {
            CD tam;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ds[i].DonGia < ds[j].DonGia)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }


        }
        public void SapXepTangDanTheoTua()
        {
            CD tam;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ds[i].TuaCD.CompareTo(ds[j].TuaCD)>0)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }

    }
}
