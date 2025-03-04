using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateExample
{  

    public delegate int Calulator(int a, int b);
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static int Div(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Calulator operation;
            operation = Add;
            Console.WriteLine(operation(10, 20));

            operation = Sub;
            Console.WriteLine(operation(10, 20));

            operation = Mul;        
            Console.WriteLine(operation(10, 20)); 
            
            operation = Div; 
            Console.WriteLine(operation(10, 20));

        }
    }
}
