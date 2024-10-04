

//using System.Diagnostics;

//namespace Factorial;

//class Program
//{
//    static void Main(string[] args)
//    {
//        //for (int i = 0; i <= 10; i++)
//        //{
//        //    Console.WriteLine($"Fib({i}) = {Fibonacci(i)}");

//        //    //Console.WriteLine($"{i}! = {Factorial(i)}");
//        //}

//        Stopwatch sw = Stopwatch.StartNew();
//        //for (int i = 0; i < 100; i++)
//        //    Console.WriteLine(i + " " + Fibonacci(i));
//        Console.WriteLine(Fibonacci(100));
//        Console.WriteLine(sw.Elapsed);
//    }

//    static Dictionary<long, long> results_cache = new Dictionary<long, long>();
//    static long Fibonacci(long n)
//    {
//        if (results_cache.ContainsKey(n))
//            return results_cache[n];

//        if (n < 0)
//            throw new ArgumentException($"{nameof(n)} can not be below 1");

//        if (n == 0)
//            return 0;
//        if (n == 1)
//            return 1;

//        long r = Fibonacci(n - 1) + Fibonacci(n - 2);
//        results_cache.Add(n, r);
//        return r;
//    }

//    static long Factorial(long n)
//    {
//        if (n < 0)
//            throw new ArgumentException($"{nameof(n)} can not be below 0");

//        if (n == 0 || n == 1)
//            return 1;
//        else
//            return n * Factorial(n - 1);
//    }
//}





//namespace MyApp;

//internal class Program
//{
//    static readonly Dictionary<string, Func<int, int, double>> AvailableOperations = new Dictionary<string, Func<int, int, double>>()
//    {
//        { "Addition", Add },
//        { "Subtraction", Sub },
//        { "Multiplication", Mul },
//        { "Division", Div },
//        { "Power", Power },
//        { "Logarithm", (x, y) => Log10(x) },
//    };

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hello Maths :D");

//        foreach (var opp in AvailableOperations)
//        {
//            double result = opp.Value(4, 6);
//            Console.WriteLine($"Resultatet af {opp.Key} er: {result}");
//        }
//    }

//    /// <summary>
//    /// Denne metode tager to argumenter <paramref name="a"/> og <paramref name="b"/>:
//    /// Add(a, b) = a + b
//    /// </summary>
//    /// <returns>
//    /// a + b
//    /// </returns>
//    static double Add(int a, int b)
//    {
//        // Add plusser a og b sammen, og retunere resultatet
//        int result = a + b;
//        return result;
//    }

//    /// <summary>
//    /// Denne metode tager to argumenter <paramref name="a"/> og <paramref name="b"/>:
//    /// Sub(a, b) = a - b
//    /// </summary>
//    /// <returns>
//    /// a - b
//    /// </returns>
//    static double Sub(int a, int b)
//    {
//        // Sub minuser a med b, og retunere resultatet
//        int result = a - b;
//        return result;
//    }

//    /// <summary>
//    /// Denne metode tager to argumenter <paramref name="a"/> og <paramref name="b"/>:
//    /// Mul(a, b) = a * b
//    /// </summary>
//    /// <returns>
//    /// a * b
//    /// </returns>
//    static double Mul(int a, int b)
//    {
//        // Mul ganger a og b sammen, og retunere resultatet
//        int result = a * b;
//        return result;
//    }

//    /// <summary>
//    /// Denne metode tager to argumenter <paramref name="a"/> og <paramref name="b"/>:
//    /// Div(a, b) = a / b
//    /// </summary>
//    /// <returns>
//    /// a / b
//    /// </returns>
//    static double Div(int a, int b)
//    {
//        // Div dividere a med b, og retunere resultatet
//        double result = (double)a / b;
//        return result;
//    }

//    /// <summary>
//    /// Denne metode tager to argumenter <paramref name="a"/> og <paramref name="x"/>:
//    /// Power(<paramref name="a"/>, <paramref name="x"/>) = <paramref name="a"/>^<paramref name="x"/>
//    /// </summary>
//    /// <returns>
//    /// <paramref name="a"/>^<paramref name="x"/>
//    /// </returns>
//    static double Power(int a, int x)
//    {
//        // Power opløfter a i x, og retunere resultatet
//        int result = (int)Math.Pow(a, x);
//        return result;
//    }

