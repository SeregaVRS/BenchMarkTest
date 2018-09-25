namespace DotNetInvestigation
{
    using System.Collections.Generic;
    
    public class CollectionsInvestigation
    {
        public void CreateListWithoutParametersCtor(List<int> inputList)
        {
            var resultList = new List<int>();
            // Exception Expected
            resultList[0] = 1;
        }

        public void CreateListWithCapacityCtor(List<int> inputList)
        {
            var resultList = new List<int>(inputList.Count);
            // Exception Expected
            resultList[0] = 1;
        }

        public void CreateListWithCollectionCtor(List<int> inputList)
        {
            var resultList = new List<int>(inputList);
            // Applicable - Init Capacity With Count
            resultList[0] = 1;
        }

        public List<int> MultiplyList(List<int> inputList)
        {
            //var resultList = new List<int>(inputList.Count);
            var resultList = new List<int>(inputList);
            
            for (int i = 0; i < inputList.Count; i++)
            {
                int resultAfterProcessing = 1;

                foreach (int inputListValue in inputList)
                {
                    if (i != inputList.IndexOf(inputListValue))
                    {
                        resultAfterProcessing *= inputListValue;
                    }
                }

                // resultList.Insert(i, resultAfterProcessing);
                resultList[i] = resultAfterProcessing;
            }

            return resultList;
        }
    }
}
