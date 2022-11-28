/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными
числами. Напишите программу, которая покажет количество чётных чисел 
в массиве. [345, 897, 568, 234] -> 2*/

int[] GenerateRandomArray(int length,int start, int finish)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(start, finish);
    }
    return resultArray;
}
int GetPositiveNumbersArray (int [] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0)
        {
            number++;
        }
    }
    return number;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int[] array = GenerateRandomArray(10, 100, 1000);
printArray(array);
int number = GetPositiveNumbersArray(array);
Console.WriteLine($"В данном массиве {number} четных чисел.");
