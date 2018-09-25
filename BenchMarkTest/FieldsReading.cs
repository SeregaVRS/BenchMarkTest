namespace BenchMarkTest
{
    using BenchmarkDotNet.Attributes;

    public class FieldsReading
    {
        private readonly string readonlyString = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private readonly int readonlyInt = int.MaxValue;

        private string simpleString = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private int simpleInt = int.MaxValue;

        [Benchmark]
        public string ReadonlyStringProcessing()
        {
            string resultSting = string.Empty;

            foreach (char t in this.readonlyString)
            {
                resultSting = resultSting + t;
            }

            return resultSting;
        }

        // Read 
        [Benchmark]
        public string SimpleStringProcessing()
        {
            string resultSting = string.Empty;

            foreach (char t in this.simpleString)
            {
                resultSting = resultSting + t;
            }

            return resultSting;
        }

        [Benchmark]
        public int ReadonlyIntProcessing()
        {
            int result = 0;

            for (int i = 0; i < 10000; i++)
            {
                result = this.readonlyInt - i;
            }

            return result;
        }

        // Read 
        [Benchmark]
        public int SimpleIntProcessing()
        {
            int result = 0;

            for (int i = 0; i < 10000; i++)
            {
                result = this.simpleInt - i;
            }

            return result;
        }
    }
}
