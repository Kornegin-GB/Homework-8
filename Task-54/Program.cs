// ** Задача 54.** Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Результат:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;
using System.Linq;
Clear();


int m = 3; //Ряды массива
int n = 4; //Столбцы массива

int[,] arrayFirst = new int[m, n];

FillArray(arrayFirst);
PrintArray(arrayFirst);
SortDescendingArray(arrayFirst);
WriteLine();
PrintArray(arrayFirst);

void SortDescendingArray(int[,] arrayDescending)
{
   for (int i = 0; i < arrayDescending.GetLength(0); i++)
   {
      for (int j = 0; j < arrayDescending.GetLength(1); j++)
      {
         for (var k = 0; k < arrayDescending.GetLength(1); k++)
         {
            if (arrayDescending[i, j] <= arrayDescending[i, k]) continue;
            int temp = arrayDescending[i, j];
            arrayDescending[i, j] = arrayDescending[i, k];
            arrayDescending[i, k] = temp;
         }
      }
   }
}

void FillArray(int[,] arrayFill)
{
   for (int i = 0; i < arrayFill.GetLength(0); i++)
   {
      for (int j = 0; j < arrayFill.GetLength(1); j++)
      {
         arrayFill[i, j] = new Random().Next(0, 10);
      }
   }
}

void PrintArray(int[,] arrayPrint)
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