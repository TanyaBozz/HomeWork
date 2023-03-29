// 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] arr = CreateArrayRndDouble(5, -100, 100);
PrintArray(arr);

double maxNum = FindMax(arr);
double minNum = FindMin(arr);
double result = DiffNum(maxNum, minNum);

Console.WriteLine($" -> {result}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}  ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double FindMax(double[] arr)
{
    double maxNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNum)
        {
            maxNum = arr[i];
        }
    }
    return maxNum;
}

double FindMin(double[] arr)
{
    double minNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNum)
        {
            minNum = arr[i];
        }
    }
    return minNum;
}

double DiffNum(double maxNumber, double minNumber)
{
    double result = maxNumber - minNumber;
    return Math.Round(result, 1);
}
