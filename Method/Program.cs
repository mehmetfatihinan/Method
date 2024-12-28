using System;


namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Lyrics();
            RandomNumber();
            Console.WriteLine("Çarpım için birinci sayıyı giriniz: ");
            long userNumberOne = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Çarpım için ikinci sayıyı giriniz: ");
            long userNumberTwo = Convert.ToInt64(Console.ReadLine());
            long result = Multiply(userNumberOne, userNumberTwo);
            Console.WriteLine($"{userNumberOne} ve {userNumberTwo}'nin çarpımı: {result}");
            Console.WriteLine("İsminizi giriniz: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Soyisminizi giriniz: ");
            string userSurname = Console.ReadLine();
            Welcoming(userName, userSurname);
        }

        //Geriye Değer Döndürmeyen Bir void metot. Ekrana sevdiğiniz bir şarkı sözünü yazdırsın.
        public static void Lyrics()
        {
            Console.WriteLine("A broken spirit that may never heal \r\nTry my best to erase all the memories");
        }

        // Geriye Tamsayı Döndüren Bir metot. Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
        public static void RandomNumber()
        {
            Random random_number = new Random();
            int number = random_number.Next(1, 10001); // 1 ila 10000 arasında rastgele sayı üretir
            int remainder = number % 2;
            Console.WriteLine($"Secilen Sayı: {number}, 2'ye bolumunden kalan: {remainder}");
        }

        // Parametre Alan ve Geriye Değer Döndüren Bir Metot. Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
        public static long Multiply(long a, long b)
        {
            return a * b;
        }

        //Parametre Alan ve Geriye Değer Döndürmeyen bir Metot. Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.

        public static void Welcoming(string name, string surname)
        {
            Console.WriteLine($"Hoş Geldiniz : {name} {surname}");
        }
    }
}