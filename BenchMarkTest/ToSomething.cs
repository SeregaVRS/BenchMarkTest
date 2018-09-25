namespace BenchMarkTest
{
    using System.Globalization;

    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Running;

    public class ToSomething
    {
        private readonly string input;

        public ToSomething()
        {
            this.input = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        }

        [Benchmark]
        public string ToLowerExtension() => input.ToLower();

        [Benchmark]
        public string ToLowerInvariantExtension() => input.ToLowerInvariant();

        [Benchmark]
        public string ToLowerCultureInfoInvariantCulture() => input.ToLower(CultureInfo.InvariantCulture);

        [Benchmark]
        public string ToUpperExtension() => input.ToUpper();

        [Benchmark]
        public string ToUpperInvariantExtension() => input.ToUpperInvariant();

        [Benchmark]
        public string ToUpperCultureInfoInvariantCulture() => input.ToUpper(CultureInfo.InvariantCulture);
    }
}
