Console.WriteLine("Введите число:");
char[] array = Console.ReadLine().ToCharArray();
if(array.Length != 5)
{
    Console.WriteLine("Введено некорректное число");
}
else
if(array[0] == array[4] && array[1] == array[3])
{
Console.WriteLine("Введённое число является палиндромом");
}
else
Console.WriteLine("Введённое не является палиндромом");
