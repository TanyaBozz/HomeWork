// 33. Задайте массив. 
// Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

bool SearchNum(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }
    }
    return false;
}


int[] array = CreateArrayRndInt(10, -999, 999);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = SearchNum(array, number) == true ? " -> присутствует в массиве" : " -> отсутствует в массиве";
Console.WriteLine($"число {number} {result}");
