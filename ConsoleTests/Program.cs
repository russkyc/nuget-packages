
using Russkyc.AttachedUtilities.ConsoleExtensions;
using Russkyc.AttachedUtilities.ConsoleExtensions.Types;

public static class Program
{
    public static void Main(string[] args)
    {
        var fruits = new List<string>
        {
            "apple",
            "banana",
            "cherry",
            "date",
            "elderberry",
            "fig",
            "grape",
            "honeydew",
            "kiwi",
            "lemon",
            "mango",
            "nectarine",
            "orange",
            "pear",
            "quince"
        };


        fruits.ToRichOutput()
            .SetMode(OutputMode.Debug)
            .SetForeground(Foreground.Green)
            .WriteAll(" ");

        "galing galing!".ToRichOutput().WriteLine();
    }
}