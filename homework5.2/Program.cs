﻿// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

Console.Write("Введите размер массива: ");
int arrayLength = int.Parse(Console.ReadLine()!);
int[] arrayOne = new int[arrayLength];

FillArray(arrayOne);
PrintArray(arrayOne);
Console.Write(OddSum(arrayOne));


void FillArray(int[] array)
{
    Random rand = new Random();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(0,100);
    }
}

int OddSum(int[] array)
{
    int sum = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] %2 != 0)
        sum = sum + array[i];
    }
    return sum;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}