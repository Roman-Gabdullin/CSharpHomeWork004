// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int SumOfDigits(int n1)
{
    int sum = 0;
    for (int i = n1; i > 0 ; i = i / 10)
    {
        int fig = i % 10;
        sum = sum + fig;
    }
    return sum;
}
int Sum = SumOfDigits(num1);
Console.Write($"Сумма цифр числа {num1} = {Sum}");