namespace RichterExamples
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string str1 = new string(new[] { '1', '2', '3', '4', '5' });
            string str2 = new string(new[] { '1', '2', '3', '4', '5' });

            string str11 = "12345";
            string str22 = "12345";

            var equalsForObjects = new EqualsForObjects();

            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str2.GetHashCode());
            Console.WriteLine("Custom Equals - " + equalsForObjects.CustomEquals(str1, str2));
            Console.WriteLine("Default Equals - " + str1.Equals(str2));

            Console.WriteLine();

            Console.WriteLine(str11.GetHashCode());
            Console.WriteLine(str22.GetHashCode());
            Console.WriteLine("Custom Equals - " + equalsForObjects.CustomEquals(str11, str22));
            Console.WriteLine("Default Equals - " + str11.Equals(str22));

            Console.ReadKey();
        }
    }
}
