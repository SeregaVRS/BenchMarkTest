namespace DotNetInvestigation
{
    using System;

    public class A
    {
        public void Say()
        {
            Console.WriteLine("Hi from A!");
        }
    }

    public class B : A
    {
        public void Say()
        {
            Console.WriteLine("Hi from B!");
        }
    }

    public class C : B
    {
        public void Say()
        {
            Console.WriteLine("Hi from C!");
        }
    }

    //public class Run
    //{
    //    public static void Main()
    //    {
    //        B b = new B();
    //        ((A)b).Say();
    //        C c = new C();
    //        ((A)c).Say();
    //        Console.ReadKey();
    //    }
    //}
}
