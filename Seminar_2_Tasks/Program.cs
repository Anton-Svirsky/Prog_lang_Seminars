// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Enter three digits number: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(Number);
// Console.WriteLine(Number + " -> "+stringNumber[1]);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Enter a number:");
// int Number = Convert.ToInt32(Console.ReadLine());
// string number = Convert.ToString(Number);
// if (number.Length > 2)
//     Console.WriteLine(Number + " -> " + number[2]);
// else
//     Console.WriteLine("There is no third number");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter a number, which points a day of the week:");
int DayOfTheWeek = Convert.ToInt32(Console.ReadLine());
void DayCheck (int DayOfTheWeek) {
    if (DayOfTheWeek == 6 || DayOfTheWeek == 7)
        Console.WriteLine(DayOfTheWeek + " ->" + " Yeap");
    else if (DayOfTheWeek < 1 || DayOfTheWeek > 7)
        Console.WriteLine("This is not even a day");
    else Console.WriteLine(DayOfTheWeek + " ->" + " Nope");
}
DayCheck(DayOfTheWeek);