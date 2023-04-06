// 58. Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(matrix1);

Console.WriteLine();

int[,] matrix2 = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(matrix2);

bool isMatrixMatching = IsMatrixMatching(matrix1, matrix2);
if (isMatrixMatching)
{
    int[,] productMatrixes = ProductMatrixes(matrix1, matrix2);
    Console.WriteLine();
    PrintMatrix(productMatrixes);
}
else
{
    Console.WriteLine($"Ошибка. Количество строк матрицы 1 не совпадает с количеством столбцов матрицы 2");
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

bool IsMatrixMatching(int[,] matrixA, int[,] matrixB)
 {
    return matrixA.GetLength(0) == matrixB.GetLength(1);
}

int[,] ProductMatrixes(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}
