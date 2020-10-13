using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 16, resto;
            string binario = "";
            while (num > 0)
            {
                resto = num % 2;
                num  /= 2;
                binario = Convert.ToString(resto) + binario;
            }
            Console.WriteLine($"il numero binario è:{binario}");
            Console.ReadLine();
        }
    }
}
