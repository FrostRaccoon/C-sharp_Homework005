/* Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int[] arr = GetRandomArray(10);
PrintArray(arr);
Console.WriteLine(GetDiff(arr));

int GetDiff(int[] array)
{
    int min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    
    int max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max - min;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}