// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
void Exponentiation(int n1,int n2)
{
    int expon = n1;
    for (int i = 1; i < n2; i++)
    {
        expon = expon * n1;
    }
    Console.Write($"Число {n1}, возведенное в степень {n2} = {expon}");
}
Exponentiation(a,b);