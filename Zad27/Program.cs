// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("ввели не число или меньше 1.");
        }
    }

    return result;
}
int numbers = GetNumber("Введите число");
string strNumbers = numbers.ToString();

int sum = 0;
foreach (var item in strNumbers)
{
    sum += Convert.ToInt32(item.ToString());
}
Console.WriteLine(sum);