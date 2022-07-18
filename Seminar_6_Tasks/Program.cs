// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write($"Enter amount of numbers: ");
// int Amount = Convert.ToInt32(Console.ReadLine());
// int[] arrayOfNumbers = new int[Amount];

// void InputNumbers(int Amount)
// {
//     for (int i = 0; i < Amount; i++)
//     {
//         Console.Write($"Enter {i + 1} number: ");
//         arrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " , ");
//     }

// }
// int Compare(int[] arrayOfNumbers)
// {
//     int count = 0;
//     for (int i = 0; i < arrayOfNumbers.Length; i++)
//     {
//         if (arrayOfNumbers[i] > 0) count += 1;
//     }
//     return count;
// }

// InputNumbers(Amount);
// ShowArray(arrayOfNumbers);
// Console.Write($" -> {Compare(arrayOfNumbers)}");

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// void FindingInterception()
// {
//     Console.WriteLine("Enter k1 in y = k1 * x + b1:");
//     double k1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Enter b1 in y = k1 * x + b1:");
//     double b1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Enter k2 in y = k2 * x + b2:");
//     double k2 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Enter b2 in y = k2 * x + b2:");
//     double b2 = Convert.ToDouble(Console.ReadLine());

//     if (k1 == k2)
//     {
//         if (b1 == b2)
//         {
//             Console.WriteLine("there are infinitely many points of intersection - the lines coincide");
//         }
//         else
//         {
//             Console.WriteLine("there are no points of intersection - the lines are parallel");
//         }
//     }
//     else
//     {
//         Console.Write($"b1={b1}, k1={k1}, b2={b2}, k2={k2}");
//         double x = (b1 - b2) / (k2 - k1);
//         double y = k1 * x + b1;
//         Console.Write($" - > {x}; {y}");
//     }
// }
// FindingInterception();
