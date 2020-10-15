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
                if(resto == 15)
                {
                    binario += "f";
                }else if(resto == 14)
                {
                    binario += "e";
                } else if (resto == 13)
                {
                    binario += "d";
                }else if (resto == 12)
                {
                    binario += "c";
                }else if (resto == 11)
                {
                    binario += "b";
                }else if (resto == 10)
                {
                    binario += "a";
                }
                else
                {
                    binario = Convert.ToString(resto) + binario;
                }
                num /= divisore;
               
            }
            Console.WriteLine($"il numero inserito corrisponde in binario: {binario}");
            Console.ReadLine();
        }
    }
}
