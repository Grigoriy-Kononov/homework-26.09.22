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

Console.WriteLine("Задача 25: возводит число A в натуральную степень B");
Console.Write("Введите число A: ");
  int first = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{first} в степени {second} = {Exponentiation(first, second)}");


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

Console.WriteLine("Задача 27: выдаёт сумму цифр в числе");
Console.Write("Введите число A: ");
  int only = Convert.ToInt32(Console.ReadLine());
SumOfDigits(only);



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
              array[i] = new Random().Next(lowerlimit, upperlimit+1);
              }
              Console.Write(String.Join(",",array));
              Console.Write(" -> [");
              Console.Write(String.Join(",",array));
              Console.WriteLine("]");
              return arraylength;
              
}

Console.WriteLine("Задача 29: задаёт массив из N элементов и выводит их на экран");
Console.Write("Введите длинну массива: ");
  int arraylength = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите нижний предел массива: ");
  int lowerlimit = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите верхний предел массива: ");
  int upperlimit = Convert.ToInt32(Console.ReadLine());

RandomArray(arraylength, lowerlimit, upperlimit);


/*
Напишите программу, которая задаёт массив из 10 элементов, 
которые необходимо заполнить случайными значениями 
в диапазоне от -10 до 10 и найти максимальное значение среди них
*/

int MaxArray(int arraylength1, int lowerlimit1, int upperlimit1)
{
              int max = 0;
              int[] array1 = new int[arraylength1];
              for (int i = 0; i < array1.Length; i++)
              {
              array1[i] = new Random().Next(lowerlimit1, upperlimit1+1);
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

Console.WriteLine("Задача 29: задаёт массив из N элементов и выводит их на экран и находит максимальное значение среди них");
Console.Write("Введите длинну массива: ");
  int arraylength1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите нижний предел массива: ");
  int lowerlimit1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите верхний предел массива: ");
  int upperlimit1 = Convert.ToInt32(Console.ReadLine());
MaxArray(arraylength1, lowerlimit1, upperlimit1);
