using System;

namespace kurucu_metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Yavuz","Eroglu",7,"IT Departmanı");
            calisan1.EkranaYazdir();
            Console.WriteLine("**********");

            Calisan cs1 = new Calisan("Fatma","Kus",16,"İnsan Kaynakları");

            cs1.EkranaYazdir();

            Calisan calisan2 = new Calisan("Hakan","Calhanoglu");

            calisan2.EkranaYazdir();
        }
    }

    public class Calisan{

        public string Ad;
        public string Soyad;

        public int No;
        public string Departman;

        public Calisan(string ad,string soyad,int no, string departman){
            Ad=ad;
            Soyad=soyad;
            No=no;
            Departman=departman;

        }
        public Calisan(string ad,string soyad){
            Ad=ad;
            Soyad=soyad;
        }
       

        public void EkranaYazdir(){
            Console.WriteLine("Calışanın Adı :{0}",Ad);
            Console.WriteLine("Calışanın Soyadı :{0}",Soyad);
            Console.WriteLine("Calışanın Numarası :{0}",No);
            Console.WriteLine("Calışanın Departmanı :{0}",Departman);
        }
    }
}