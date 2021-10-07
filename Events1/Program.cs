using System;

namespace Events1
{
    //Declaration
    delegate void SimpleDelegate();

    class Program
    {
        static void Print() { Console.WriteLine("Event was raized and I am the called method\n \n Number was entered!!!!!"); }
        static void Main(string[] args)
        {

            NumberWasEntered = Print; // Instantiation

            Console.WriteLine("Enter a string:");
            var str = Console.ReadLine();

            foreach (var ch in str)
            {
                if (ch >= '0' && ch <= '9')
                {
                    //Raiz NumberWasEntered event
                    if (NumberWasEntered is not null)
                        NumberWasEntered(); //Invocation
                }
            }
        }

        public static event SimpleDelegate NumberWasEntered;



    }
}
