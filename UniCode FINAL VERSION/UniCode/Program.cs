using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// I didn't get it to convert a character into utf 8
/// This converts the utf 8 encoding into the decimal unicode (utf 32)
/// </summary>
namespace UniCode
{
    class Program
    {
        static string OneByte(string byte1)
        {
            //removing lead 0
            byte1 = byte1.Remove(0,1);
            return byte1;
        }

        static string TwoByte(string byte1)
        {
            string tempByte = "";
            //removing leading 110
            byte1 = byte1.Remove(0, 3);
            for (int i = 0; i < 5; i++)
            {
                tempByte += byte1[i];
            }
            //removing leading 10
            byte1 = byte1.Remove(0, 7);
            tempByte += byte1;
            return tempByte;
        }

        static string ThreeByte(string byte1)
        {
            string tempByte = "";
            //removing leading 1110
            byte1 = byte1.Remove(0, 4);
            for (int i = 0; i < 4; i++)
            {
                tempByte += byte1[i];
            }
            //removing leading 10
            byte1 = byte1.Remove(0, 6);
            for(int i = 0; i < 6; i++)
            {
                tempByte += byte1[i];
            }
            //removing last leading 10
            byte1 = byte1.Remove(0, 8);
            tempByte += byte1;
            return tempByte;
        }

        static string FourByte(string byte1)
        {
            string tempByte = "";
            //removing leading 11110
            byte1 = byte1.Remove(0, 5);
            for (int i = 0; i < 3; i++)
            {
                tempByte += byte1[i];
            }
            //removing leading 10
            byte1 = byte1.Remove(0, 5);
            for (int i = 0; i < 6; i++)
            {
                tempByte += byte1[i];
            }
            //removing leading 10
            byte1 = byte1.Remove(0, 8);
            for (int i = 0; i < 6; i++)
            {
                tempByte += byte1[i];
            }
            //removing last leading 0
            byte1 = byte1.Remove(0, 8);
            for (int i = 0; i < 6; i++)
            {
                tempByte += byte1[i];
            }
            tempByte += byte1;
            return tempByte;
        }

        static void Main(string[] args)
        {
            string ex1 = "01111000", ex2 = "1101010010010", ex3 = "111010111011010110010111", ex4 = "11110101101101011000110010001000";
            
            int bin;
            string unicode; //hex value
            //decimal 

            //One byte UTF Encoding
            bin = Convert.ToInt32(OneByte(ex1), 2);
            unicode = bin.ToString("X");
            Console.WriteLine(ex1 + " - " + unicode + " " + bin);

            //Two byte encoding
            bin = Convert.ToInt32(TwoByte(ex2), 2);
            unicode = bin.ToString("X");
            Console.WriteLine(ex2 + " - " + unicode + " " + bin);

            //three byte
            bin = Convert.ToInt32(ThreeByte(ex3), 2);
            unicode = bin.ToString("X");
            Console.WriteLine(ex3 + " - " + unicode + " " + bin);

            //four byte
            bin = Convert.ToInt32(FourByte(ex4), 2);
            unicode = bin.ToString("X");
            Console.WriteLine(ex4 + " - " + unicode + " " + bin);


            //= Convert.ToInt32(OneByte(ex3), 2);
            //= bin.ToString("X");
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

//decimal Unicode = unicode;
//string unicode1 = Unicode.ToString("X");
//Console.WriteLine(unicode1);
//Console.ReadKey();
/*Console.WriteLine("Enter a character you would like the unicode version of:");
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
Console.ReadKey();*/