//    /// <summary>
//    /// Denne metode tager et argument <paramref name="x"/>:
//    /// Log10(<paramref name="x"/>) = log (<paramref name="x"/>)
//    /// </summary>
//    /// <returns>
//    /// log (<paramref name="x"/>)
//    /// </returns>
//    static double Log10(int x)
//    {
//        // Log10 tager den naturelige logaritme af x, og retunere resultatet
//        double result = (double)Math.Log10(x);
//        return result;
//    }
//}












////#define MyStuff

//#if MyStuff
//using System.Runtime.InteropServices;

//namespace ConsoleAppDDU;

//class Program
//{
//    [DllImport("libs/MatrixMathDLL")]
//    private static extern float Sum(float[] arr);

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hello everyone!");
//        float[] one_to_ten = Enumerable.Range(1, 10).Select(x => (float)x).ToArray();

//        float sum = Sum(one_to_ten);

//        Console.WriteLine(sum);
//    }
//}



//#else


//namespace ConsoleAppDDU;

//class Program
//{
//    static int[] GenerateTable(int size)
//    {
//        return new int[size];
//    }

//    static void InitTable(int[] table, int min_inclusive = 0, int max_exclusive = int.MaxValue)
//    {
//        Random rand_gen = new Random();

//        for (int i = 0; i < table.Length; i++)
//        {
//            table[i] = rand_gen.Next(min_inclusive, max_exclusive);
//        }
//    }

//    // Prints table formatted as so
//    // "[1, 53, 65, 0, -12, 50, 4]"
//    static void PrintTable(int[] table)
//    {
//        string table_formatted = $"[{string.Join(", ", table)}]";
//        Console.WriteLine(table_formatted);
//    }

//    static void Main(string[] args)
//    {
//        // Cenius

//        int table_size = 100;

//        int[] table = GenerateTable(table_size);

//        InitTable(table, 0, 100);

//        PrintTable(table);
//    }
//}
//#endif





////namespace ConsoleAppDDU;

////class Program
////{
////    static void SayHelloTo(string name)
////    {
////        Console.WriteLine($"Hello {name}!");
////    }

////    static void Main(string[] args)
////    {
////        // Cenius

////        Console.WriteLine("Hi, what is your name?");
////        Console.Write("-->");
////        string name = Console.ReadLine()!;

////        for (int i = 0; i < 24; i++)
////        {
////            SayHelloTo(name);
////        }
////    }
////}
///





















//namespace MyApp;

//internal class Program
//{
//    static string[] Users = { "", "", "", "", "" };

//    static void Main(string[] args)
//    {
//        Run();
//    }

//    static void Run()
//    {
//        bool running = true;

//        while (running)
//        {
//            Console.Clear();

//            Console.WriteLine("Menu (CRUD):");
//            Console.WriteLine("1: Create Username");
//            Console.WriteLine("2: Read Usernames");
//            Console.WriteLine("3: Update Username");
//            Console.WriteLine("4: Delete Username");
//            Console.WriteLine("5: Quit Program");

//            string choice = Console.ReadLine()!;

//            switch (choice)
//            {
//                case "1":
//                    CreateUser();
//                    break;
//                case "2":
//                    ReadUser();
//                    break;
//                case "3":
//                    UpdateUser();
//                    break;
//                case "4":
//                    DeleteUser();
//                    break;
//                case "5":
//                    running = false;
//                    break;
//                default:
//                    break;
//            }
//        }
//    }

//    static void CreateUser()
//    {
//        Console.Clear();
//        Console.WriteLine("CreateUser");
//        Console.WriteLine("Input a username: ");
//        string name = Console.ReadLine()!;

//        int avalibleSlot = -1;

//        for (int i = 0; i < Users.Length; i++)
//        {
//            if (Users[i] == "")
//            {
//                avalibleSlot = i;
//                break;
//            }
//        }

