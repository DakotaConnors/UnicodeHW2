using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character you would like the unicode version of:");
            TextReader TextIn = Console.In;
            char character = Convert.ToChar(TextIn.Read());
            int toDecimal = Convert.ToInt16(character);
            string unicode = toDecimal.ToString("X");
            for (int i = 0; i < 4; i++)
            {
                if (unicode.Count() < 4)
                {
                    string temp = unicode;
                    unicode = "0" + temp;
                }
            }
            unicode = "U+" + unicode;
            Console.WriteLine(unicode);
            Console.ReadKey();
        }
    }
}

//string Byte1 = "01010101";
//double Decimal1 = 0;
//for (int i = Byte1.Length; i > 0; i--)
//{
//    Console.WriteLine(Convert.ToInt16(Byte1[i - 1]) - 48 + " * ");
//    Decimal1 += ((Convert.ToInt16(Byte1[i - 1])) - 48) * (Math.Pow(2, (8 - i)));
//}
//Console.WriteLine(Decimal1);

//static string OneByte(string byte1)
//{
//    string unicodeString = "0" + byte1;
//    return unicodeString;
//}

//private string TwoBytes(string byte1)
//{
//    string unicodeString1 = "110";
//    for (int i = 0; i < 5; i++)
//    {
//        unicodeString1 += byte1[i];
//    }
//    unicodeString1 += "|01";
//    for (int i = 5; i < byte1.Count(); i++)
//    {
//        unicodeString1 += byte1[i];
//    }
//    return unicodeString1;
//}

//private void ThreeBytes()
//{

//}

//private void FourBytes()
//{

//}