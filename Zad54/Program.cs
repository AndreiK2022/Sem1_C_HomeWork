// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int r = GetNumber("Введите количество строк массива: ");
int c = GetNumber("Введите количество столбцов массива: ");

int[,] array = new int[r,c];

FillArray(array);
PrintArray(array);

int[] arr = new int[c];

Console.WriteLine();
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)

    arr[j] = array[i, j];
    Array.Sort(arr);
    Array.Reverse(arr);

    for (int k = 0; k < c; k++)
    {
        array[i, k] = arr[k];
        Console.Write($"{array[i, k]} ");
    }
    Console.WriteLine();
}
        