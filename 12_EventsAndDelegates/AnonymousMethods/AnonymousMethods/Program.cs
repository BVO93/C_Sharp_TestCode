using System;

namespace AnonymousMethods
{
    class Program
    {
        public delegate string GetTextDelegate(string name);



        static void Main(string[] args)
        {
            // Anonymous method
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return "Hello, " + name;
            };

            //expression Lambda 
            GetTextDelegate getHelloText = (string name) => { return "Hello " + name; };

            // Statement lambda
            GetTextDelegate getGoodbyText = (string name) => {
                return "Goodby" + name;
            };


            // Shorter expression lambda
            GetTextDelegate getWelcomeText = name => "Welcome, " + name;

            Console.WriteLine(getWelcomeText( "Bjorn"));
        }
    }
}
