using System.Runtime.CompilerServices;

namespace PartOneDemo;
public static class RomanNumerals
{
    public static string Run(int number)
    {
        return new string('I', number)
            .Replace("IIIII", "V")
            .Log("Before VV")
            .Replace("VV", "X")
            .Replace("XXXXX", "L")
            .Replace("LL", "C")
            .Replace("CCCCC", "G");
    }

    public static string Log(this string input, string message)
    {
        Console.WriteLine($"{message} {input}");
        return input;
    }
}
