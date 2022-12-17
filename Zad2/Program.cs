Console.WriteLine("Введите число a: ");
int numberA = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите число b: ");
int numberB = int.Parse(Console.ReadLine() ?? "");

if (numberA == numberB)
{
    Console.WriteLine("Числа равны");
}
else
    if(numberA > numberB)
    {
        Console.WriteLine($"max = {numberA}, min = {numberB}");
    }
    else
        Console.WriteLine($"max = {numberB}, min = {numberA}");