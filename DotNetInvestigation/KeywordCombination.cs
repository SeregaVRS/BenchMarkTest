namespace DotNetInvestigation
{
    using System;

    public class KeywordCombination
    {
        public KeywordCombination()
        {
            // default constructor
        }
    }

    public static class CheckStatic
    {
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }


        // Non static method in the static class - Impossible
        //public void NonStaticMethod()
        //{

        //}
    }



    public abstract class AbstractClassOne
    {
        // Abstract method cannot be virtual
        // public abstract virtual void VirtualAbstractMethod();

        public abstract void StaticAbstractMethod();
    }

    public abstract class AbstractClassTwo
    {
    }
}