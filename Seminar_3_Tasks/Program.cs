// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Enter a five digit number:");
// string Number = Console.ReadLine();
// void CheckingPal(string Number)
// {
//     if (Number[0] == Number[4] || Number[1] == Number[3])
//         Console.WriteLine(Number + " -> Yeap");
//     else Console.WriteLine(Number + " -> Nope");
// }
// if (Number.Length == 5)
//     CheckingPal(Number);
// else Console.WriteLine("Please enter correct number");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Input number: ");
// double number = Convert.ToInt32(Console.ReadLine());
// Console.Write(number + " ->  ");
// if (number >= 0)
// {
//     for (double current = 1; current <= number; current++) 
//     Console.Write(Math.Pow(current , 3) + " , ");
// }
// else
// {
//     for (double current = -1; current >= number; current--)
//         Console.Write(Math.Pow(current , 3) + " , ");
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double SystemCoor(int x1, int y1, int x2, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1) , 2) + Math.Pow((y2 - y1) , 2) + Math.Pow((z2 - z1) , 2));
}
Console.WriteLine("Введите координату x1");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2");
int Bz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A(" + Ax + "," + Ay + "," + Az +"); " + "B(" + Bx + "," + By + "," + Bz +")" + " -> " + Math.Round(SystemCoor(Ax, Ay, Bx, By, Az, Bz), 2));


