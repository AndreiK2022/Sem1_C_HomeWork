Console.WriteLine("Введите число a: ");
int number = int.Parse(Console.ReadLine() ?? "");

int count = 1;

if(number > 0)
{
while(count <= number)
{
    if(count%2 == 0)
    {
    Console.Write(count + " ");
    count = count + 1;
    }
    else
    count = count +1;
}
}
else
if(number <= 0)
{
    while(count >= number)
    {
        if(count%2 == 0)
        {
        Console.Write(count + " ");
        count = count - 1;
        }
        else
        count = count - 1;
}
}