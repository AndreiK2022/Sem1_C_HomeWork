// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArray(double[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    Random rnd = new Random();
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().Next(-100,100);
        }
    }
}

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
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

int m = GetNumber("Введите размер массива m: ");
int n = GetNumber("Введите размер массива n: ");

double[,] array = new double[m,n];
FillArray(array);
PrintArray(array);
