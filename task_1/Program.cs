// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateFillArray()
{

  int[,] arr = new int[10, 20];
  Console.WriteLine();
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = Random.Shared.Next(10);
      Console.Write($"|{arr[i, j],2} | ");
    }
    Console.WriteLine();
  }
  return arr;
}
int[] GetSumLine(int[,] array)
{
  int[] arrSum = new int[array.GetLength(0)];
  int sum = 0;
  Console.WriteLine();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrSum[i] = sum += array[i, j];
    }
    Console.WriteLine($"Сумма {i + 1} строки равна {arrSum[i]}");
    sum = 0;
  }
  Console.WriteLine();
  return arrSum;
}
int MinValueArray(int[] colection)
{
  int line = 0;
  int min = colection[0];
  for (int i = 0; i < colection.Length; i++)
  {
    if (min > colection[i])
    {
      min = colection[i];
      line = i;
    }
  }
  return min;
}
void CheckMinValueAndPrint(int minValue, int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (minValue == array[i])
    {
      Console.WriteLine($"Строка № {i + 1} имеет наименьшее значение равное {minValue}");
    }
  }
}

int[,] arr = CreateFillArray();
int[] arrSum = GetSumLine(arr);
int min = MinValueArray(arrSum);
CheckMinValueAndPrint(min, arrSum);