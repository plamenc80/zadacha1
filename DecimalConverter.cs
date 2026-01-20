
using System;
using System.Collections.Generic;
using System.Text;

namespace Number_System_Conversion_Calculator
{
    internal class DecimalConverter
    {
        int dec;

        public DecimalConverter()
        {
            while (true)
            {
                Console.WriteLine("Enter number:");
                string input = Console.ReadLine();

                bool isValid = true;
                foreach (char c in input)
                {
                    if (c < '0' || c > '9')
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    this.dec = int.Parse(input);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Only digits 0–9 are allowed.");
                }
            }
        }


        public string ToBin()
        {
            string ToBin = "";

            for (; dec > 0; dec /= 2)
            {
                ToBin = (dec % 2) + ToBin;

            }
            return ToBin;
        }

        public string ToOct()
        {
            string ToOct = "";

            for (; dec > 0; dec /= 8)
            {
                ToOct = (dec % 8) + ToOct;
            }
            return ToOct;
        }
        public string ToHex()
        {
            string ToHex = "";

            while (dec > 0)
            {
                int digit = dec % 16;
                switch (digit)
                {
                    case 10: ToHex = "A" + ToHex; break;
                    case 11: ToHex = "B" + ToHex; break;
                    case 12: ToHex = "C" + ToHex; break;
                    case 13: ToHex = "D" + ToHex; break;
                    case 14: ToHex = "E" + ToHex; break;
                    case 15: ToHex = "F" + ToHex; break;
                    default: ToHex = digit.ToString() + ToHex; break;
                }
                dec /= 16;
            }
            return ToHex;
        }
    }
}
