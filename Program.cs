using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayıyı Giriniz: ");
            int Sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = Sayi; i > 10 ; i/=2  )
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

