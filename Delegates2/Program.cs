using System;

namespace Delegates2
{
    delegate void MyFirstDelegate();
    
    public class Program
    {
        public static void Print() { Console.WriteLine("Shalom"); }
        public static void Print2() { Console.WriteLine("Another function called with same delegate"); }

        static MyFirstDelegate firstDelegate = Print;
        static MyFirstDelegate secondDelegate = Print2;
        static void Main(string[] args)
        {
            //firstDelegate();
            //secondDelegate();

            //firstDelegate = Print2;
            firstDelegate += Print2;
            firstDelegate += Print2;
            firstDelegate();

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            firstDelegate -= Print2;
            //firstDelegate += Print;
            //firstDelegate = null;

            firstDelegate();
        }
    }
}
