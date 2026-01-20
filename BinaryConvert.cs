using System;
using System.Collections.Generic;
using System.Text;

namespace Number_System_Conversion_Calculator
{
    internal class BinaryConvert
    {
        string binary;


        public BinaryConvert()
        {
            while (true)
            {

                Console.Write("Enter number: ");
                this.binary = Console.ReadLine();

                bool isValid = true;
                foreach (char c in binary)
                {
                    if (c != '0' && c != '1')
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
                    Console.WriteLine("Invalid input! Only 0 and 1 are allowed.");
                }

            }
        }

        public int ToDec()
        {
            int ToDec = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                int bit = binary[binary.Length - 1 - i] - '0';


                ToDec += bit * (int)Math.Pow(2, i);
            }
            return ToDec;
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