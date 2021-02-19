using System;
using static System.Console;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number betwen 0 and 255: ");
            string input1 = ReadLine();
            Console.Write("Enter another number betwen 0 and 255: ");
            string input2 = ReadLine();
            try
            {
                byte number1 = byte.Parse(input1);
                byte number2 = byte.Parse(input2);

                byte result = (byte)(number1 / number2);
                WriteLine(result);
            }
            catch (FormatException ex)
            {
                WriteLine($"{ex.GetType().Name}: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                WriteLine($"{ex.GetType().Name}: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                WriteLine($"{ex.GetType().Name}: {ex.Message}");

            }
        }
    }
}
