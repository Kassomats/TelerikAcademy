using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                double input = double.Parse(Console.ReadLine());
                if (input < 0)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    input = Math.Sqrt(input);
                    Console.WriteLine("{0:F3}", input);
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
