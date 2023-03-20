// 29. Напишите программу, которая 
// задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}
void PrintArray(int[] array)
{
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == (array.Length - 1))
        {
            result = result + array[i];
        }
        else
        {
            result = result + array[i] + ", ";
        }
    }

    Console.Write(result + " -> [" + result + "]");
}

