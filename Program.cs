
using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace Number_System_Conversion_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose input type: 1-bin , 2-octal, 3-dec, 4-hex:");
                int Choice = int.Parse(Console.ReadLine());
                if (Choice < 1 || Choice > 4)
                {
                    Console.WriteLine("Ivalid input!");
                }





                Console.WriteLine("Choose convertion: 1-bin , 2-octal, 3-dec, 4-hex:");
                int Convert = int.Parse(Console.ReadLine());
                if (Convert < 1 || Convert > 4)
                {
                    Console.WriteLine("Ivalid input!");
                }


                switch (Choice)
                {
                    case 1:
                        try
                        {
                            BinaryConvert bin = new BinaryConvert();
                            switch (Convert)
                            {

                                case 1: throw new Exception("Cannot convert binary to binary");
                                case 2: Console.WriteLine($"Result:{bin.ToOct()}"); break;
                                case 3: Console.WriteLine($"Result:{bin.ToDec()}"); break;
                                case 4: Console.WriteLine($"Result:{bin.ToHex()}"); break;
                                default: Console.WriteLine($"Ivalid choice."); break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"There was an error:{ex.Message}");
                        }
                        break;

                    case 2:
                        try
                        {
                            OctalConvert oct = new OctalConvert();
                            switch (Convert)
                            {
                                case 1: Console.WriteLine($"Result:{oct.ToBin()}"); break;
                                case 2: throw new Exception("Cannot convert octal to octal");
                                case 3: Console.WriteLine($"Result:{oct.ToDec()}"); break;
                                case 4: Console.WriteLine($"Result:{oct.ToHex()}"); break;
                                default: Console.WriteLine($"Invalid choice"); break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"There was an error:{ex.Message}");
                        }
                        break;
                    case 3:
                        try
                        {
                            DecimalConverter dec = new DecimalConverter();
                            switch (Convert)
                            {
                                case 1: Console.WriteLine($"Result:{dec.ToBin()}"); break;
                                case 2: Console.WriteLine($"Result:{dec.ToOct()}"); break;
                                case 3: throw new Exception("Cannot convert decimal to decimal");
                                case 4: Console.WriteLine($"Result:{dec.ToHex()}"); break;
                                default: Console.WriteLine($"Invalid choice"); break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"There was an error:{ex.Message}");
                        }
                        break;
                    case 4:
                        try
                        {
                            HexadecimalConvert hex = new HexadecimalConvert();
                            switch (Convert)
                            {
                                case 1: Console.WriteLine($"Result:{hex.ToBin()}"); break;
                                case 2: Console.WriteLine($"Result:{hex.ToOct()}"); break;
                                case 3: Console.WriteLine($"Result:{hex.ToDec()}"); break;
                                case 4: throw new Exception("Cannot convert hexadecimal to hexadecimal");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"There was an error:{ex.Message}");
                        }
                        break;
                }





            }
        }
    }
}
