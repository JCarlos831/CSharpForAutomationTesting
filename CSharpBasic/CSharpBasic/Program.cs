using System;

namespace CSharpBasic
{
    internal class Program
    {
        // Entry point of the program
        public static void Main(string[] args)
        {
            TestClass1 testClass = new TestClass1();
            
            int result = testClass.Add(12, 12);

            Console.WriteLine(result + 10);
            
            testClass.Add();
            
            Console.Read();
        }

        #region Old Code

        // Refactored from previous lessons
        private static void OldCode()
        {
            TestClass1 class1 = new TestClass1();

            // Implicit convertion
            Int16 salary = 32767;
            int salaryIncrement = 3276745;

            Console.WriteLine(salaryIncrement);

            // Instead of this
            var incomeTax = 23234.234d;

            Console.WriteLine(incomeTax.GetType().Name);

            // Explicit conversion
            Console.WriteLine((int) incomeTax);

            var loginPage = new LoginPage();

            loginPage.ClickButton();
        }

        #endregion

        public class LoginPage
        {
            public string UserName { get; set; }

            public void ClickButton()
            {
                
            }
        }

        public class UserListPage
        {
            public string ListOfUsers { get; set; }

            public void ClickButton()
            {
                
            }
        }
    }
}