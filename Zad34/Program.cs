// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int[]GetArray(int number)
{
    int[] array = new int[number];
    Random rnd = new Random ();
    for(int i = 0; i < number; i++)
    {
        array[i] = rnd.Next(99,1000);
    }
    return array;
}

int number = GetNumber("Задайте количество элементов массива:");
int[] array = GetArray(number);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i]%2 == 0)
    {
    count = count + 1;
    }
}
foreach (var item in array)        //вывод массива. не знаю, нужен ли. в условии нет.
{
    Console.Write(item + " ");
}

Console.WriteLine($"\nКоличество четных чисел в массиве: {count}");