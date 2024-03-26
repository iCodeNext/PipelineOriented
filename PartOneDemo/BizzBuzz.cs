using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PartOneDemo;
public class BizzBuzzSimple
{
    public void Do(int number)
    {
        for (int i = 1; i < number; i++)
        {
            if (i % 15 == 0)
                Console.Write("Bizz, ");
            else if (i % 7 == 0)
                Console.Write("Buzz, ");
            else if (i % 3 == 0)
                Console.Write("Fizz, ");
            else Console.Write($"{i}, ");
        }
    }

    public void DoWithPipeline(int number)
    {
        for (int i = 1; i < number; i++)
        {
            new FizzBuzzStructure(i)
                  .AddStep(15, "Bizz")
                  .AddStep(7, "Buzz")
                  .AddStep(3, "Fizz")
                  .Handle();
        }
    }
}


public record FizzBuzzStructure(int Number, string Output = "");

public static class FizzBuzzStructureExtension
{
    public static FizzBuzzStructure AddStep(this FizzBuzzStructure structure, int divider, string output)
    {
        if (structure.Output != string.Empty)
            return structure;

        if (structure.Number % divider != 0)
            return structure;

        return structure with { Output = output };
    }

    public static void Handle(this FizzBuzzStructure structure)
    {
        if (structure.Output == string.Empty)
            Console.Write($"{structure.Number}, ");
        else Console.Write($"{structure.Output}, ");
    }
}