//        if (avalibleSlot == -1)
//        {
//            WaitForUser("No user slots avalible");
//        }
//        else
//        {
//            Users[avalibleSlot] = name;
//            Console.WriteLine("User created!");
//            Console.WriteLine();
//            ReadUser(); // feedback to user
//        }
//    }

//    static void ReadUser()
//    {
//        Console.Clear();
//        Console.WriteLine("- Users -");

//        foreach (var user in Users)
//        {
//            if (user != "")
//            {
//                Console.WriteLine(user);
//            }
//        }

//        int userCount = Users.Count(x => x != "");
//        int userCapacity = Users.Length;
//        Console.WriteLine($"Currently have {userCount} out of {userCapacity} slots");

//        WaitForUser();
//    }

//    static void UpdateUser()
//    {
//        Console.Write("User name: ");
//        string name = Console.ReadLine()!;

//        int index = Array.IndexOf(Users, name);

//        if (index == -1)
//        {
//            WaitForUser($"User \"{name}\" could not be found");
//        }
//        else
//        {
//            Console.Write("New name: ");
//            string newName = Console.ReadLine()!;

//            Users[index] = newName;

//            WaitForUser("User have been updated");
//        }
//    }

//    static void DeleteUser()
//    {
//        Console.Write("User name: ");
//        string name = Console.ReadLine()!;

//        int index = Array.IndexOf(Users, name);

//        if (index == -1)
//        {
//            WaitForUser($"User \"{name}\" could not be found");
//        }
//        else
//        {
//            Users[index] = "";
//            WaitForUser($"User \"{name}\" have been deleted");
//        }
//    }

//    static void WaitForUser(string msg = "")
//    {
//        if (msg != "")
//        {
//            Console.WriteLine($"{msg}");
//        }

//        ConsoleColor prevColor = Console.ForegroundColor;
//        Console.ForegroundColor = ConsoleColor.DarkBlue;
//        Console.WriteLine("Press enter to continue...");
//        Console.ReadLine();
//        Console.ForegroundColor = prevColor;
//    }
//}

























//#define Opgave2

//#if Opgave2
//namespace MyApp;

//internal class Program
//{
//    static void Opg_2_a()
//    {
//        int i = 1;
//        while (i <= 10)
//        {
//            Console.WriteLine(i);
//            i++;
//        }
//    }

//    static void Opg_2_b()
//    {
//        int i = 1;
//        do
//        {
//            Console.WriteLine(i);
//            i++;
//        } while (i <= 10);
//    }

//    static void Opg_2_c()
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            Console.WriteLine(i);
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("--- while loop ---");
//        Opg_2_a();
//        Console.WriteLine();

//        Console.WriteLine("--- do-while loop ---");
//        Opg_2_b();
//        Console.WriteLine();

//        Console.WriteLine("--- for loop ---");
//        Opg_2_c();
//        Console.WriteLine();
//    }
//}
//#else
//namespace MyApp;

//internal class Program
//{
//    static void WhileLoop(int max)
//    {
//        int i = 1;
//        while (i <= max)
//        {
//            Console.WriteLine(i);
//            i++;
//        }
//    }

//    static void DoWhileLoop(int max)
//    {
//        int i = 1;
//        do
//        {
//            Console.WriteLine(i);
//            i++;
//        } while (i <= max);
//    }

//    static void ForLoop(int max)
//    {
//        for (int i = 1; i <= max; i++)
//        {
//            Console.WriteLine(i);
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Max loop value: ");
//        int maxValue = int.Parse(Console.ReadLine()!);
//        Console.WriteLine();


//        Console.WriteLine("--- while loop ---");
//        WhileLoop(maxValue);
//        Console.WriteLine();

//        Console.WriteLine("--- do-while loop ---");
//        DoWhileLoop(maxValue);
//        Console.WriteLine();

//        Console.WriteLine("--- for loop ---");
//        ForLoop(maxValue);
//        Console.WriteLine();
//    }
//}
//#endif