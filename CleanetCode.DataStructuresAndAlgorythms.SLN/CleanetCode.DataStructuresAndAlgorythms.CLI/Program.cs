using System.Diagnostics;
using CleanetCode.DataStructuresAndAlgorythms.CLI;

List<int> listOfNumbers = new List<int> { 1, 2, 3, 4 };
listOfNumbers.Add(10);
listOfNumbers.Prepend(10);
listOfNumbers.Append(10);
listOfNumbers.Insert(3, 10);
listOfNumbers.Remove(2);
listOfNumbers.Sort();
foreach (var number in listOfNumbers)
{
    Console.Write(number);
}

Console.WriteLine();

Queue<int> queueOfNumbers = new Queue<int>();
queueOfNumbers.Enqueue(1);
queueOfNumbers.Enqueue(2);
queueOfNumbers.Enqueue(3);
queueOfNumbers.Enqueue(4);
queueOfNumbers.Dequeue();
queueOfNumbers.Dequeue();
foreach (var number in queueOfNumbers)
{
    Console.Write(number);
}

Console.WriteLine();

Stack<int> stackOfNumbers = new Stack<int>();
stackOfNumbers.Push(1);
stackOfNumbers.Push(2);
stackOfNumbers.Push(3);
stackOfNumbers.Push(4);
stackOfNumbers.Pop();
stackOfNumbers.Pop();
foreach (var number in stackOfNumbers)
{
    Console.Write(number);
}

Console.WriteLine();

HashSet<int> setOfNumbers = new HashSet<int> { 1, 2, 4, 5, 5 };
setOfNumbers.Add(2);
setOfNumbers.Add(10);
setOfNumbers.Add(22);
setOfNumbers.Remove(24);
setOfNumbers.Remove(22);
foreach (var number in setOfNumbers)
{
    Console.Write(number);
}

Console.WriteLine();

Dictionary<int, string> map = new Dictionary<int, string>
{
    { 1, "test" },
    { 2, "test1" },
    { 3, "test2" },
    { 4, "test3" },
    { 5, "test4" },
};
foreach (var number in map)
{
    Console.Write(number);
}

Console.WriteLine();

map.Add(13, "eexfertgs");
map.Remove(3);
string value = map[13];
Console.WriteLine(value);

int[] numbers = { 6, 7, 8, 3, 5, 2, 1, 4 };
int[] orderedNumbers = SortingModule.QuickSort(numbers);

foreach (var number in orderedNumbers)
{
    Console.Write(number);
}

Console.WriteLine();

Stopwatch stopwatch = new Stopwatch();

#region Простой поиск

int[] orderedNubers2 = new int[]
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31,
    32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
    61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 
    90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114,
    115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 
    138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 
    161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183,
    184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200,
};
stopwatch.Start();
SimpleSearch simpleSearch = new SimpleSearch();
Console.WriteLine(simpleSearch.Search(orderedNubers2, 107));
stopwatch.Stop();
Console.WriteLine($"Время выполнения \"простого\" поиска: {stopwatch.Elapsed}");
stopwatch.Reset();
#endregion

#region Бинарный поиск
stopwatch.Start();
BinarySearch binarySearch = new BinarySearch();
Console.WriteLine(binarySearch.Search(orderedNubers2, 107));
stopwatch.Stop();
Console.WriteLine(
    $"Время выполнения бинарного поиска: {stopwatch.Elapsed}");
stopwatch.Reset();

#endregion