using System;
using System.Collections.Generic;
using System.Text;

namespace Number_System_Conversion_Calculator
{
    internal class HexadecimalConvert
    {
        string hex;
        public HexadecimalConvert()
        {
            while (true)
            {
                Console.WriteLine("Enter number:");
                this.hex = Console.ReadLine();
                bool isValid = true;
                foreach (char c in hex)
                {
                    if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F')))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Only numbers from 0 to 9 and letters from A to F are allowed");
                }
            }
        }
        public int ToDec()
        {
            int ToDec = 0;
            int placeholder = 0;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                char bit = hex[i];
                int digit;
                if (bit >= '0' && bit <= '9')
                {
                    digit = bit - '0';
                }
                else
                {
                    digit = bit - 'A' + 10;
                }

                ToDec += digit * (int)Math.Pow(16, placeholder);
                placeholder++;
            }
            return ToDec;
        }

        public string ToBin()
        {
            int dec = ToDec();
            string ToBin = "";
            for (; dec > 0; dec /= 2)
            {
                ToBin = (dec % 2) + ToBin;
            }
            return ToBin;
        }
        public string ToOct()
        {
            int dec = ToDec();
            string ToOct = "";
            for (; dec > 0; dec /= 8)
            {
                ToOct = (dec % 8) + ToOct;
            }
            return ToOct;
        }

    }
}