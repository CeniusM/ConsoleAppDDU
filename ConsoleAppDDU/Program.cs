namespace MyProgram;

class Program
{
    public static readonly string[] DayNames =
        [
            "Mandag",
            "Tirsdag",
            "Onsdag",
            "Torsdag",
            "Fredag",
            "Lørdag",
            "Søndag"
        ];

    static void Rapport(int[] hoursWorked)
    {
        Console.WriteLine("--- Rapport ---");
        for (int i = 0; i < DayNames.Length; i++)
        {
            Console.WriteLine($"{DayNames[i]}: {hoursWorked[i]} timer");
        }
        Console.WriteLine("");
        Console.WriteLine("- Overview -");
        Console.WriteLine($"Total: {hoursWorked.Sum()} timer");
        Console.WriteLine($"Avg: {Math.Round(hoursWorked.Average(), 1)} timer");
        Console.WriteLine($"Max: {hoursWorked.Max()} timer");
        Console.WriteLine($"Min: {hoursWorked.Min()} timer");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Angiv dine arbejdstimer for hver dag i den sidste uge");

        Console.WriteLine();

        int[] hoursWorked = new int[DayNames.Length];

        int i = 0;
        while (i < DayNames.Length)
        {
            Console.Write($"Arbejds timer for {DayNames[i]}: ");

            if (int.TryParse(Console.ReadLine(), out int num))
            {
                hoursWorked[i] = num;
            }
            else
            {
                Console.WriteLine("Error: Ugyldigt input, exiting");
                return;
            }

            i++;
        }

        Thread.Sleep(1000);
        Console.WriteLine("Data indsamlet...");
        Thread.Sleep(1000);
        Console.WriteLine("Generer rapporten...");
        Thread.Sleep(1000);
        Console.WriteLine("");

        Rapport(hoursWorked);
    }
}