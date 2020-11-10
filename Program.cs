using System;

namespace Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine(Converter(arg));
            }

            /// <summary>
            /// Converts a given cli argument from binary to it's decimal value
            /// </summary>
            static int Converter(string arg)
            {

                int sum = 0;
                int count = 0;

                foreach (char c in arg)
                {
                    count++;
                    int i = Convert.ToInt32(c.ToString());
                    switch (count)
                    {
                        case 1:
                            sum += i * 128;
                            break;
                        case 2:
                            sum += i * 64;
                            break;
                        case 3:
                            sum += i * 32;
                            break;
                        case 4:
                            sum += i * 16;
                            break;
                        case 5:
                            sum += i * 8;
                            break;
                        case 6:
                            sum += i * 4;
                            break;
                        case 7:
                            sum += i * 2;
                            break;
                        case 8:
                            sum += i * 1;
                            break;
                    }
                }
                return sum;

            }
        }
    }
}