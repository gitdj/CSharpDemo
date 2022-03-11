using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemos
{

    public delegate void MyEventDelegate(string Str);
    
    public class EventDelegatesMainCls
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduction To Events Using Delegates in C#");
            Console.WriteLine("------------------------");
            EventHandlerCls objEventHandlerCls = new EventHandlerCls();
            objEventHandlerCls.Message += new MyEventDelegate(EventHandlerCls.EventHandler_Message);
            
            objEventHandlerCls.Display();
            objEventHandlerCls.Print();
        }
    }

    public class EventHandlerCls
    { 
        public event MyEventDelegate Message;

       public static void EventHandler_Message(string str)
        {
            Console.WriteLine(str);
            Console.WriteLine("------------------------");
            Console.ReadLine();           
        }

        public void Display()
        {
            Console.WriteLine("I am Display Method");
            Message("Event Fired From Display Method");
        }

        public void Print()
        {        
         Console.WriteLine("I am Print Method");
         Message("Event Fired From Print Method");

        }
    }
}
