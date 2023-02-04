// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System.Linq;

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

int m = GetNumber("Введите число m: ");
int n = GetNumber("Введите число n: ");

int Summ(int i, int j)
{
    if (i == 0) return (j * (j + 1)) / 2;            
    else if (j == 0) return (i * (i + 1)) / 2;       
    else if (i == j) return i;                       
    else if (i < j) return j + Summ(i, j - 1); 
    else return j + Summ(i, j + 1);            
}

Console.WriteLine(Summ(m,n));