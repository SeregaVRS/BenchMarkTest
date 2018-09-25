namespace BenchMarkTest
{
    using System;

    public class SortingAlgoritms
    {
        public void BubbleSort(int[] arrayForSort)
        {
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 1; i < arrayForSort.Length; i++)
                {
                    if (arrayForSort[i - 1].CompareTo(arrayForSort[i]) > 0)
                    {
                        this.Swap(arrayForSort, i - 1, i);
                        swapped = true;
                    }
                }
            }
            while (swapped);
        }


        public void InsertingSort(int[] items)
        {
            int sortedRangeEndIndex = 1;

            while (sortedRangeEndIndex < items.Length)
            {
                if (items[sortedRangeEndIndex].CompareTo(items[sortedRangeEndIndex - 1]) < 0)
                {
                    int insertIndex = this.FindInsertionIndex(items, items[sortedRangeEndIndex]);
                    this.InsertToArrayByIndexWithShift(items, insertIndex, sortedRangeEndIndex);
                }

                sortedRangeEndIndex++;
            }
        }

        private void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        private int FindInsertionIndex(int[] items, int valueToInsert)
        {
            for (int index = 0; index < items.Length; index++)
            {
                if (items[index].CompareTo(valueToInsert) > 0)
                {
                    return index;
                }
            }

            throw new InvalidOperationException("The insertion index was not found");
        }

        private void InsertToArrayByIndexWithShift(int[] itemArray, int indexInsertingAt, int indexInsertingFrom)
        {
            int temp = itemArray[indexInsertingAt];
            itemArray[indexInsertingAt] = itemArray[indexInsertingFrom];

            for (int current = indexInsertingFrom; current > indexInsertingAt; current--)
            {
                itemArray[current] = itemArray[current - 1];
            }

            itemArray[indexInsertingAt + 1] = temp;
        }
    }
}
