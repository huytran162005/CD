using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cd
{
    class CD
    {
        private int macd;
        private string tuacd;
        private string casy;
        private int sobaihat;
        private double dongia;

        public CD()
        {

        }
        public CD(int macd,string tuacd,string casy,int sobaihat,double dongia)
        {
            this.macd = macd;
            this.tuacd = tuacd;
            this.casy = casy;
            this.sobaihat = sobaihat;
            this.dongia = dongia;
        }
        public int MaCD
        {
            set { this.macd = value; }
            get { return macd; }
        }
        public string TuaCD
        {
            set { this.tuacd = value; }
            get { return tuacd; }
        }
        public string Casy
        {
            set { this.casy = value; }
            get { return casy; }
        }
        public int SobaiHAt
        {
            set { this.sobaihat = value; }
            get { return sobaihat; }
        }
        public double DonGia
        {
            set { this.dongia = value; }
            get { return dongia; }
        }
        public string ToString()
        {
            return string.Format("{0, 10} {1,30} {2,30} {3,10} {4,15:#,##0}",macd,tuacd,casy,sobaihat,dongia);
        }




    }
    
        
}
