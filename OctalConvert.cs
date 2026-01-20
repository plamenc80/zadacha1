using System;
using System.Collections.Generic;
using System.Text;

namespace Number_System_Conversion_Calculator
{
    internal class OctalConvert
    {
        string octal;

        public OctalConvert()
        {
            while (true)
            {
                Console.WriteLine("Enter number:");
                this.octal = Console.ReadLine();
                bool isValid = true;
                foreach (char c in octal)
                {
                    if (c < '0' || c > '7')
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
                    Console.WriteLine("Invalid input! Only 1 to 7 are allowed.");
                }
            }

        }
        public int ToDec()
        {
            int ToDec = 0;
            int placeholder = 0;
            for (int i = octal.Length - 1; i >= 0; i--)
            {
                char bit = octal[i];
                int digit = bit - '0';

                ToDec += digit * (int)Math.Pow(8, placeholder);

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
        public string ToHex()
        {
            string ToHex = "";
            int number = ToDec();
            while (number > 0)
            {
                int digit = number % 16;
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
                number /= 16;
            }
            return ToHex;
        }
    }
}