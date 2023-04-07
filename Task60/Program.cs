// 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int rows = 2;
int columns = 2;
int depth = 2;
int minValue = 55;
int maxValue = 99;
int step = 3;

bool validateCube = ValidateCube(rows, columns, depth, minValue, maxValue, step);
if (validateCube)
{
    int[,,] cube = CreateCube(rows, columns, depth, minValue, step);
    PrintCubeArray(cube);
}
else
{
    Console.WriteLine("ОШИБКА! Измените вводные данные для соблюдения условий задачи");
}

int[,,] CreateCube(int rows, int columns, int depth, int minNumber, int step = 1)
{
    int[,,] cube = new int[rows, columns, depth];

    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                cube[i, j, k] = minNumber;
                minNumber += step;
            }
        }
    }
    return cube;
}

void PrintCubeArray(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            Console.WriteLine("");
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write($"{cube[i, j, k],4} ({i}, {j}, {k})");
            }
        }
        Console.Write("");
    }
}

bool ValidateCube(int rows, int columns, int depth, int minNumber, int maxNumber, int step = 1)
{
    int[,,] cube = new int[rows, columns, depth];
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                if (minNumber > maxNumber) {
                    return false;
                }
                minNumber += step;
            }
        }
    }
    return true;
}
