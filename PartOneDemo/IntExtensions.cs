using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PartOneDemo;
public static class IntExtensions
{
    public static int Add1(this int x) => x + 1;
    public static int Square(this int x) => x * x;
    public static int Double(this int x) => x * 2;
}
