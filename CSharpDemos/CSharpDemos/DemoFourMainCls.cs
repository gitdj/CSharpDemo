using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemos
{
    public class InheritanceWithOverridingMainCls
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduction To Overriding Demos");
            Console.WriteLine("------------------------");

            ClsBase ObjClsBase = new ClsBase();
            ObjClsBase.Display();
            ObjClsBase = null;

            Console.WriteLine("------------------------");
            ClsDerived objClsDerived = new ClsDerived();
            objClsDerived.Display();
            objClsDerived.Print();
            objClsDerived = null;
            Console.WriteLine("------------------------");
            ObjClsBase = new ClsDerived();

            Console.WriteLine("------------------------");
            Console.WriteLine("Invoking Display Method Through Clsderived Object");
            ObjClsBase.Display();
                        
            Console.WriteLine("------------------------");            
            Console.WriteLine("Invoking Print Method Through Clsderived Object");
            ObjClsBase.Print();
            ObjClsBase = null;

            //objClsDerived = new ClsBase();
            Console.ReadLine();
        }
    }

    public class ClsBase  // mycalc
    {
        public void Display()
        {
            Console.WriteLine("I am Display Method Present in ClsBase");
        }

        public virtual void Print() //add 2 num
        {
            Console.WriteLine("I am Print Method Present in ClsBase");
        }

    }
    public class ClsDerived : ClsBase //scifi
    {
        public new void Display()
        {
            Console.WriteLine("I am Display Method Present in ClsDerived");
        }

        public override void Print() //add 
        {
            Console.WriteLine("I am Print Method Present in ClsDerived");

        }

        public void Test()
        {
            Console.WriteLine("I am Test method in Cls Derived");
        }
    }
    /// <summary>
    /// 
    /// </summary>

    public class DrawDemoWithVirtualKeyword
    {
        public static void Main()
        {
            DrawingObject[] dObj = new DrawingObject[4];

            dObj[0] = new Line();
            dObj[1] = new Circle();
            dObj[2] = new Square();
            dObj[3] = new DrawingObject();

            foreach (DrawingObject drawObj in dObj)
            {
                drawObj.Draw();
            }

            Console.ReadLine();
            //return 0;
        }
    }

    public class DrawingObject
    {
        public virtual void Draw()
        {
            Console.WriteLine("I'm just a generic drawing object.");
        }
    }

    public class Line : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Line.");
        }
    }

    public class Circle : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Circle.");
        }
    }

    public class Square : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Square.");
        }
    } 


}
