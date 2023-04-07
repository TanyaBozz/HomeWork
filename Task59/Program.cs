// 59. Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

int[,] array2d = CreateMatrixRndInt(4, 5, -10, 10);
PrintMatrix(array2d);

Console.WriteLine();

int[] coords = CoordinatesMinimumValue(array2d);
Console.WriteLine($"{coords[0]} --- {coords[1]}");

int[,] newMatrix = NewMatrix(array2d, coords);

Console.WriteLine();

PrintMatrix(newMatrix);


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
        Console.Write($"{i}->");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("");
    }
}

int[] CoordinatesMinimumValue(int[,] matrix)
{
    int minIndexRow = 0;
    int minIndexColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minIndexRow, minIndexColumn])
            {
                minIndexRow = i;
                minIndexColumn = j;
            }
        }
    }
    return new int[] { minIndexRow, minIndexColumn };
}

int[,] NewMatrix(int[,] matrix, int[] coords)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0, row = 0; i < matrix.GetLength(0); i++)
    {
        if (i == coords[0]) continue;
        
        for (int j = 0, column = 0; j < matrix.GetLength(1); j++)
        {
            if (j == coords[1]) continue;

            newMatrix[row, column] = matrix[i, j];
            
            column++;
        }
        row++;
    }
    return newMatrix;
}
