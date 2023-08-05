using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class ComplexTest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the real part of complex number x:");
            double realpart = double.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary part of complex number x:");
            double imaginarypart = double.Parse(Console.ReadLine());
            var x = new Class.ComplexNumber(realpart, imaginarypart);

            Console.Write("\nEnter the real part of complex number y:");
            realpart = double.Parse(Console.ReadLine());
            Console.Write("Enter the imaginary part of complex number y:");
            imaginarypart = double.Parse(Console.ReadLine());
            var y = new Class.ComplexNumber(realpart, imaginarypart);

            Console.WriteLine();
            Console.WriteLine($"{x}+{y}={x + y}");
            Console.WriteLine($"{x}-{y}={x - y}");
            Console.WriteLine($"{x}*{y}={x * y}");
            Console.ReadLine();
        }
    }
}
