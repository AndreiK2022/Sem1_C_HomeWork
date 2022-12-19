Console.WriteLine("Введите число:");
char[] array = Console.ReadLine().ToCharArray();
if(array.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
Console.WriteLine(array[2]);