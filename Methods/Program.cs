using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //int sonuc = Add2(20, 40);
            //Console.WriteLine(sonuc);

            //int number1 = 20;
            //int number2 = 100;
            //int sonuc2 = Add3(number1, number2); // burada sadece number1 in değeri gider number1 durur. (değer tip)
            //Console.WriteLine("Sonuç2: " + sonuc2);
            //Console.WriteLine("Number1 (Değer Tip): " + number1);

            //int sonuc3 = Add4(ref number1, number2); //Burada ise number1 in kendisi gider. (Referans tip.)
            //Console.WriteLine("Sonuç3: " + sonuc3);
            //Console.WriteLine("Number1 (Referans Tip): " + number1);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,3,4));
            Console.WriteLine(Add5(2,3,4));


            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Eklendi!!!");
        }
        static int Add2(int number1, int number2=30) // Eğer number2 verilmezse 30 kullan. Verilirse verileni kullan demektir.Sondan başlar.
        {
            int result= number1 + number2;
            return result;
        }
        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1+number2;
        }
        static int Add4(ref int number1, int number2)
        {
            number1 = 40;
            return number1 + number2;
        }

        static int Add5(out int number1, int number2)
            //Out parametresinde number1 i bir değere eşitlemek gerekmiyor.
            //int number1; şeklinde değersiz bırakabiliriz. Ancak metodun içinde ona bir değer vermek zorundayız.
            //ref de ise metot çağrılmadan önce parametreler ilk değerini almak zorundadır.
        {
            number1 = 40;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3) //Metotun Overloading yapılması. 
        {
            return number1 * number2*number3;
        }
        static int Add5(params int[] numbers) //params parametresi ile istediğimiz kadar parametre gönderebiliriz. params son parametre olur.
        {
            return numbers.Sum();
        }
    }
}
