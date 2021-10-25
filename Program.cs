using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRS_1
{
    class Program
    {
        static void Main(string[] args)
        {
                  // Presents first and second EXS //
            //Oleg Braylovskiy
            //Hady Abo Jaffar

            int num, tmp, Rbinary = 0, binary = 0, Base;
            Console.WriteLine("Enter a decimal number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Select a base you want for a number");
            Base = int.Parse(Console.ReadLine());
            tmp = num;
            if (num == 0)
                Console.WriteLine("\nDecimal= 0  Binary= 0");
            else
            {
                while (tmp > 0)
                {
                    if (tmp % Base == 0)
                        Rbinary *= 10;
                    else Rbinary = Rbinary * 10 + tmp % Base;
                    tmp /= Base; 
                }
                while (Rbinary > 0) 
                {
                    binary = binary * 10 + Rbinary % 10;  
                    Rbinary /= 10; 
                }
                tmp = num;
                while (tmp % Base == 0) 
                {
                    binary *= 10; 
                    tmp /= Base; 
                }

                Console.WriteLine("\nDecimal= {0}  Base= {1}", num, binary);
            }
        }
    }
}

