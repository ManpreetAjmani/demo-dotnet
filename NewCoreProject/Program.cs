using System;
using FirstLib;

namespace NewCoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var obj=new Calculator(2,1);
            System.Console.WriteLine(obj.add()); 
            System.Console.WriteLine(obj.sub());
            System.Console.WriteLine(obj.mul());
        }
    }
}
