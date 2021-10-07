using System;

namespace ReturningDelegates
{
    delegate void PrintSomthing();

    class Program
    {
        public static string Language { get; set; } = "en-US";
        static void PrintHello() { Console.WriteLine("Hello!!"); }
        static void PrintShalom() { Console.WriteLine("Shalom!!"); }

        public static PrintSomthing ReturnGreetingMethod(string language)
        {
            switch (language)
            {
                case "en-US":
                    return PrintHello;
                case "he-IL":
                    return PrintShalom;
                default:
                    return null;
            }
        }

        static void Main(string[] args)
        {
            //Take the language from the system
            //PrintSomthing greet = PrintHello; 
            PrintSomthing greet1 = ReturnGreetingMethod("en-US");

            greet1();
        }
    }
}
