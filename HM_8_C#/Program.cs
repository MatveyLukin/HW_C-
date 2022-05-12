// // Домашняя работа № 8
// // Задача №1
// // Условие: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4

// // В итоге получается вот такой массив:

// // 1 2 4 7
// // 2 3 5 9
// // 2 4 4 8

// int[,] CreateRandomMatrix(int row, int column)
// {
//     int[,] matr = new int[row, column];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//             if (row == column)
//                 Console.Write($"{matr[i, j]} ");
//             else
//                 Console.WriteLine("Массив не является равносторонним"); // не забыть убрать для последуюющих задач
//         }
//         Console.WriteLine();
//     }
//     return matr;
// }
// // int[,] SortRowMatrix(int[,] matr)
// // {
// //     int min,
// //         temp;
// //     for (int i = 0; i < matr.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matr.GetLength(1) - 1; j++)
// //         {
// //             min = j;
// //             for (int k = j; k < matr.GetLength(1); k++)
// //             {
// //                 if (matr[i, k] < matr[i, min]) min = k;
// //             }
// //             temp = matr[i, j];
// //             matr[i, j] = matr[i, min];
// //             matr[i, min] = temp;
// //         }
// //     }
// //     return matr;
// // }
// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)

//             Console.WriteLine();
//     }
// }
// Console.WriteLine();
// int[,] matr = CreateRandomMatrix(3, 3);
// Console.WriteLine();
// PrintMatrix(SumRowMatrix(matr));

// // Задача №2
// // Условие: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7

// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] SumRowMatrix(int[,] matr)
// {

//     // result;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {

//             sum += matr[i, j];
//             j++;
//             Console.Write($" {sum} ");
//         }

//     }
//     return matr;
// }

// // Задача №3
// // Условие: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// // массив размером 2 x 2 x 2

// // 12(0,0,0) 22(0,0,1)
// // 75(0,1,0) 31(0,1,1)
// // 45(1,0,0) 53(1,0,1)
// // 32(1,1,0) 23(1,1,1)

// // Задача №4
// // Условие: Заполните спирально массив 4 на 4.

// // На выходе получается вот такой массив:

// // 1 2 3 4
// // 12 13 14 5
// // 11 16 15 6
// // 10 9 8 7

int[,] CreateRandomMatrix(int row, int column)
{
    int[,] matr = new int[row, column];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
            if (row == column)
                Console.Write($"{matr[i, j]} ");
            else
                Console.WriteLine("Массив не является равносторонним"); // не забыть убрать для последуюющих задач
        }
        Console.WriteLine();
    }
    return matr;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)

            Console.WriteLine();
    }
}
Console.WriteLine();
int[,] matr = CreateRandomMatrix(3, 3);
Console.WriteLine();
PrintMatrix(SumRowMatrix(matr));
int[,] SumRowMatrix(int[,] matr)
{
int[] SumLane = (sum);
int MinSum = SumLane[0];
for (int i = 1; i < SumLane.length; i++)
{
  if (SumLane[i] < MinSum)
  {
      MinSum = SumLane[i];
  }  
}
Console.WriteLine($"{SumLane[i] + 1}");
    // result;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            sum += matr[i, j];
            
            
        }
        Console.Write($" {sum} ");

    }
    return matr;
}