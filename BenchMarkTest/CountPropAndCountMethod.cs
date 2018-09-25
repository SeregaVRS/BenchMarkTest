namespace BenchMarkTest
{
    using System.Collections.Generic;
    using System.Linq;

    using BenchmarkDotNet.Attributes;

    public class CountPropAndCountMethod
    {
        public List<int> DataList { get; }
        public Dictionary<int, int> DataDictionary { get; }

        public CountPropAndCountMethod()
        {
            this.DataList = new List<int>();
            this.FillListWithData();
            this.DataDictionary = new Dictionary<int, int>();
            this.FillDictionaryWithData();
        }

        private void FillListWithData()
        {
            for (int i = 0; i < 10000; i++)
            {
                this.DataList.Add(i);
            }
        }

        private void FillDictionaryWithData()
        {
            for (int i = 0; i < 10000; i++)
            {
                this.DataDictionary.Add(i, i);
            }
        }

        [Benchmark]
        public int ListCountProperty()
        {
            return this.DataList.Count;
        }

        [Benchmark]
        public int ListCountMethod()
        {
            return this.DataList.Count();
        }

        [Benchmark]
        public bool ListMoreThanZeroProperty()
        {
            return this.DataList.Count > 0;
        }

        [Benchmark]
        public bool ListAnyMethod()
        {
            return this.DataList.Any();
        }

        [Benchmark]
        public int DictionaryCountProperty()
        {
            return this.DataDictionary.Count;
        }

        [Benchmark]
        public int DictionaryCountMethod()
        {
            return this.DataDictionary.Count();
        }

        [Benchmark]
        public bool DictionaryMoreThanZeroProperty()
        {
            return this.DataDictionary.Count > 0;
        } 

        [Benchmark]
        public bool DictionaryAnyMethod()
        {
            return this.DataDictionary.Any();
        }
    }
}
