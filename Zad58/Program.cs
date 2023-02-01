// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProdMatrix(int[,] matr1, int[,] matr2)
{
    var matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr3.GetLength(0); i++)
    {
        for (int j = 0; j < matr3.GetLength(1); j++)
        {
            matr3[i, j] = 0;
            for (int n = 0; n < matr1.GetLength(1); n++)
            {
                matr3[i, j] += matr1[i, n] * matr2[n, j];
            }
        }
    }
    return matr3;
}

int r1 = GetNumber("Введите число строк матрицы a: ");
int c1 = GetNumber("Введите число столбцов матрицы a: ");
int r2 = GetNumber("Введите число строк матрицы b: ");
int c2 = GetNumber("Введите число столбцов матрицы b: ");

int[,] a = new int[r1,c1];
int[,] b = new int[r2,c2];

FillArray(a);
FillArray(b);
Console.WriteLine();
PrintArray(a);
Console.WriteLine();
PrintArray(b);

if (c1 == r2)
{
    Console.WriteLine();
    PrintArray(ProdMatrix(a, b));
}
else
{
    Console.WriteLine($"\nПроизведение данных матриц невозможно!");
}