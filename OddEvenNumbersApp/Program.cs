using System.Linq;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        PrintNmbers("numbers", numbers);
        PrintNmbers("Even numbers", numbers.Where(x => x%2==0));
        PrintNmbers("Even numbers", numbers.Where(x => IsEven(x)));
        PrintNmbers("Odd numbers", numbers.Where(x => IsOdd(x)));
        Console.ReadKey();
    }

    public static void PrintNmbers(string title, IEnumerable<int> numbers) 
    {
    
         Console.WriteLine();
         Console.Write($"{title} : [ ");
         foreach( int n in numbers ) 
        {
            Console.Write($"{n} ");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
    public static bool IsEven(int number) 
    { 
        if(number %2==0)
            return true;
        else
            return false;    
    }
    public static bool IsOdd(int number)
    {
        if (number % 2 != 0)
            return true;
        else
            return false;
    }
}