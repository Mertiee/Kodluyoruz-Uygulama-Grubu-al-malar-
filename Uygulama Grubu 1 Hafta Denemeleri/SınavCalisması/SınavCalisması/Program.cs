using System;

namespace SınavCalisması
{
    class Program
    {
        static void Main(string[] args)
        {
            //İsim-Soyisim Yazdırma (Alıştırma 1)
            Console.WriteLine("Adınızı Giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Hoşgeldin " + name + " " + surname);

            //Toplama İşlemi Yapma (Alıştırma 2)
            Console.WriteLine("Hadi Toplama İşlemi Yapalım!");
            Console.WriteLine("1. Sayıyı Giriniz: ");
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz: ");
            int sayı2 = Convert.ToInt32(Console.ReadLine());
            int toplam = sayı1 + sayı2;
            Console.WriteLine("Toplam: " + toplam);

            //Dikdörtgen Alan-Çevre Hesaplama (Alıştırma 3)
            Console.WriteLine("Dikdörtgen Alanı Hesaplama: ");
            Console.WriteLine("Kısa Kenar: ");
            int kısakenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun Kenar: ");
            int uzunkenar = Convert.ToInt32(Console.ReadLine());
            int alan = kısakenar * uzunkenar;
            int çevre = 2 * (kısakenar + uzunkenar);
            Console.WriteLine("Alan: " + alan);
            Console.WriteLine("Çevre: " + çevre);

            //Sayı Aralığı Hesaplama (Alıştırma 4)
            Console.WriteLine("***Sayı Aralık Hesaplama***");
            int sayıaralık;
            Console.WriteLine("Sayıyı Giriniz: ");
            sayıaralık = Convert.ToInt32(Console.ReadLine());
            if(sayıaralık >=0 && sayıaralık <=100)
            {
                Console.WriteLine("Girilen Sayı 0 - 100 aralığında");
            }
            else
            {
                Console.WriteLine("Girilen Sayı 0 -100 aralığında değil");
            }

            //Vücut Kitle Endeksi Hesaplama (Alıştırma 6)
            Console.WriteLine("*****Vücut Kitle Endeksi Hesaplama****");
            double boy, kilo, indeks = 0;
            Console.WriteLine("Boyunuzu 'Metre' Cinsinden Giriniz (Ör: 1,72) : ");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilonuzu 'Kg' Cinsinden Giriniz: ");
            kilo = Convert.ToDouble(Console.ReadLine());
            indeks = kilo / (boy * boy);
            Console.WriteLine("=================");
            Console.WriteLine("Vücut Kitle İndeksiniz: {0}", indeks);
            if (indeks < 18) 
            {
                Console.WriteLine("Zayıf");
            }
            else if (indeks>=18 && indeks < 25) 
            {
                Console.WriteLine("İdeal Kilonuzdasınız");
            }
            else if (indeks >=25 && indeks < 30)
            {
                Console.WriteLine("Kilolu");
            }
            else if (indeks >= 30 && indeks < 35)
            {
                Console.WriteLine("Obez");
            }
            else
            {
                Console.WriteLine("Ciddi Obez");
            }

            //Cümledeki Harf Sayısı (Alıştırma 7)
            Console.WriteLine("******Cümledeki harf sayısını bulalım!******");
            Console.WriteLine("Herhangi bir cümle yazınız: ");
            string metin = Console.ReadLine();
            Console.WriteLine(metin + "\n");
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ" + "abcçdefgğhiıjklmnoöprsştuüvyz";
            int sayac = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (liste.Contains(metin[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Yukarıdaki ifadede toplam {0} \ntane harf vardır", sayac);

            //Tek-Çift Hesaplama (Alıştırma 5)
            Console.WriteLine("****Tek-Çift Hesaplama******");
            int deger;
            Console.Write("Sayı Giriniz : ");
            deger = Convert.ToInt32(Console.ReadLine());
            TekCift(deger);
            Console.ReadKey();
        }
        static void TekCift(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.Write("Girilen sayı çifttir");
            }
            else
            {
                Console.Write("Girilen sayı tektir");
            }

        }
    }

}
