namespace DotNetInvestigation
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Starting Main...");

            Console.WriteLine("Try Call CreateListWithoutParametersCtor()");
            try
            {
                CreateListWithoutParametersCtor();
                Console.WriteLine("1. All Fine - No Exception");
            }
            catch (Exception e)
            {
                Console.WriteLine("1. Exception in the CreateListWithoutParametersCtor " + e);
            }

            Console.WriteLine("Try Call CreateListWithCapacityCtor");
            try
            {
                CreateListWithCapacityCtor(new List<int>(5));
                Console.WriteLine("2. All Fine - No Exception");

            }
            catch (Exception e)
            {
                Console.WriteLine("2. Exception in the CreateListWithCapacityCtor " + e);
            }

            Console.WriteLine("Try Call CreateListWithCollectionCtor");
            try
            {
                //Init Capacity With Count
                CreateListWithCollectionCtor(new List<int>(5) { 1, 2, 3, 4, 5 });
                Console.WriteLine("3. All Fine - No Exception");
            }
            catch (Exception e)
            {
                Console.WriteLine("3. Exception in the CreateListWithCollectionCtor " + e);
            }

            Console.ReadLine();
        }

        public static void CreateListWithoutParametersCtor()
        {
            var resultList = new List<int>();
            // Exception Expected
            resultList[0] = 1;
        }

        public static void CreateListWithCapacityCtor(List<int> inputList)
        {
            var resultList = new List<int>(inputList.Count);
            // Exception Expected
            resultList[0] = 1;
        }

        public static void CreateListWithCollectionCtor(List<int> inputList)
        {
            var resultList = new List<int>(inputList);
            // Applicable - Init Capacity With Count
            resultList[0] = 1;
        }
    }
}
