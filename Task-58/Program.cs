// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Массив A:
// 6 0 2
// 0 4 8
// 0 7 9
// Массив В:
// 0 0 3
// 5 0 4
// 8 2 0
// Результат
// 16 4 18
// 84 16 16
// 107 18 28

using System;
using static System.Console;
Clear();

int m = 3; //Ряды массива
int n = 3; //Столбцы массива

int[,] arrayFirst = new int[m, n];
int[,] arraySecond = new int[m, n];

FillArray(arrayFirst);
FillArray(arraySecond);
PrintArray(arrayFirst);
WriteLine();
PrintArray(arraySecond);
WriteLine();
PrintArray(MultiplicatTwoMatrices(arrayFirst, arraySecond));

int[,] MultiplicatTwoMatrices(int[,] arrayOne, int[,] arrayTwo)
{
   int[,] result = new int[arrayOne.GetLength(0), arrayOne.GetLength(1)];
   for (int i = 0; i < arrayOne.GetLength(0) && i < arrayTwo.GetLength(0); i++)
   {
      for (int j = 0; j < arrayOne.GetLength(1) && j < arrayTwo.GetLength(1); j++)
      {
         int sum = 0;
         for (int k = 0; k < arrayOne.GetLength(1) && k < arrayTwo.GetLength(1); k++)
         {
            sum += arrayOne[i, k] * arrayTwo[k, j];
         }
         result[i, j] = sum;
      }
   }
   return result;
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