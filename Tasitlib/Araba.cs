using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tasitlib
{
    public class Araba : Basetasit
    {

        protected string aitlik;

        public string Aitlik
        {
            get { return aitlik; }
            set { aitlik = value; }
        }

        protected int kullanıcısayisi;

        public int Kullanıcısayisi
        {
            get { return kullanıcısayisi; }
            set { kullanıcısayisi = value; }
        }

        public Araba()
        {

            Console.Write("\nKullanıcı sayısını Giriniz: ");
            Kullanıcısayisi = int.Parse(Console.ReadLine());

            Console.Write("Asil Kullanıcı ismini Giriniz: ");
            Aitlik = Console.ReadLine();

            Console.WriteLine("\nAraba bilgileri Kayıt Edildi.");




            //Console.WriteLine(aitlik + kullanıcısayisi); //inherit yazdırma deneme
        }

        //public override void Hesapla(string Tip, double Motorhacmi, int Tekersayi, int Yas)
        //{
        //    base.Hesapla(Tip, Motorhacmi, Tekersayi, Yas);
        //    this.Aitlik = aitlik;
        //    this.Kullanıcısayisi = kullanıcısayisi;


        //}


        //public  void Hesapla(string Tip, double Motorhacmi, int Tekersayi, int Yas, int a) Deneme
        //{
        //    base.Hesapla(Tip, Motorhacmi, Tekersayi, Yas);
        //}
        //public static new void giris() namehiding
        //{
        //    Console.WriteLine("Araba Giriş yapıldı");
        //}

        //public string ad1 = "Araba Girişi Yapıldı"; overriding
        // public override string giris(string ad1)
        // {
        //      return ad = ad1;
        // }
    }
}
