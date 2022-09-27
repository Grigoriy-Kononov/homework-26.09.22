Console.Clear();

/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Exponentiation(int first, int second)
{
              int result = 1;
              for (int i = 0; i < second; i++)
              {
                            result = result * first;
              }
              return result;
}


Console.WriteLine(Exponentiation(2, 4));


/*
Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

 int SumOfDigits(int only)
 {
              int count = Convert.ToString(only).Length;
              int temp = 0;
              int result = 0;

              for (int i = 0; i < count; i++)
               {
              temp = only - only % 10;
              result = result + (only - temp);
              only = only / 10;
              }
              Console.WriteLine($"Сумма цифр в числе: {result}");
              return result;
  }

SumOfDigits(452);



/*
Задача 29: Напишите программу, которая задаёт массив из N элементов и 
выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int RandomArray(int arraylength, int lowerlimit, int upperlimit)
{
              int[] array = new int[arraylength];
              for (int i = 0; i < array.Length; i++)
              {
              array[i] = new Random().Next(lowerlimit, upperlimit);
              }
              Console.Write(String.Join(",",array));
              Console.Write(" -> [");
              Console.Write(String.Join(",",array));
              Console.WriteLine("]");
              return arraylength;
              
}

RandomArray(10, -10, 11);


/*
Напишите программу, которая задаёт массив из 10 элементов, 
которые необходимо заполнить случайными значениями 
в диапазоне от -10 до 10 и найти максимальное значение среди них
*/

int MaxArray(int arraylength, int lowerlimit, int upperlimit)
{
              int max = 0;
              int[] array1 = new int[arraylength];
              for (int i = 0; i < array1.Length; i++)
              {
              array1[i] = new Random().Next(lowerlimit, upperlimit);
              if (array1[i] > max)
                            {
                            max = array1[i];
                            }
              }
              Console.Write("[");
              Console.Write(String.Join(",",array1));
              Console.Write("] -> ");
              Console.WriteLine(max);
              return max;
}

MaxArray(10, -10, 11);
