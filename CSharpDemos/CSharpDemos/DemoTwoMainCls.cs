using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemos
{
    public class InheritanceMaincls
    {
        static void Main(string[] args)
        {
            int NumOne = 0;
            int NumTwo = 0;
            Console.WriteLine("Introduction To Inheritance in C#");
            Console.WriteLine("------------------------");
            Console.WriteLine("Enter the First Number");

            NumOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");

            NumTwo = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("------------------------");
            Console.WriteLine("Simple Calculator");
            Calc objCalc = new Calc();
            Console.WriteLine("Addition of 2 Nos :" + objCalc.Add(NumOne, NumTwo));
            Console.WriteLine("Substraction of 2 Nos :" + objCalc.Sub(NumOne, NumTwo));
            Console.WriteLine("Division of 2 Nos :" + objCalc.Div(NumOne, NumTwo));
            Console.WriteLine("Multiplication of 2 Nos :" + objCalc.Mul(NumOne, NumTwo));

            objCalc.Show();

            objCalc = null;

            Console.WriteLine("------------------------");
            Console.WriteLine("Scienctfic Calculator");

            Scienctficcalc objSciCalc = new Scienctficcalc();

            Console.WriteLine("Addition of 2 Nos :" + objSciCalc.Add(NumOne, NumTwo));
            Console.WriteLine("Substraction of 2 Nos :" + objSciCalc.Sub(NumOne, NumTwo));
            Console.WriteLine("Power of 2 Nos :" + objSciCalc.PowFn(NumOne,NumTwo));
            objSciCalc.Desc();

            Console.WriteLine("------------------------");
            Console.ReadLine();        
                
        }

    }

    public class Calc
    {
        # region Calc
        //public Calc()
        //{
        //    Console.WriteLine("I am Base Class");
        //}

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

        /// <summary>
        /// Can Be Inherited within the same assembly
        /// </summary>
        internal void Show()
        {
            Console.WriteLine("Can Perform Math Calculation");
        }

        /// <summary>
        /// Can Be Inherited by the Derived Class Only
        /// </summary>
        protected void Display()
        {
            Console.WriteLine("Can Perform Math Calculation");
        }
        # endregion Calc
    }

    /// <summary>
    /// Scienctficcalc Class Inherits Calc Class
    /// </summary>
    public class Scienctficcalc : Calc
    {
        # region Scienctficcalc
        //public Scienctficcalc() 
        //{
        //    Console.WriteLine("I am Sub Class");
        //}

        public Double Sqrt(Double Num)
        {
            return Math.Sqrt(Num);
        }

        public double SinFn(double Degree)
        {
            return Math.Sin(Degree);
        }

        public double CosFn(double Degree)
        {
            return Math.Cos(Degree);
        }
        public double TanFn(double Degree)
        {
            return Math.Tan(Degree);
        }

        public double PowFn(double x,double y)
        {
            return Math.Pow(x,y);
        }
        public int Mod(int x, int y)
        {
            return (x % y);
        }

        public void Desc()
        {
            Display();
        }
        # endregion Scienctficcalc
    }

}
