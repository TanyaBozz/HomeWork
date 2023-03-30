// 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

// int decNum = 3;
// string result = DecToBin(decNum);

// Console.WriteLine($" {decNum} -> {result}");

// string DecToBin(int decimalNumber)
// {
//     if (decimalNumber == 0 || decimalNumber == 1)
//     {
//         return decimalNumber.ToString();
//     }

//     string dec = string.Empty;
//     while (decimalNumber > 0)
//     {
//         dec = decimalNumber % 2 + dec;
//         decimalNumber /= 2;
//     }
//     return dec;
// }

int decNum = 2
;
int result = DecToBinInt(decNum);

Console.WriteLine($" {decNum} -> {result}");

int DecToBinInt(int decimalNumber)
{
    if (decimalNumber == 0 || decimalNumber == 1)
    {
        return decimalNumber;
    }

    int dec = 0;
    int i = 1;
    while (decimalNumber > 0)
    {
        dec = dec + decimalNumber % 2 * i;
        decimalNumber /= 2;
        i *= 10;
    }
    return dec;
}
