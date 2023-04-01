//  50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();

Console.Write("Введите номер строки: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool isSetElementMatrix = IsSetElementMatrix(array2d, number1, number2);

if (isSetElementMatrix)
{
    int findElement = FindElement(array2d, number1, number2);
    Console.WriteLine($"Значение элемента -> {findElement}");
}
else
{
    Console.WriteLine($"{number1},{number2} -> такого элемента в массиве НЕТ!!!");
}


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("");
    }
}

bool IsSetElementMatrix(int[,] matrix, int num1, int num2)
{
    if (num1 <= 0 || num2 <= 0)
    {
        return false;
    }
    else if (num1 > matrix.GetLength(0))
    {
        return false;
    }
    else if (num2 > matrix.GetLength(1))
    {
        return false;
    }
    return true;
}

int FindElement(int[,] matrix, int row, int column)
{
    return matrix[row - 1, column - 1];
}
