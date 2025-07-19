using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using System.Numerics;

namespace Algorithms
{
    public class Numerics
    {
        public const double PI = 3.141592653589793238462643383279502884197;
        public const double Infinity = double.PositiveInfinity;
        public const double NegInfinity = double.NegativeInfinity;
        public const int nil = 0;
        public static int Hex(string a) => Convert.ToInt32(a, 16);
        public static int Octal(string a) => Convert.ToInt32(a, 8);
        public static int Bin(string a) => Convert.ToInt32(a, 2);
        public static double Add(double a, double b) => a + b;
        public static double Sub(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Div(double a, double b) => a / b;
        public static double Pow(double a, double b) => Math.Pow(a, b);
        public static double Cos(double a) => Math.Cos(a);
        public static double Sin(double a) => Math.Sin(a);
        public static double Tan(double a) => Math.Tan(a);
        public static double Sinh(double a) => Math.Sinh(a);
        public static double Abs(double a) => Math.Abs(a);
        public static double Sqrt(double a) => Math.Sqrt(a);
        public static double Cbrt(double a) => Math.Pow(a, 1.0 / 3.0);
        public static int Xor(int a, int b) => a ^ b;
        public static int Not(int a) => ~a;
        public static int And(int a, int b) => a & b;
        public static int Or(int a, int b) => a | b;
        public static int LShift(int a, int b) => a << b;
        public static int RShift(int a, int b) => a >> b;
        public static uint URShift(uint a, int b) => a >>> b;
        public static bool IsInf(double a) => double.IsInfinity(a);
        public static bool IsPositiveInfinity(double a) => double.IsPositiveInfinity(a);
        public static bool IsNegativeInfinity(double a) => double.IsNegativeInfinity(a);
        public static bool IsPositive(double a) => a > 0;
        public static bool IsNegative(double a) => a < 0;
        public static bool IsNotNegative(double a) => a >= 0;
        public static bool IsNotPositive(double a) => a <= 0;
        public static bool IsZero(double a) => a == 0;
        public static double ReturnDouble(double a) => a;
        public static int ReturnInt(int a) => a;
        public static float ReturnFloat(float a) => a;
        public static void AddAndPrint(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        public static void SubAndPrint(double a, double b)
        {
            Console.WriteLine(a - b);
        }

        public static void MultiplyAndPrint(double a, double b)
        {
            Console.WriteLine(a * b);
        }

        public static void DivAndPrint(double a, double b)
        {
            Console.WriteLine(a / b);
        }
        public static void PowAndPrint(double a, double b)
        {
            Console.WriteLine(Math.Pow(a, b));
        }
        public static void SqrtAndPrint(double a)
        {
            Console.WriteLine(Math.Sqrt(a));
        }
        public static void CbrtAndPrint(double a)
        {
            Console.WriteLine(Math.Pow(a, 1.0 / 3.0));
        }
    }
    public class Input
    {
        public static string Read() => Console.ReadLine()!;
        public static int ReadInt() => int.Parse(Console.ReadLine()!);
    }
    public class Output
    {
        public static void Print(object args)
        {
            Console.WriteLine(args);
        }
        public static void Clear()
        {
            Console.Clear();
        }
    }
    public class Objective
    {
        public const string undefined = null;
        public const string DefaultString = null;
        public const int DefaultInt = 0;
        public const bool DefaultBool = false;
        public const string DefaultValue = default;
        public static object Get(object value) => value;
        public static void CheckNull(object v)
        {
            if (v != null)
            {
                Console.WriteLine($"Param input is safe. ({v})");
            }
            else
            {
                Console.WriteLine($"Param input is null. ({v})");
            }
        }
        public static void CheckType(object v)
        {
            if (v is string)
            {
                Console.WriteLine($"Param input is a string. ({v})");
            }
            else if (v is int)
            {
                Console.WriteLine($"Param input is an integer. ({v})");
            }
            else if (v is bool)
            {
                Console.WriteLine($"Param input is a boolean. ({v})");
            }
            else if (v is double)
            {
                Console.WriteLine($"Param input is a double. ({v})");
            }
            else if (v is float)
            {
                Console.WriteLine($"Param input is a float. ({v})");
            }
            else if (v is null)
            {
                Console.WriteLine($"Param input is null. ({v})");
            }
            else
            {
                Console.WriteLine($"Param input is object. (Object code: {v})");
            }
        }
    }
}                                                                                                            
