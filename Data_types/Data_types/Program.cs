using System;

namespace Data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Notes about variuos data types

            //Signed integral types give us values of:
            Console.WriteLine("THIS ARE THE VALUE TYPES OF variables");
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            //Unsigned integral types give us just positive values (double te right side od signed values)
            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            /*Evaluate floating-point types
            First, you must also consider the digits of precision each allow. Precision is the number of values that can be stored after
            the decimal point.

             Second, you must consider the manner in which the values are stored and the impact that has on the accuracy of the value. 
            In other words, float and double values are stored internally in a binary (base 2) format while decimal is stored in a 
            decimal (base 10) format. 

             Performing math on binary floating-point values can produce results that may surprise you. Often, binary floating-point math is an 
            approximation of the real value. Therefore, float and double are useful because large numbers can be stored using a small memory 
            footprint, however should only be used when an approximation is useful. 

            You should use decimal when working with financial data or any scenario where you need an accurate result from a calculation.*/
            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");



            Console.WriteLine("THIS ARE THE REFERENCE TYPES OF variables: matrices, vector datas,...");
            int[] data;   //null reference
            data = new int[3];

            /*The new keyword tells the .NET Runtime to create an instance of int array then coordinate with the operating system 
             * to store it in memory. The .NET Runtime complies and returns a memory address of the new int array. Finally, 
             * the memory address is stored in the variable data. The int array's elements default to the value 0 since that is the 
             * default value of an int.*/

        }
    }
}
