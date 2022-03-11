using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace CSharpDemos
{
    public class StreamsMainCls
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Writing data to a file");
            StreamWriter Objwriter = new StreamWriter(@"C:\Dany\DemoProjects\CSharpDemos\Files\CreateFile1.txt");
            Objwriter.WriteLine("...");
            Objwriter.WriteLine("Don't forget these numbers:");
            for (int i = 0; i < 10; i++)
                Objwriter.Write(i + " ");

            Objwriter.Write(Objwriter.NewLine);

            Objwriter.Close();

            Console.WriteLine("Wrote data");


            Console.WriteLine("Read data");
            StreamReader sr = new StreamReader(@"C:\Dany\DemoProjects\CSharpDemos\Files\CreateFile1.txt");
            string input = null;
            while ((input = sr.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }

            Console.WriteLine("Completed");

            Console.ReadLine();
        }
    }
}
