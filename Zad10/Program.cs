Console.WriteLine("Введите трёхзначное число:");
int number = int.Parse(Console.ReadLine());
int numberSecondDigit = 0;

if(number < 999 && number >= 100)
{
    numberSecondDigit = (number % 100) / 10;
    Console.WriteLine($"Вторая цифра Вашего числа: {numberSecondDigit}");
}
else

Console.WriteLine("Введено некорректное число");
