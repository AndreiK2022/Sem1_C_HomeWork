Console.WriteLine("Введите цифру дня недели:");
int number = int.Parse(Console.ReadLine());
if(number > 0 && number < 8)
{
    if(number == 6 || number == 7)
    {
        Console.WriteLine("Этот день - выходной");
    }
    else
    Console.WriteLine("Этот день - не выходной, увы");
}
else
Console.WriteLine("Цифра не соответствует заданному диапазону");