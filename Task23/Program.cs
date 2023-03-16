// 23. Напишите программу, которая 
// принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

TableCube(number);

void TableCube(int num)
{
    int count = 1;
    while (count <= number)
    {
        int result = count * count * count;
        Console.WriteLine($"{count, 3}  -> {result, 5}");
        count++;
    }
}
