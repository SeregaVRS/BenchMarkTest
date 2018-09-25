namespace LogicTasks
{
    using System.Collections.Generic;

    public class ArrayMultiple
    {
        public List<int> MultiplyList(List<int> inputList)
        {
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
