using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemos
{
    public class InterfaceMainCls
    {
        static void Main(string[] args)
        {
            ImplementInterface objImpIface = new ImplementInterface();
            objImpIface.Show();
            Console.ReadLine();

            objImpIface = new InheritsImplIface();

            objImpIface.Show();
            Console.WriteLine();
            objImpIface.Print();

            Console.ReadLine();
        }

       
    }

    public interface IInterface
    {
          void Show();
          void InterfaceDescription();
          void Print();
    }

    public class ImplementInterface : IInterface
    {
        public void Show()
        {
            Console.WriteLine("I am Show Method,implemented in the ImplementInterface");
            InterfaceDescription();
        }

        public  void InterfaceDescription()
        {
            Console.WriteLine("\r\nThe interface contains only member declarations. A class implementing an interface must provide the implementation of the interface members.");
        }

        public virtual void Print()
        {
            Console.WriteLine("I am Virtual Print Method");
        }
    }

    public class InheritsImplIface : ImplementInterface
    {
        public new void Show()
        {
            Console.WriteLine("I am Show Method,implemented in the InheritsImplIface");
            InterfaceDescription();
        }

        public new  void InterfaceDescription()
        {
            Console.WriteLine("\r\n Just Implemented in InheritsImplIface");
        }

        public override void Print()
        {
            Console.WriteLine("I am Override Print Method");
        }
    }
}
