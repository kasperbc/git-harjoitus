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
            Console.WriteLine("Miten haluat laskea luvut? (summa, erotus, tulo, jako)");
            string laskuToiminto = Console.ReadLine();

            if (laskuToiminto.Equals("summa"))
            {
                Console.WriteLine("Numeroiden summa on " + Summa(numero1, numero2));
                break;
            }
            else if (laskuToiminto.Equals("erotus"))
            {
                Console.WriteLine("Numeroiden erotus on " + Erotus(numero1, numero2));
                break;
            }
            else if (laskuToiminto.Equals("tulo"))
            {
                Console.WriteLine("Numeroiden tulo on " + Tulo(numero1, numero2));
                break;
            }
            else if (laskuToiminto.Equals("jako"))
            {
                Console.WriteLine("Numeroiden jako on " + Jako(numero1, numero2));
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

    public static int Erotus(int n1, int n2)
    {
        return n1 - n2;
    }

    public static int Tulo(int n1, int n2)
    {
        return n1 * n2;
    }

    public static float Jako(int n1, int n2)
    {
        return (float)n1 / n2;
    }
}