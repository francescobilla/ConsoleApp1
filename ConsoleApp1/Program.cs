using System;

namespace trasformatore_da_decimale_a_binario
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto, divisore;
            Console.WriteLine("inserisci il numero decimale:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci il valore con cui vuoi dividere:");
            divisore = Convert.ToInt32(Console.ReadLine());
            string binario = "";
            while (num > 0)
            {
                resto = num % divisore;
                num /= divisore;
                binario = Convert.ToString(resto) + binario;
            }
            Console.WriteLine($"il numero inserito corrisponde in binario: {binario}");
            Console.ReadLine();
        }
    }
}
