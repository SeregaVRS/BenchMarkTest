namespace BenchMarkTest
{
    using System;
    using System.Text;

    using BenchmarkDotNet.Running;

    public class Program
    {
        private static readonly int Size = 10000;
        private static int[] array = new int[Size];
        public static void Main(string[] args)
        {
            // var summary = BenchmarkRunner.Run<CLASSNAME>();
            // var summary = BenchmarkRunner.Run<CreateInstanceVsNew>();
            // var summary = BenchmarkRunner.Run<Md5VsSha256>();
            // var summary = BenchmarkRunner.Run<ToSomething>();
            // var summary = BenchmarkRunner.Run<FieldsReading>();
            // var summary = BenchmarkRunner.Run<CountPropAndCountMethod>();
            // var summary = BenchmarkRunner.Run<CastVsAs>();
            // var summary = BenchmarkRunner.Run<OptimizationPerformance>();


            Console.WriteLine($"First Value Less Than Second (1 and 200): {Program.CompareToExplore(1, 200)}");
            Console.WriteLine($"First Value Equal with Second (1 and 1): {Program.CompareToExplore(1, 1)}");
            Console.WriteLine($"First Value Greater Than Second (200 and 1): {Program.CompareToExplore(200, 1)}");

            Program.FillArrayWithRandomNunbers(array);
            Console.WriteLine("Input Array:");

            Console.WriteLine(Program.ShowArrayAsString(array));
            Console.WriteLine();
            

            var sa = new SortingAlgoritms();
            sa.BubbleSort(array);

            Console.WriteLine("Sorted Array (Bubble)");
            Console.WriteLine(Program.ShowArrayAsString(array));
            Console.ReadLine();
        }

        private static void FillArrayWithRandomNunbers(int[] arrayForFill)
        {
            var random = new Random();

            for (int i = 0; i < arrayForFill.Length; i++)
            {
                arrayForFill[i] = random.Next(1, 1000);
            }
        }

        private static string ShowArrayAsString(int[] array)
        {
            var sb = new StringBuilder();
            foreach (int i in array)
            {
                sb.Append(i + ", ");
            }

            return sb.ToString();
        }

        private static int CompareToExplore(int firstValue, int secondValue)
        {
            return firstValue.CompareTo(secondValue);
        }
    }
}
