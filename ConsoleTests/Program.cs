
using Russkyc.AttachedUtilities.ConsoleExtensions;

public static class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            var d = "Enter booleans ".GetCharCollection();
            d.ForEach(s => Console.WriteLine($"{s}"));
        }
    }
}