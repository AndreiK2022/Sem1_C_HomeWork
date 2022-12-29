double[] GetPow(int x)
{
   double[] array = new double[x];
   for (int index = 0; index < x; index++)
   {
       array[index] = Math.Pow(index+1, 3);
   }
   return array;    
}

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

double[] arrayCube = GetPow(number); 
for (int i = 0; i < arrayCube.Length; i++)
{
   Console.WriteLine($"Куб числа {i+1} равен {arrayCube[i]}");
}