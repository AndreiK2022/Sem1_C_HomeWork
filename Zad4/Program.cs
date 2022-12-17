Console.WriteLine("Введите число a: ");
int numberA = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите число b: ");
int numberB = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите число c: ");
int numberC = int.Parse(Console.ReadLine() ?? "");

int max = numberA;

if(numberB > numberA)
{
    if(numberB > numberC)
    {
    Console.WriteLine($"max = {numberB}");
    }
    else
    Console.WriteLine($"max = {numberC}");
}
else
if(numberA > numberC)
{
    Console.WriteLine($"max = {numberA}");
}
else
Console.WriteLine($"max = {numberC}");