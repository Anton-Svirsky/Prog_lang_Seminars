// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }
// int findQuontityOfPositive(int[] array)
// {
//     int amount = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             amount++;
//         }
//     }
//     return amount;
// }
// int[] array = CreateRandomArray(10, 100, 998);
// int quontity = findQuontityOfPositive(array);
// ShowArray(array);
// Console.Write($" - > {quontity}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }
// int findSumOfNegatives(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i = i + 2)
//         sum = sum + array[i];
//     return sum;
// }
// int[] array = CreateRandomArray(10, 1, 99);
// int sumOfNegative = findSumOfNegatives(array);
// ShowArray(array);
// Console.Write($" - > {sumOfNegative}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }
// int findDifference(int[] array)
// {
//     int maxNumber = array[0];
//     int minNumber = array[0];

//     for (int i = 1; i < array.Length; i++)
//     {
//         if (maxNumber < array[i])
//         {
//             maxNumber = array[i];
//         }
//         if (minNumber > array[i])
//         {
//             minNumber = array[i];
//         }
//     }

//     int dif = maxNumber - minNumber;
//     return dif;
// }
// int[] array = CreateRandomArray(10, 1, 10);
// int difference = findDifference(array);
// ShowArray(array);
// Console.Write($" - > {difference}");