// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]:D2} ");
        }
        Console.WriteLine();
    }
}


int[,] array = new int[,]
{
    {0, 0, 0, 0},
    {0, 0, 0, 0},
    {0, 0, 0, 0},
    {0, 0, 0, 0},
};

int count = 1;
for (int i = 0; i == 0; i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = count;
        count++;
    } 
}

for (int i = 1; i < array.GetLength(0); i++)
{
    array[i,3] = count;
    count++;
}

for (int j = 2; j >= 0; j--)
    {
        array[3,j] = count;
        count++;
    } 

for (int i = 2; i > 0; i--)
{
    array[i,0] = count;
    count++;
}

for (int i = 1; i == 1; i++)
{
    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        array[i,j] = count;
        count++;
    }
}

for (int j = 2; j >= 0; j--)
    {
        array[2,j] = count;
        count++;
    } 

PrintArray(array);
