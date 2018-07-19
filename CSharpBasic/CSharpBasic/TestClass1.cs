using System;

namespace CSharpBasic
{
    public class TestClass1
    {

        private int i = 0;

        public void SetValue(int value)
        {
            i = value;
        }

        public void GetValue()
        {
            Console.WriteLine("The value of i is: " + i);
        }

        public void TestCase1(string result)
        {
            Console.WriteLine("Executing Test Case 1 " + result);
        }
        
        public void TestCase2(string result)
        {
            Console.WriteLine("Executing Test Case 2 " + result);
        }
    }
}
