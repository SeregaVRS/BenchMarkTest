namespace LogicTasks
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            //var rentFor100Dollars = new RentFor100Dollars();
            //Console.WriteLine("List: ");
            //Console.WriteLine(rentFor100Dollars.ArrayAsString(rentFor100Dollars.Rent));

            //Console.WriteLine("Charge List: ");
            //Console.WriteLine(rentFor100Dollars.ArrayAsString(rentFor100Dollars.ChargeCoins));

            //Console.ReadLine();


            //List<int> input = new List<int> { 1, 7, 3, 4 };
            //Console.WriteLine("List: ");
            //Console.WriteLine(Program.ArrayAsString(input));

            //Console.WriteLine();
            //var arrayMultiple = new ArrayMultiple();
            //List<int> resultList = arrayMultiple.MultiplyList(input);

            //Console.WriteLine(Program.ArrayAsString(resultList));

            TryCatchFinallyExceptions catchFinallyExceptions = new TryCatchFinallyExceptions();

            var resultTryCatchFinally = catchFinallyExceptions.TryCatchFinally();
            Console.WriteLine("Method Result " + resultTryCatchFinally);
            Console.WriteLine();

            var resultTryCatchFinallyWithInt = catchFinallyExceptions.TryCatchFinally(999);
            Console.WriteLine("Method Result " + resultTryCatchFinallyWithInt);
            Console.WriteLine();

            var resultTryCatchFinallyWithString = catchFinallyExceptions.TryCatchFinally("Input String");
            Console.WriteLine("Method Result " + resultTryCatchFinallyWithString);
            Console.WriteLine();

            var resultTryCatchFinallyStatic = TryCatchFinallyStaticExceptions.TryCatchFinally();
            Console.WriteLine("Method Result " + resultTryCatchFinallyStatic);
            Console.WriteLine();

            Console.ReadKey();
        }

        public static string ArrayAsString(List<int> array)
        {
            var sb = new StringBuilder();
            foreach (int i in array)
            {
                sb.Append(i + ", ");
            }

            return sb.ToString();
        }

    }
}
