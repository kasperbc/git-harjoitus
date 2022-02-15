class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Anna ensimmäinen numero:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Anna toinen numero:");
        int numero2 = int.Parse(Console.ReadLine());

        
        int summa = numero1 + numero2;
        Console.WriteLine("Numeroiden summa on " + summa);
        int erotus = numero1 - numero2;
        Console.WriteLine("Numeroiden erotus on " + erotus);
    }
}