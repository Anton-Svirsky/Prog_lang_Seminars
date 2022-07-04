// Console.WriteLine("Ввод числа N");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for ( int i = 1; i <= N; i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine(sum);

// Console.Write("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for (int i=1; i <= number; i++)
// {
//     sum +=  i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {number}: {sum}");

// int sum_numbers(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine("Ввод числа N");
//     int N = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(N + "->" + sum_numbers(N));
// }
// void sum_numbers(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i;
//     }
//     Console.WriteLine(num + "->" + sum);
// }


// for (int i = 0; i < 5; i++)
// {
// Console.WriteLine("Ввод числа N");
// int N = Convert.ToInt32(Console.ReadLine());
// sum_numbers(N);

// }

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {   
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = CreateRandomArray(num, min, max);
// ShowArray(myRandomArray);
// Console.WriteLine("-------");
// int[] myArray = CreateArray();
// ShowArray(myArray);
