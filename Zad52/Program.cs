// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.WriteLine("Ввели не число или не целое число!");
        }
    }
    return result;
}

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows,columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows,columns] = new Random().Next(0,10);
        }
    }
}

int r = GetNumber("Введите количество строк: ");
int c = GetNumber("Введите количество столбцов: ");

int[,] array = new int[r,c];
Console.WriteLine();

FillArray(array);
PrintArray(array);
Console.WriteLine();

int[] summ = new int[c];

for (int i = 0; i < c; i++)
{
    for (int j = 0; j < r; j++)
    {
        summ[i] = summ[i] + array[j,i];
    }
}

foreach (double item in summ)
{
    Console.Write($"{item/r} ");
}

