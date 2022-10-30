// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void FillArray (int[] ran)
{
    int len = ran.Length;
    for (int i = 0; i < len; i++)
    {
        ran[i] = new Random().Next (1, 99 );
    }
}

void Conclusion (int[] ar)
{
    Console.Write("Новый сгенерированный массив -> ");
    int len = ar.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write ($"{ar[i]} ");
    }
}

int [] array = new int[8];

FillArray (array);
Conclusion (array);