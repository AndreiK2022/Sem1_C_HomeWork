// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        array[i] = rnd.Next(-100, 100);    //задал от -100 до 100 просто чтоб числа были попроще - не громоздкими
    }
    return array;
}

int number = GetNumber("Задайте количество элементов массива:");
int[] array = GetArray(number);
int summ = 0;

for (int i = 0; i < array.Length; i++)
{
    if(i%2 > 0)
    {
    summ = summ + array[i];
    }
}
foreach (var item in array)             //вывод массива. не знаю, нужен ли. в условии нет.
{
    Console.Write(item + " ");
}

Console.WriteLine($"\nСумма чисел на нечетных позициях: {summ}");