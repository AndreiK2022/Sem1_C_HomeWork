// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
        Console.WriteLine("Ввели не число!");
        }
    }
    return result;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    }
}

int r = GetNumber("Введите кол-во строк массива: ");
int c = GetNumber("Введите кол-во столбцов массива: ");
Console.WriteLine();

int[,] array = new int[r,c];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int[] summ = new int[c];
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        summ[i] = summ[i] + array[i,j];
    }
}

int min = summ[0];
for (int i = 0; i < c; i++)
{
    if (summ[i] < min)
    {
        min = summ[i];  
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов - {Array.IndexOf(summ, min)+1}");