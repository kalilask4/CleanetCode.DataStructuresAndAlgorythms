namespace CleanetCode.DataStructuresAndAlgorythms.CLI;

public class BinarySearch
{
    /// <summary>
    /// Бинарный поиск.
    /// </summary>
    /// <param name="array">Массив чисел</param>
    /// <param name="num">Число, которое нужно найти</param>
    /// <returns>Возвращвет найденное число или 0 если число не найдено</returns>
    public int? Search(int[] array, int num)
    {
        int low = 0;
        int high = array.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int guess = array[mid];
            if (guess == num)
            {
                return guess;
            }
            else if (guess > num)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return null;
    }
}