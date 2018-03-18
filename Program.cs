using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // signed - Signed integral: sbyte, short, int, long //
            // int
            Console.WriteLine("int Min Value: {0}", int.MinValue);
            Console.WriteLine("int Max Value: {0}", int.MaxValue);

            // short
            Console.WriteLine("short Min Value: {0}", short.MinValue);
            Console.WriteLine("short Max Value: {0}", short.MaxValue);

            // sbyte
            Console.WriteLine("sbyte MinValue: {0}", sbyte.MinValue);
            Console.WriteLine("sbyte MinValue: {0}", sbyte.MaxValue);

            // long
            Console.WriteLine("long MinValue: {0}", long.MinValue);
            Console.WriteLine("long MinValue: {0}", long.MaxValue);

            // Unsigned integral: byte, ushort, uint, ulong //
            // byte
            Console.WriteLine("byte Min Value: {0}", byte.MinValue);
            Console.WriteLine("byte Max Value: {0}", byte.MaxValue);

            // ushort
            Console.WriteLine("ushort Min Value: {0}", ushort.MinValue);
            Console.WriteLine("ushort Max Value: {0}", ushort.MaxValue);

            // uint
            Console.WriteLine("uint MinValue: {0}", uint.MinValue);
            Console.WriteLine("uint MinValue: {0}", uint.MaxValue);

            // ulong
            Console.WriteLine("ulong MinValue: {0}", ulong.MinValue);
            Console.WriteLine("ulong MinValue: {0}", ulong.MaxValue);

            // Unicode characters: char
            Console.WriteLine("abcdefghijklmnopqrstuvwxyz1234567890,./';[]-=\\`~!@#$%^&*()_+|}{:\"?><~");

            // IEEE floating point: float, double
            // float
            Console.WriteLine("float MinValue: {0}", float.MinValue);
            Console.WriteLine("float MinValue: {0}", float.MaxValue);


            // double
            Console.WriteLine("double MinValue: {0}", double.MinValue);
            Console.WriteLine("double MinValue: {0}", double.MaxValue);

            //High-precision decimal: decimal
            Console.WriteLine("decimal MinValue: {0}", decimal.MinValue);
            Console.WriteLine("decimal MinValue: {0}", decimal.MaxValue);

            // bool
            bool cool = false;
            bool? nullCool = null;

            if (!cool)
                Console.WriteLine("bool not cool.");
            else
                Console.WriteLine("bool cool.");

            if (nullCool == null)
                Console.WriteLine("cool to be null");
            else if (nullCool == true)
                Console.WriteLine("null to be true");
            else if (nullCool == false)
                Console.WriteLine("null to be false");

            // coalesce a null value with ?? <<default value>>
            Console.WriteLine("nullCool {0}", nullCool ?? false);


            // escape characters
            /*
            \' – single quote, needed for character literals
            \" – double quote, needed for string literals
            \\ – backslash
            */
            Console.WriteLine("\'insert sql\' \"C:\\path\\\"");
            /*
            \0 – Unicode character 0
            \a – Alert(character 7)
            \b – Backspace(character 8)
            \f – Form feed(character 12)
            \n – New line(character 10)
            \r – Carriage return (character 13)
            \t – Horizontal tab(character 9)
            \v – Vertical quote(character 11)
            */

            Console.WriteLine("\u1334");

            Console.WriteLine("\a");  // plays a ding sound;

            Console.WriteLine("1234567890 \n 44 \t tab");

            /*
            \uxxxx – Unicode escape sequence for character with hex value xxxx
            \xn[n][n][n] – Unicode escape sequence for character with hex value nnnn(variable length version of \uxxxx)
            \Uxxxxxxxx – Unicode escape sequence for character with hex value xxxxxxxx(for generating surrogate Of the..
             */


            int i = 1;
            float f = 1234.32F;
            // implicit convertion happens automaticly if there is no data loss

            f = i; // this works

            // explicit is to force the conversion
            f = 1234.32F;
            i = (int)f;
            // better to use:
            f = 1234.32F;
            i = Convert.ToInt32(f);  //this will throw an exception (int) will not.

            Console.WriteLine(i);

            // for converting strings you can use .Parse() and .TryParse()

            string strNumber = "444555";

            int ii = int.Parse(strNumber);

            Console.WriteLine(i);


            string tryParseStr = "444555";
            int intStr = 0;

            if (int.TryParse(tryParseStr, out intStr))
                Console.WriteLine("try parse did work: " + i);
            else
                Console.WriteLine("try Parse didn't work");



            Console.Read();
        }
    }
}
