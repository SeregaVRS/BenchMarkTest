namespace LogicTasks
{
    using System.Collections.Generic;
    using System.Text;

    public class RentFor100Dollars
    {
        public RentFor100Dollars()
        {
            this.Rent = this.GenerateListWithNumbers(99, 1);
        }

        public List<int> Rent { get; }

        public List<int> ChargeCoins { get; } = new List<int> { 1, 2, 5, 10, 25, 50 };

        public string ArrayAsString(List<int> array)
        {
            var sb = new StringBuilder();
            foreach (int i in array)
            {
                sb.Append(i + ", ");
            }

            return sb.ToString();
        }


        public List<int> MinCoinsCoutFor100DollarsRent()
        {
            var list = new List<int>(6) { 1, 1, 1, 1, 1, 1 };

            foreach (int charge in this.Rent)
            {
                int rentSum = 0;

                while (charge != rentSum)
                {
                    
                }
                
            }

            return list;
        }

        private List<int> GenerateListWithNumbers(int count, int step)
        {
            var result = new List<int>();

            for (int i = 1; i <= count; i=i+step)
            {
                result.Add(i);
            }

            return result;
        }
    }
}
