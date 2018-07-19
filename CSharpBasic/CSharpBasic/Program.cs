using System;

namespace CSharpBasic
{
    internal class Program
    {
        // Creation of an object for the Program class
        Program p = new Program();
        
        // Entry point of the program
        public static void Main(string[] args)
        {
            
            TestClass1 class1 = new TestClass1();
            
            class1.SetValue(20);
            class1.GetValue();
            class1.SetValue(50);
            
            TestClass1 class2 = new TestClass1();
            class2.SetValue(30);
            class2.GetValue();
            
            class1.GetValue();
            
            Console.Read();
        }
    }
}