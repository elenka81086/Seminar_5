/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
3 7 22 2 78] -> 76*/


double[] GenerateRandomArray(int length,int start, int finish)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(start, finish);
    }
    return resultArray;
}

double getMaxNumberInArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double getMinNumberInArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min= array[i];
        }
    }
    return min;
}

double differenceBetweenMaxEndMin (double max, double min)
{
   double result = max - min;
   return result;
}
void printArray(double[] array)
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
double[] array = GenerateRandomArray(5, -10, 10);
printArray(array);
double MaxNumber = getMaxNumberInArray(array);
double MinNumber = getMinNumberInArray(array);
double difference = differenceBetweenMaxEndMin(MaxNumber, MinNumber);
Console.WriteLine($"Разница между числом {MaxNumber} и числом {MinNumber} составила {difference}");

