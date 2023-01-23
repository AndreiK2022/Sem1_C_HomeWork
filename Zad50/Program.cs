// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
    Random rnd = new Random();
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows,columns] = rnd.Next(0,10);
        }        
    }
}

int GetNumber(string message)
{
    int result = 0;
    while(true)
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

int x = GetNumber("Задайте координату строки: ");
int y = GetNumber("Задайте координату столбца: ");
Console.WriteLine();

int[,] array = new int[7,7];

FillArray(array);
PrintArray(array);

if(x > array.GetLength(0) || y > array.GetLength(1))
{
    Console.WriteLine("\nТакого числа в массиве нет!");
}
else
{
    Console.WriteLine();                 // Просто чтобы пропустить строчку.
    Console.WriteLine(array[x,y]);
}