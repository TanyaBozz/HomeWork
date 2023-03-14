// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое целое положительное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое положительное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainderDivision = RemainderDivision(number1, number2);

// Console.WriteLine(remainderDivision == 0 ? "кратно" : $"не кратно, остаток {remainderDivision}")

if (remainderDivision != 0)
{
    Console.WriteLine($"{number1}, {number2} -> не кратно, остаток {remainderDivision}");
}
else
{
    Console.WriteLine($"{number1}, {number2} -> кратно");
}


int RemainderDivision(int firstNum, int secondNum)
{
     return firstNum % secondNum;
}


