namespace BenchMarkTest
{
    using BenchmarkDotNet.Attributes;

    public class ResultClass
    {
        private int listCount;

        private bool listComparison;

        private int dictCount;

        private bool dictComp;

        private int countForCast;

        public int ListCount
        {
            get
            {
                return this.listCount;
            }
            set
            {
                this.listCount = value;
            }
        }

        public bool ListComparison
        {
            get
            {
                return listComparison;
            }
            set
            {
                listComparison = value;
            }
        }

        public int DictCount
        {
            get
            {
                return dictCount;
            }
            set
            {
                dictCount = value;
            }
        }

        public bool DictComparison
        {
            get
            {
                return dictComp;
            }
            set
            {
                dictComp = value;
            }
        }

        public int CountForCast
        {
            get
            {
                return countForCast;
            }
            set
            {
                countForCast = value;
            }
        }
    }
    public class OptimizationPerformance
    {
        private CountPropAndCountMethod countPropAndCountMethod = new CountPropAndCountMethod();


        [Benchmark]
        public ResultClass OptimizedMethod()
        {
            return new ResultClass
                       {
                           ListCount = this.countPropAndCountMethod.ListCountProperty(),
                           ListComparison = this.countPropAndCountMethod.ListMoreThanZeroProperty(),
                           DictCount = this.countPropAndCountMethod.DictionaryCountProperty(),
                           DictComparison = this.countPropAndCountMethod.DictionaryMoreThanZeroProperty()
                       };

        }

        [Benchmark]
        public ResultClass NotOptimizedMethod()
        {
            return new ResultClass
                       {
                           ListCount = this.countPropAndCountMethod.ListCountMethod(),
                           ListComparison = this.countPropAndCountMethod.ListAnyMethod(),
                           DictCount = this.countPropAndCountMethod.DictionaryCountMethod(),
                           DictComparison = this.countPropAndCountMethod.DictionaryAnyMethod()
                       };
        }
    }
}
