using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemos
{
    public class DelegateMainCls
    {
        static void Main(string[] args)
        {
            int NumOne = 0;
            int NumTwo = 0;
            Delegatecls ObjDelegatecls = new Delegatecls();

            Console.WriteLine("Introduction To Delegates in C#");
            Console.WriteLine("Enter the First Number");

            NumOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            NumTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------------------");
            Console.WriteLine("Delegates With Return Type");

            MyReturnDelegate ObjMyDelegate = ObjDelegatecls.Add;

            ObjMyDelegate += ObjDelegatecls.Sub;

            int x = ObjMyDelegate(NumOne, NumTwo);

            Console.WriteLine("Values Returned From MyDelegate :" + x);
            Console.WriteLine("------------------------");            
            Console.WriteLine("Delegates Without Return Type");

            MyVoidDelegate objMyVoidDelegate = ObjDelegatecls.VoidAdd;

            objMyVoidDelegate += ObjDelegatecls.VoidSub;
            objMyVoidDelegate += ObjDelegatecls.VoidDiv;

            objMyVoidDelegate(NumOne, NumTwo);

            Console.WriteLine("------------------------");

            Console.WriteLine("Removing VoidSub From MyVoidDelegate");
            objMyVoidDelegate -= ObjDelegatecls.VoidSub;

            Console.WriteLine("After Removal");
            objMyVoidDelegate(NumOne, NumTwo);
            Console.WriteLine("------------------------");
            Console.ReadLine();


        }

    }

    public delegate int MyReturnDelegate(int a, int b);
    public delegate void MyVoidDelegate(int a, int b);
    public class Delegatecls
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("Add Method Called");
            return a + b;
        }

        public int Sub(int a, int b)
        {
            Console.WriteLine("Sub Method Called");
            return a - b;
        }

        public void VoidAdd(int a, int b)
        {            
            Console.WriteLine("Addition Result :" +(a + b));
        }
        public void VoidSub(int a, int b)
        {
            Console.WriteLine("Substraction Result :" + (a - b));            
        }
        public void VoidDiv(int a, int b)
        {
            Console.WriteLine("Division Result :" + (a / b));

        }

    }
}
