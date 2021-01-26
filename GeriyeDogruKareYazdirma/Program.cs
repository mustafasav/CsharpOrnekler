using System;

namespace GeriyeDogruKareYazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu uygulamada kullanının girmiş olduğu sayıdan geriye doğru her sayının karesini yazdıracağız.

            int girilenSayi = 0;
            Console.Write("Bir Sayı Giriniz: "); //Kullanıcının Sayı Girmesi İçin Mesaj Veriyoruz.
            girilenSayi = Convert.ToInt32(Console.ReadLine()); //Kullanıcının girmiş olduğu sayıyı alıp girilenSayi değişkenine aktarıyoruz.

            for (int i = girilenSayi; i > 0; i--) //Girilen sayıdan geriye doğru bir döngü oluşturuyoruz.
            {
                Console.WriteLine("Sayı: " + i + "\tKaresi: " + i * i); //Döngü içinde önce sayısı sonra sayının karesini yazdırıyoruz.
            }
        }
    }
}
