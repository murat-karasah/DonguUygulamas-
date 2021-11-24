using System;

namespace DonguUygulaması
{
    class Program
    {
        public static int[] sayilar = { 10,20,25,28,34 };
        public static int toplam = 0, sayac = 0, i = 0, secim; 
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Döngü Seçiniz:\n 1-For \n 2-While \n 3-Foreach \n 4-Do-While \n 5-Enumeration ");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    fordongusu();
                    toplamyaz();
                    break;
                case 2:
                    whiledongusu();
                    toplamyaz();
                    break;
                case 3:
                    foreachdongusu();
                    toplamyaz();
                    break;
                case 4:
                    dowhiledongusu();
                    toplamyaz();
                    break;
                case 5:
                 break;
                default:
                    break;
            }
        }
        private static void dowhiledongusu()
        {
            do
            {
                toplam += sayilar[i];
                i++;
            } while (i<sayilar.Length); 
        }

        private static void foreachdongusu()
        {
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
                
            }
        }

        private static void whiledongusu()
        {
            while (i<sayilar.Length)
            {
               toplam+= sayilar[i];
                i++;
            }
        }

        private static void toplamyaz()
        {
            Console.WriteLine("Toplamı : "+toplam);
        }

        private static void fordongusu()
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }           
        }
    }
}
