using System;

namespace SınavCalısmasıHafta2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// 0-1.000.000 Arası Asal Sayıları Listeleme Programı ///

            //int sayac = 0;
            //for (int sayi = 2; sayi <= 1000000; sayi++)
            {
                //int kontrol = 0;
                //for( int i =2; i < sayi; i++)
                {
                    //if (sayi % i == 0)
                    {
                        //kontrol = 1;
                        //break;
                    }
                }
                //if (kontrol ==1 )
                {
                    //Console.WriteLine(" {0} asal değildir", sayi);
                }
                //else
                {
                    //Console.WriteLine("{0} asaldır.", sayi);
                    //sayac++;
                }
            }
            //Console.WriteLine("===============");
            //Console.WriteLine("{0} adet asal sayı var", sayac);
            //Console.WriteLine("Hello World!");

            // Kullanıcının girdiği n kadar sayının 3 ve 7 'ye tam bölünebilen sayıların listesi //

            Console.WriteLine("Bir Sayı Giriniz: ");
            int n = int.Parse(Console.ReadLine());                       //int.parse kullanılıyor.
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)                            //Bölme işlemi formatı '==' çok önemli // 
                {
                    Console.WriteLine("{0}", i);
                }
            }

            // Kullanıcının girdiği dizini alfabetik olarak sıralamak //
            Console.WriteLine("Alfabetik Olarak Sıralamak");
            int adet;                                             /// Sayı olduğu için int e çevirdik
            Console.WriteLine("Girilecek Veri Adeti: ");
            adet = Convert.ToInt32(Console.ReadLine());          /// Yanlış türde sayı girme ihtimaline karşı tam sayıya çevirdik

            Console.WriteLine("----------------------");
            string[] liste = new string[adet];                   /// Girilen sayı büyüklüğünde dizin(liste) oluşturduk.
            string isim;                                        /// Bu dizinin bireylerine isim dedik.

            for (int i = 0; i < adet; i++)                      /// Burada sayı büyüklüğü kadar sırasıyla veri istedik. 1. -2. -3. isim vs.
            {
                Console.WriteLine(i + 1 + ". İsmi Giriniz: ");
                isim = Console.ReadLine();
                liste[i] = isim;
            }

            Console.WriteLine();
            Console.WriteLine("Sıralamadan önce liste: ");
            Console.WriteLine("--------------------");

            foreach (string eleman in liste)                 /// Burada kullanıcının verdiği isimleri(elemanları) listeden yazdırdık
            {
                Console.WriteLine(eleman);
            }

            Array.Sort(liste);
            Console.WriteLine();
            Console.WriteLine("A-Z Sıralama: ");                   /// Array.Sort ile bunları a'dan z'ye düzenledik. Yazdırdık.
            Console.WriteLine("---------------------");

            foreach (string eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            Console.WriteLine();
            Array.Reverse(liste);                    /// Listedeki verileri tersine çevirdi
            Console.WriteLine("Z-A Sıralama");
            Console.WriteLine("---------------------");

            foreach (string eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            // Girilen metindeki sesli harfleri bulma //
            Console.WriteLine("Girilen Metindeki Sesli Harfleri Bulan Program");
            Console.WriteLine("Herhangi bir cümle kurunuz: ");
            string metin = Console.ReadLine();          /// Burada yazılan metni string metin değerine atadık. ///
            string sesli = "aeıioöuü";                  /// Burada string "sesli" nin değerini atadık. //

            int sayac = 0;                              /// Metin içindeki sesli değeri bulmak için sayaç belirttik. ///
            for (int i = 0; i < metin.Length; i++)      /// Standart arama formül ///
            {
                if (sesli.Contains(metin[i]))            /// Koşul ekledik. Eğer sesli harfler metin içindeyse sayacı arttırdık ///
                {
                    sayac++;
                }
            }
            Console.WriteLine(metin);
            Console.WriteLine("Yukarıdaki cümlede toplam {0} \ntane sesli harf vardır.", sayac); /// Writeline'da {0} bunu kullanıyorsan en son tırnağı kapattıktan sonra sayac koymayı unutma //

            // Kullanıcıdan 10 adet sayı alarak bu sayıların toplamını ekranda gösteren program //

            int sayı, toplam = 0;                                 /// Baştaki değeri atadık.
            for (int i = 1; i <= 10; i++)                        /// Eğer sıfır yaparsan program senden 0. sayıyı ister ///
            {
                Console.WriteLine("{0} sayı: ", i);             /// Program bize sırasıyla 1. 2. 3. 4. sayıyı yazdırtıyor. 10'a küçük eşit gelene kadar i'yi 1 artırıyor. //
                sayı = Convert.ToInt32(Console.ReadLine());       /// Sayıyı int'e çeviriyoruz.
                toplam += sayı;
            }
            Console.WriteLine("Girdiğiniz sayı toplamı : {0}", toplam);   /// Writeline'a {0} veriyorsak virgül sonrası sayac/toplam eklemeyi unutmuyoruz. ///

            // Bilgisayarın rastgele verdiği 10 sayının tek - çift olanların sayısını gösteren program //
            Console.WriteLine("Rastgele 10 Sayıyı Tek-Çift olarak ayıran Program");
            int sayı2, tekAdet = 0, ciftAdet = 0;
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                sayı2 = rnd.Next(1, 100);
                Console.WriteLine(sayı2);
                if (sayı2%2 == 0)
                {
                    ciftAdet++;
                }
                else
                {
                    tekAdet++;
                }
            }
            Console.WriteLine("Çift Sayı Adedi: {0}", ciftAdet);
            Console.WriteLine("Tek Sayı Adedi: {0}", tekAdet);

            // Kullanıcının Girdiği Metni Kullanıcının Girdiği Sayıda Yazdıran Program //
            Console.WriteLine("Kullacının Girdiği Metni İstediği Kadar Yazdıran Program");
            Console.WriteLine("Metni Girin: ");
            string metin5 = Console.ReadLine();
            Console.WriteLine("Kaç Defa Yazdırılsın: ");
            int sayı5 = Convert.ToInt32(Console.ReadLine());

            for( int i = 1; i <= sayı5; i++)
            {
                Console.WriteLine(metin5);
            }

        }
    }
}
