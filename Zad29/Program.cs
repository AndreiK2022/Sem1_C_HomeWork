
//способ 1

// int GetNumber(string message)
// {
//     int result = 0;

//     while(true)
//     {
//         Console.WriteLine(message);

//         if(int.TryParse(Console.ReadLine(), out result))
//         {
//             break;
//         }
//         else
//         {
//             Console.WriteLine("ввели не число");
//         }
//     }

//     return result;
// }

// int[]GetArray(int number)
// {
//     int[] array = new int[number];
//     Random rnd = new Random ();
//     for(int i = 0; i < number; i++)
//     {
//         array[i] = rnd.Next(-99,99);
//     }
//     return array;
// }

// int number = GetNumber("Введите количество элементов массива:");


// int[] arr = GetArray(number);

// for (int i = 0; i < number; i++)
// {
//     Console.Write(arr[i] + " ");
// }

//способ 2

Console.WriteLine("Введите 8 элементов массива через пробел:");
string[] array = Console.ReadLine().Split(' ');

if (array.Length < 8 || array.Length > 8)
{
    Console.WriteLine("Введено не 8 элементов");
}
else
foreach (var item in array)
{
    Console.Write(item + " ");
}
