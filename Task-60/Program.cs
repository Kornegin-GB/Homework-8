// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(0,1,0) 53(0,1,1)
// 32(1,0,0) 41(1,0,1)
// 66(1,1,0) 88(1,1,1)

using System;
using static System.Console;
Clear();

int x = 2;
int y = 2;
int z = 2;

int[,,] arrayFirst = new int[x, y, z];

FillArray(arrayFirst);
PrintArray(arrayFirst);

void FillArray(int[,,] arrayFill) // Создаем двумерный массив
{
   bool serchNumber = true;
   for (int i = 0; i < arrayFill.GetLength(0); i++)
   {
      for (int j = 0; j < arrayFill.GetLength(1); j++)
      {
         for (int k = 0; k < arrayFill.GetLength(2); k++)
         {
            int temp = new Random().Next(10, 100);
            serchNumber = SerchArray(arrayFill, temp);
            if (!serchNumber)
            {
               k--;
               continue;
            }
            else arrayFill[i, j, k] = temp;
         }
      }
   }
}

bool SerchArray(int[,,] arraySerch, int number) // Создаем двумерный массив
{
   for (int i = 0; i < arraySerch.GetLength(0); i++)
   {
      for (int j = 0; j < arraySerch.GetLength(1); j++)
      {
         for (int k = 0; k < arraySerch.GetLength(2); k++)
         {
            if (arraySerch[i, j, k] == number) return false;
         }
      }
   }
   return true;
}

void PrintArray(int[,,] arrayPrint) // Выводим в консоль двумерный массив
{
   for (int i = 0; i < arrayPrint.GetLength(0); i++)
   {
      for (int j = 0; j < arrayPrint.GetLength(1); j++)
      {
         for (int k = 0; k < arrayPrint.GetLength(2); k++)
         {
            Write($"{arrayPrint[i, j, k]}({i},{j},{k}) ");
         }
         WriteLine();
      }
      WriteLine();
   }
}