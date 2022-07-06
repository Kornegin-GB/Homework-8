// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Результат:
// 1-строка

using System;
using static System.Console;
Clear();

int m = 3; //Ряды массива
int n = 4; //Столбцы массива

int[,] arrayFirst = new int[m, n];

FillArray(arrayFirst);
PrintArray(arrayFirst);
WriteLine();
WriteLine($"{String.Join(", ", SumRowsArray(arrayFirst))}");
WriteLine();

WriteLine($"Результат: Строка с индексом {SerchArray(arrayFirst)} с наименьшей суммой элементов \n");

int SerchArray(int[,] arraySerch) // Находим индекс строки с минимальной суммой элементов строки
{
   int count = 0;
   int row = 0;
   for (int i = 0; i < arraySerch.GetLength(0); i++)
   {
      int sum = 0;
      for (int j = 0; j < arraySerch.GetLength(1); j++)
      {
         sum += arraySerch[i, j];
      }
      if (i == 0) row = sum;
      if (sum < row)
      {
         count = i;
         row = sum;
      }
   }
   return count;
}

int[] SumRowsArray(int[,] arraySumm) // Находим сумму элементов строк двумерного массива (для проверки)
{
   int[] array = new int[arraySumm.GetLength(0)];
   for (int i = 0; i < arraySumm.GetLength(0); i++)
   {
      int sum = 0;
      for (int j = 0; j < arraySumm.GetLength(1); j++)
      {
         sum += arraySumm[i, j];
      }
      array[i] = sum;
   }
   return array;
}

void FillArray(int[,] arrayFill) // Создаем двумерный массив
{
   for (int i = 0; i < arrayFill.GetLength(0); i++)
   {
      for (int j = 0; j < arrayFill.GetLength(1); j++)
      {
         arrayFill[i, j] = new Random().Next(0, 10);
      }
   }
}

void PrintArray(int[,] arrayPrint) // Выводим в консоль двумерный массив
{
   for (int i = 0; i < arrayPrint.GetLength(0); i++)
   {
      for (int j = 0; j < arrayPrint.GetLength(1); j++)
      {
         Write($"{arrayPrint[i, j]} ");
      }
      WriteLine();
   }
}