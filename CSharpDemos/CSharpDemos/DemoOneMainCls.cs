using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemos
{
    public class MainCls
    {
        static void Main(string[] args)
        {
            int NumOne = 0;
            int NumTwo = 0;
            Console.WriteLine("Introduction To C# Demos");            
            Console.WriteLine("------------------------");
            Console.WriteLine("Enter the First Number");

            NumOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            NumTwo = Convert.ToInt32(Console.ReadLine());


            //Creating an Object for the Calledcls

            CalledCls ObjCalledCls = new CalledCls();

            Console.WriteLine("Addition of 2 Nos :"+ObjCalledCls.Add(NumOne,NumTwo));
            Console.WriteLine("Substraction of 2 Nos :" + ObjCalledCls.Sub(NumOne, NumTwo));
            Console.WriteLine("Division of 2 Nos :" + ObjCalledCls.Div(NumOne, NumTwo));
            Console.WriteLine("Multiplication of 2 Nos :" + ObjCalledCls.Mul(NumOne, NumTwo));

            Console.Read();

            ObjCalledCls.ProNumOne = NumOne;
            ObjCalledCls.ProNumTwo = NumTwo;

            Console.WriteLine("Num One is :"+ObjCalledCls.ProNumOne);
            Console.WriteLine("Num Two is :" + ObjCalledCls.ProNumTwo);

            //CalledCls.Staticmethod();

            Console.WriteLine("------------------------");        
            Console.Read();            
        }
    }

    public class CalledCls
    {
        /// <summary>
        /// Constructor for CalledCls
        /// </summary>
        public CalledCls()
        {
            Console.WriteLine("Constructor Invoked");
        }

        /// <summary>
        /// Constructor for CalledCls
        /// </summary>
        ~ CalledCls()
        {
            Console.WriteLine("Destructor Invoked");
            Console.WriteLine("Local Value of NumOne :" + Numone);
            Console.WriteLine("Local Value of NumTwo:" + Numtwo);         
            Console.ReadLine();
        }
        /// <summary>
        /// Addition Method
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
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

        public static void Staticmethod()
        {
            Console.WriteLine("I am a Static Method");            

        }

        private int Numone=0;
        private int Numtwo=0;

        public int ProNumOne
        {
            get { return Numone; }
            set { Numone = value; }
        }

        public int ProNumTwo
        {
            get { return Numtwo; }
            set { Numtwo = value; }
        }       
    }
}
