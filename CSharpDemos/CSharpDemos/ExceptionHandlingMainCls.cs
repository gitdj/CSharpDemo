using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemos
{
    public class ExceptionHandlingMainCls
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator objCalc = new Calculator();
                int NumOne = 0;
                int NumTwo = 0;
                Console.WriteLine("Introduction To ExceptionHandling in C#");
                Console.WriteLine("------------------------");
                Console.WriteLine("Enter the First Number");

                NumOne = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Second Number");

                NumTwo = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("------------------------");
                Console.WriteLine("Simple Calculator");
                
                Console.WriteLine("Addition of 2 Nos :" + objCalc.Add(NumOne, NumTwo));
                Console.WriteLine("Substraction of 2 Nos :" + objCalc.Sub(NumOne, NumTwo));
                Console.WriteLine("Division of 2 Nos :" + objCalc.Div(NumOne, NumTwo));
                Console.WriteLine("Multiplication of 2 Nos :" + objCalc.Mul(NumOne, NumTwo));
                
                Console.WriteLine("Enter the a Number to find its Factorial");
                NumOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Factorial of Nos :" + objCalc.fact(NumOne));



            }
            catch (Exception ex)
            {
                Console.WriteLine("-------ErrorMsg---------");
                Console.WriteLine(ex.Message.ToString());
                Console.WriteLine("------------------------");

            }
            Console.ReadLine();
        }
    }
    public class Calculator
    {
        
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Div(int x, int y)
        {
            return x / y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

        public int fact(int x)
        {
            int factorial = 0;
            if (x <= 0)
            {
                throw new Exception("Factorial of Negative Number is not Allowed");
            }

            if (x == 1)
            {
                return 1;
            }
            else
            {
                factorial = x * fact(x - 1);
            }
            
            return factorial;
        }
    }
}
