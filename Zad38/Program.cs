// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или меньше 1.");
        }
    }

    return result;
}

double[] GetArray(int number)
{
    double[] array = new double[number];
    Random rnd = new Random ();
    for(int i = 0; i < number; i++)
    {
        array[i] = rnd.Next(0, 100);    //задал от 0 до 100 просто чтоб числа были попроще - не громоздкими
    }
    return array;
}

int number = GetNumber("Задайте количество элементов массива:");
double[] array = GetArray(number);

foreach (var item in array)             //вывод массива. не знаю, нужен ли. в условии нет.
{
    Console.Write(item + " ");
}

double summ = 0;
    Array.Sort(array);
    Console.WriteLine("\nМинимальное значение - " + array[0]);
	Console.WriteLine("Максимальное значение - " + array[array.Length - 1]);
	summ = array[array.Length - 1] - array[0];
    Console.WriteLine($"\nРазница между максимальным и минимальным значениями - {summ}");


