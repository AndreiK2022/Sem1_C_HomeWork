int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}
int x1 = GetNumber("Введите x-координату первой точки");
int y1 = GetNumber("Введите y-координату первой точки");
int z1 = GetNumber("Введите z-координату первой точки");

int x2 = GetNumber("Введите x-координату второй точки");
int y2 = GetNumber("Введите y-координату второй точки");
int z2 = GetNumber("Введите z-координату второй точки");

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(distance);