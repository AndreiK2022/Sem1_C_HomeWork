// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Я тут намудрил, конечно. Наверняка можно проще, но, в целом, работает.


Console.WriteLine("Введите несколько чисел через пробел: ");
string numbers = Console.ReadLine();
string[] strNums = numbers.Split(' ');

int[] intNums = new int[strNums.Length];
    for (int i = 0; i < strNums.Length; i++)
    {
        int x;
        if(int.TryParse(strNums[i], out x))
        {
            intNums[i] = x;
        }
        else
        {
            Console.WriteLine($"Элемент №{i + 1} не является числом!");
        }
    }

int summ = 0;
    for (int i = 0; i < intNums.Length; i++)
    {
        if (intNums[i] > 0)
        {
            summ = summ + intNums[i];
        }
    }
Console.WriteLine($"Сумма положительных чисел равна {summ}");