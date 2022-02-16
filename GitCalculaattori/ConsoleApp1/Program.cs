class Program
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
                Console.WriteLine("Numeroiden summa on " + Summa(numero1, numero2));
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

    public static int Summa(int n1, int n2)
    {
        return n1 + n2;
    }
}