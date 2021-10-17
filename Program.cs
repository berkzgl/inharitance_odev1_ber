using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Tasitlib;

namespace inharitance_odev_berk
{
    class Program
    {
        public static int sayi = 0;


        static void Main(string[] args)
        {
            #region Notlar
            //Console.WriteLine("berk"); -- Deneme
            //Basetasit arac1 = new Basetasit();

            //Araba arac2 = new Araba();

            //arac1.giris("asdasd");
            //arac2.giris("asdasdasdasdad");

            //Console.ReadKey();

            //Basetasit arac1 = new Basetasit(); -- Base Deneme
            //arac1.Hesapla("",0,0,0);
            //Console.WriteLine(arac1.Yas+arac1.Tip+arac1.Tekersayi+arac1.Motorhacmi); 
            #endregion

            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\Araba_bilgileri.txt"))
            {
                System.IO.File.Delete(Environment.CurrentDirectory + @"\Araba_bilgileri.txt");
            }
            try
            {
                Console.WriteLine("Kaç Adet Araba Girişi Yapmak İstiyorsunuz?");
                sayi = int.Parse(Console.ReadLine());

                for (int i = 1; i <= sayi; i++)
                {
                    Araba arac = new Araba();
                    dosyayaYaz(arac.Tip, arac.Motorhacmi, arac.Tekersayi, arac.Yas, arac.Kullanıcısayisi, arac.Aitlik);

                }

                Console.WriteLine("\nBilgiler Dosya Yolundaki Araba_bilgileri.txt Dosyasına Başarıyla Kayıt Edilmiştir.");

            }
            catch (Exception)
            {

                Console.WriteLine("Bir Hata Oluştu Lütfen Doğru Değerler İle Tekrar Deneyiniz.");
                throw;
            }

            Console.ReadKey();
        }

        public static void dosyayaYaz(string tip, double motorhacmi, int tekersayi, int yas, int kullanıcısayisi, string aitlik)
        {
            string dosya_yolu = Environment.CurrentDirectory + @"\Araba_bilgileri.txt";



            // FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(dosya_yolu, true);

            sw.WriteLine($"----------------Araba Bilgileri----------------\nTaşıt tipi: " + tip + "\nMotor Hacmi: " + motorhacmi + "\nTeker Sayısı: " + tekersayi + "\nAraba Üretim Yılı: " + yas + "\nArabayı Kullanan Kişi Sayısı: " + kullanıcısayisi + "\nAsil Kullanıcı İsmi: " + aitlik);

            sw.Flush();

            sw.Close();
            //fs.Close();


        }
    }
}
