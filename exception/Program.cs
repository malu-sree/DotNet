using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine("Enter the first number");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number");
                int num2 = int.Parse(Console.ReadLine());

                int reuslt = Division(num1, num2);
                Console.WriteLine("The result is {0}", reuslt);



            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This is the finally block");

            }
        }
        static int Division(int a, int b)
        {
            return a / b;


        }

    }
}
    
