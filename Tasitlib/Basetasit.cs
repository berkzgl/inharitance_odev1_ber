using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tasitlib
{
    public class Basetasit
    {
        //protected string ad= "BASE Giriş yapıldı"; overriding
        //public  virtual string giris(string ad)
        //{

        //    this.ad = ad;
        //    return ad;


        //}
        public Basetasit()
        {



            Console.Write("Taşıt Tipini Giriniz: ");
            Tip = Console.ReadLine();

            Console.Write("Motor Hacmini Giriniz: ");
            Motorhacmi = int.Parse(Console.ReadLine());

            Console.Write("Teker Sayısını Giriniz: ");
            Tekersayi = int.Parse(Console.ReadLine());

            Console.Write("Taşıtın Üretim Yılını Giriniz: ");
            Yas = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTaşıt Girişi Yapıldı.");






            //Console.WriteLine(yas + tip + tekersayi + motorhacmi); //toplu yazdırma deneme başarılı

        }



        protected string tip;

        public string Tip //binek - ticari - geniş araç - iş makinesi
        {
            get { return tip; }
            set { tip = value; }
        }

        protected double motorhacmi;

        public double Motorhacmi
        {
            get { return motorhacmi; }
            set { motorhacmi = value; }
        }

        protected int tekersayi;

        public int Tekersayi
        {
            get { return tekersayi; }
            set { tekersayi = value; }
        }

        protected int yas;

        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }

        public void Yazdır()
        {

        }




        //public virtual void Hesapla(string Tip, double Motorhacmi, int Tekersayi, int Yas)
        //{

        //    this.Tip = tip;
        //    this.Motorhacmi = motorhacmi;
        //    this.Tekersayi = tekersayi;
        //    this.Yas = yas;

        //}



    }
}
