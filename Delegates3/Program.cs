using System;


namespace Delegates3
{
    delegate void Greet(string name);
    class Program
    {
        static void Welcome(string name) { Console.WriteLine("Welcome "+name); }
        static void Shalom(string name) { Console.WriteLine("Shalom " + name); }

        static void Main(string[] args)
        {
            Greet greet1 = Welcome;
            Greet greet2 = Shalom;

            //Greet greet3 = Delegates2.Program.Print2;

            greet1("Shai");
            greet2("Shai");
            
        }
    }
}
