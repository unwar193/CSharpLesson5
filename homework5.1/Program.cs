/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.Clear();

Console.Write("Введите длину массива: ");
int arrLength = int.Parse(Console.ReadLine()!);
int[] array = new int[arrLength];

FillArray(array);
PrintArray(array);
Console.Write($"Количество четных чисел в массиве: {EvenCount(array)}");

void FillArray(int[] arr)
{
    for (int i = 0; i < arrLength; i++)
    {
        Random rand = new Random();
        arr[i] = rand.Next(100, 1000);
    }
}

int EvenCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        };       
    }
    return count;
}


void PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(arr[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}
