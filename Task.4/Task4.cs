using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._4
{
    class Task4
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter: ");
                string num1 = Console.ReadLine();

                for (int i = 0; i < num1.Length; i++)
                {
                    char c = num1[i];
                    if (!char.IsDigit(c) && c != '*')
                    {
                        throw new FormatException("The expression contains invalid characters!");
                    }
                }

                string[] parts = num1.Split('*');
                int res = 1;

                foreach (string part in parts)
                {
                    int num2 = int.Parse(part);
                    res *= num2;
                }
                Console.WriteLine($"Result: {res}");
            }
            catch (FormatException Fex)
            {
                Console.WriteLine(Fex.Message);
                throw;
            }
            catch (OverflowException) 
            {
                Console.WriteLine("Error! Expression without operators!");
            }
        }
    }
}
