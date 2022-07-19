// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] GetArray(int m, int n)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble() * 100 - 50;
//             result[i, j] = Math.Round(result[i, j], 2);
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row, column]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] array = GetArray(rows, columns);
// PrintArray(array);

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// double[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
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
// void FindElement(double[,] InArray)
// {
//     Console.Write("Enter row number: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter column number: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     if (rows >= InArray.GetLength(0) && columns >= InArray.GetLength(1))
//     {
//         Console.WriteLine("There is no such element in this massive: ");
//     }
//     else
//     {
//         Console.WriteLine($"{rows}{columns} - > {InArray[rows, columns]}");
//     }
// }

// double[,] MyArray = GetArray(4, 4, -10, 10);
// PrintArray(MyArray);
// FindElement(MyArray);

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
//     double average = 0;
//     for (int column = 0; column < inArray.GetLength(0); column++)
//     {
//         double sum = 0;
//         for (int row = 0; row < inArray.GetLength(1); row++)
//         {
//             sum = sum + inArray[column, row];
//             Console.Write($"\t {inArray[row, column]} ");
//         }
//         average = sum / inArray.GetLength(0);
//         Console.Write($"\t Column {column + 1} sum is {sum} - > {Math.Round(average, 2)}");
//         Console.WriteLine();
//     }
// }

// int[,] NewArray = GetArray(5, 5, 0, 10);
// PrintArray(NewArray);
