// 40. Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите значение длинны первой стороны треугольника: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение длинны второй стороны треугольника: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение длинны третей стороны треугольника: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTriangle(number1, number2, number3);

Console.WriteLine(result ? "Существует" : "Не существует");

bool IsExistTriangle(int numb1, int numb2, int numb3)
{
    return numb1 < numb2 + numb3 && numb2 < numb1 + numb3 && numb3 < numb1 + numb2;
}
