﻿class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Anna ensimmäinen numero:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Anna toinen numero:");
        int numero2 = int.Parse(Console.ReadLine());

        while(true)
        {
            Console.WriteLine("Miten haluat laskea luvut? (summa, erotus)");
            string laskuToiminto = Console.ReadLine();

            if (laskuToiminto.Equals("summa"))
            {
                int summa = numero1 + numero2;
                Console.WriteLine("Numeroiden summa on " + summa);
                break;
            }
            else if (laskuToiminto.Equals("erotus"))
            {
                int erotus = numero1 - numero2;
                Console.WriteLine("Numeroiden erotus on " + erotus);
                break;
            }
            else
            {
                Console.WriteLine("Väärä komento.");
            }
        }
    }
}