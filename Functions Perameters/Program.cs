using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Perameters
{
    internal class Program
    {

        static double num1;
        static double num2;


        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("please enter a number: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Addition(num1, num2);
            Subtraction(num1, num2);
            Multiplication(num1, num2);
            Division(num1, num2);
            Console.ReadKey();
        }

        static void Addition(double add1, double add2)
        {
            double sum = add1 + add2;
            Console.WriteLine($"{add1} + {add2} = {sum}");
            Console.WriteLine("");
        }
        static void Subtraction(double sub1, double sub2)
        {
            double difference = sub1 - sub2;
            Console.WriteLine($"{sub1} - {sub2} = {difference}");
            Console.WriteLine("");
        }
        static void Multiplication(double mult1, double mult2)
        {
            double multiplied = mult1 * mult2;
            Console.WriteLine($"{mult1} * {mult2} = {multiplied}");
            Console.WriteLine("");
        }
        static void Division(double div1, double div2)
        {
            double multiplied = div1 / div2;
            Console.WriteLine($"{div1} / {div2} = {multiplied}");
            Console.WriteLine("");
        }
    }
}
