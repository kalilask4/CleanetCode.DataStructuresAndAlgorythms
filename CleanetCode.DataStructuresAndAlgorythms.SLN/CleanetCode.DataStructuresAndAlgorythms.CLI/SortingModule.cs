namespace CleanetCode.DataStructuresAndAlgorythms.CLI;

public class SortingModule
{ 
    public static int[] BubbleSort(int[] numbers)
    {
        for (int i = 1; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    Swap(ref numbers[j], ref numbers[j + 1]);
                }
            }
        }

        return numbers;
    }

    public static int[] QuickSort(int[] numbers)
    {
        static int Partition(int[] numbers, int minIndex, int maxIndex)
        {
            int pivot = numbers[minIndex];

            while (true)
            {
                while (numbers[minIndex] < pivot)
                {
                    minIndex++;
                }

                while (numbers[maxIndex] > pivot)
                {
                    maxIndex--;
                }

                if (minIndex < maxIndex)
                {
                    Swap(ref numbers[minIndex], ref numbers[maxIndex]);
                }
                else
                {
                    return maxIndex;
                }
            }
        }

        int[] QuickSortImpl(int[] unsortedNumbers, int minIndex, int maxIndex)
        {
            if (minIndex < maxIndex)
            {
                var pivot = Partition(unsortedNumbers, minIndex, maxIndex);

                if (pivot > 1)
                {
                    QuickSortImpl(unsortedNumbers, minIndex, pivot - 1);
                }

                if (pivot + 1 < maxIndex)
                {
                    QuickSortImpl(unsortedNumbers, pivot + 1, maxIndex);
                }
            }

            return unsortedNumbers;
        }

        int[] result = new int[numbers.Length];
        Array.Copy(numbers, result, numbers.Length);

        result = QuickSortImpl(result, 0, result.Length - 1);
        return result;
    }

    private static void Swap(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }
}