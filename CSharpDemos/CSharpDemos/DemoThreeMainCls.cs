using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemos
{
    public class ClassTypesMainCls
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduction To ClassTypes Demos");
            Console.WriteLine("------------------------");
            Console.WriteLine("This Is Concerte Class");

            ConcerteCls objConcerteCls = new ConcerteCls();
            objConcerteCls.ConcerteClsDesc();
            objConcerteCls.Display();
            objConcerteCls.AbstractClsDesc("ConcerteCls");
            objConcerteCls = null;

            Console.WriteLine("------------------------");
            Console.WriteLine("This Is Sealed Class");

            SealedCls objSealedCls = new SealedCls();
            objSealedCls.SealedClsDesc();
            Console.WriteLine("------------------------");            
            Console.ReadLine();
        }
    }

    public class ConcerteCls :AbstractCls
    {
        public void ConcerteClsDesc()
        {
            Console.WriteLine("I can be Instantiated and Inherited");
        }

        public override void Display()
        {
            Console.WriteLine("I am Display Method Implemented in ConcerteCls");
        }
    }

    sealed class SealedCls
    {
        public void SealedClsDesc()
        {
            Console.WriteLine("I can be Instantiated and but not Inherited");
        }
    }

    public abstract class AbstractCls
    {
        public void AbstractClsDesc(string ClassName)
        {
            Console.WriteLine("I am Abstract Class Method,Abstract Class can't be Instantiated and but Inherited.I am Invoked By " + ClassName + "");
        }
         public abstract void Display();
    }

    public class ClassTypes : AbstractCls
    {
        public override void Display()
        {
            Console.WriteLine("I am Display Method Implemented in ClassTypes");
        }
    }
    
}
