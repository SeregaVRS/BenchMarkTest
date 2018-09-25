namespace DotNetInvestigation
{
    using System;

    public class SingletonPattern
    {
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        //static SingletonPattern()
        //{
        //}

        public static string S = Echo("Field initializer");

        public static string Echo(string s)
        {
            Console.WriteLine(s);
            return s;
        }
    }
}
