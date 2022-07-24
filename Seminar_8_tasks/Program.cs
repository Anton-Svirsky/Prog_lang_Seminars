// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"\t {inArray[row, column]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void SortArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < inArray.GetLength(1) - 1; k++)
//             {
//                 if (inArray[i, k] > inArray[i, k + 1])
//                 {
//                     int temp = inArray[i, k + 1];
//                     inArray[i, k + 1] = inArray[i, k];
//                     inArray[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] NewArray = GetArray(4, 3, 0, 10);
// PrintArray(NewArray);
// SortArray(NewArray);
// Console.WriteLine();
// PrintArray(NewArray);

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой
// элементов.

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"\t {inArray[row, column]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int RowNumber(int[,] inArray)
// {
//     int row = 0;
//     int minSumInRow = 0;
//     for (int i = 0; i < inArray.GetLength(1); i++)
//     {
//         minSumInRow = minSumInRow + inArray[0, i];
//     }
//     for (int i = 1; i < inArray.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             sum = sum + inArray[i, j];
//         }
//         if (minSumInRow > sum)
//         {
//             minSumInRow = sum;
//             row = i;
//         }
//     }
//     return row + 1;
// }

// int[,] newArray = GetArray(5, 5, 0, 10);
// PrintArray(newArray);
// Console.WriteLine($"Row with min sum - {RowNumber(newArray)}");

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.Write("Enter first massive row number: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter first massive columns number: ");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second massive row number: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second massive columns number: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// if (columns1 != rows2)
// {
//     Console.WriteLine("such matrices cannot be multiplied");
// }
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"\t {inArray[row, column]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] MatrixMultiplication(int[,] inArray1, int[,] inArray2)
// {
//     int[,] multipliedArray = new int[inArray1.GetLength(0), inArray2.GetLength(1)];
//     for (int i = 0; i < inArray1.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray2.GetLength(1); j++)
//         {
//             for (int k = 0; k < inArray1.GetLength(1); k++)
//             {
//                 multipliedArray[i, j] += inArray1[i, k] * inArray2[k, j];
//             }
//         }
//     }
//     return multipliedArray;
// }
// int[,] Array1 = GetArray(rows1, columns1, 0, 10);
// int[,] Array2 = GetArray(rows2, columns2, 0, 10);
// PrintArray(Array1);
// Console.WriteLine();
// PrintArray(Array2);
// Console.WriteLine();
// PrintArray(MatrixMultiplication(Array1, Array2));

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// int[,,] GetArray(int[] sizes, int min, int max)
// {
//     int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             int k = 0;
//             while (k < result.GetLength(2))
//             {
//                 int element = new Random().Next(min, max + 1);
//                 if (FindElement(result, element)) continue;
//                 result[i, j, k] = element;
//                 k++;
//             }
//         }
//     }
//     return result;
// }


// bool FindElement(int[,,] inArray, int el)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < inArray.GetLength(2); k++)
//             {
//                 if (inArray[i, j, k] == el) return true;
//             }
//         }
//     }
//     return false;
// }
// void PrintArray(int[,,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < inArray.GetLength(2); k++)
//             {
//                 Console.Write($"{inArray[i, j, k]} ({i},{j},{k})   ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Enter the dimensions of the array separated by a space:");
// string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] newArray = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]) }, 0, 10);
// PrintArray(newArray);

// Заполните спирально массив 4 на 4.

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// int n = 4;
// int[,] spiralFilledArray = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= spiralFilledArray.GetLength(0) * spiralFilledArray.GetLength(1))
// {
//   spiralFilledArray[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < spiralFilledArray.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= spiralFilledArray.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > spiralFilledArray.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// PrintArray(spiralFilledArray);

