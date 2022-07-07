// Задача 62. Заполните спирально массив 4 на 4
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

using System;
using static System.Console;
Clear();

int sizeArray = 4;

int[,] array = FillAray(sizeArray);
PrintArray(array);


int[,] FillAray(int size)
{
   int[,] result = new int[size, size];
   int i = 0;
   int j = 0;
   int rowE = size - 1;
   int columnE = size - 1;
   int rowS = 0;
   int columnS = 0;
   bool left = true;
   bool top = true;
   int count = 0;
   while (count < size * size)
   {
      count++;
      result[i, j] = count;
      //идем вправо
      if (left && top)
      {
         if (j == columnE)
         {
            rowS++;
            top = true;
            left = false;
            i++;
            continue;
         }
         else
         {
            j++;
            continue;
         }
      }
      //идем вниз
      if (!left && top)
      {
         if (i == rowE)
         {
            columnE--;
            top = false;
            left = false;
            j--;
            continue;
         }
         else
         {
            i++;
            continue;
         }
      }
      //идем влево
      if (!left && !top)
      {
         if (j == columnS)
         {
            rowE--;
            top = false;
            left = true;
            i--;
            continue;
         }
         else
         {
            j--;
            continue;
         }
      }
      //Идем вверх
      if (left && !top)
      {
         if (i == rowS)
         {
            columnS++;
            top = true;
            left = true;
            j++;
            continue;
         }
         else
         {
            i--;
            continue;
         }
      }

   }
   return result;
}

void PrintArray(int[,] arrayPrint) // Выводим в консоль двумерный массив
{
   for (int i = 0; i < arrayPrint.GetLength(0); i++)
   {
      for (int j = 0; j < arrayPrint.GetLength(1); j++)
      {
         if (arrayPrint[i, j] < 10) Write($"0{arrayPrint[i, j]} ");
         else Write($"{arrayPrint[i, j]} ");
      }
      WriteLine();
   }
}