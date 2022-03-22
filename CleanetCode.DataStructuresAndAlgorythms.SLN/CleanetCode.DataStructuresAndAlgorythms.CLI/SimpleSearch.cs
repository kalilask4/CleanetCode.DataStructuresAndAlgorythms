namespace CleanetCode.DataStructuresAndAlgorythms.CLI;

public class SimpleSearch
{
    /// <summary>
    /// Простой поиск
    /// </summary>
    /// <param name="array">Массив чисел</param>
    /// <param name="num">Число, которое нужно найти</param>
    /// <returns>Возвращает найденное число или 0, если число не найдено</returns>
    public int? Search (int[] array, int num)
    {
        foreach (var item in array)
        {
            if (item == num)
            {
                return item;
            }
        }

        return null;
    }
}